using GameFinder.Domain.Model;
using GameFinder.Data.Repository;
using GameFinder.DI;
using System.Collections.Generic;
using System.Linq;
using GameFinder.Domain;
using MongoDB.Driver;

namespace GameFinder.UI.Buy
{
    public class BuyViewModel
    {
        private GameRepository gameRepository { get; }
        private DiscountRepository discountRepository { get; }

        private List<GameAndDiscount> searchResult;
        public List<GameAndDiscount> SearchResult => searchResult.ToList();

        private Cart cart;

        public BuyViewModel(RepositoryModule repositoryModule)
        {
            gameRepository = repositoryModule.GameRepository;
            discountRepository = repositoryModule.DiscountRepository;
            cart = new Cart();
        }

        public string[] GetManufacturers() => gameRepository.GetAll()
            .Select(g => g.Manufacturer).Distinct()
            .Append(string.Empty).ToArray();

        public void OnSearch(string name, string manufacturer, bool sortByPrice)
        {
            List<Game> games = gameRepository.GetByName(name);
            if (!string.IsNullOrEmpty(manufacturer))
            {
                games = games.Where(g => g.Count > 0 && g.Manufacturer == manufacturer).ToList();
            }
            if (sortByPrice)
            {
                games = games.OrderBy(g => g.Price).ToList();
            }
                
            List<Discount> discounts = discountRepository.GetAll();

            List<GameAndDiscount> gamesAndDiscounts = new List<GameAndDiscount>();
            foreach (Game game in games)
            {
                gamesAndDiscounts.Add(
                    new GameAndDiscount(
                        game: game,
                        discount: discounts.SingleOrDefault(d => d.GameId == game.Id)
                    )
                );
            }

            searchResult = gamesAndDiscounts;
        }

        public int GetCartTotal() => cart.GetTotal();

        public Dictionary<GameAndDiscount, int> GetCartItems() => cart.Items;

        public void OnGameAddToCart(int selectedGameIndex, int count)
        {
            GameAndDiscount gd = searchResult[selectedGameIndex];
            cart.Add(gd, count);
        }

        public void OnRemoveFromCart(int selectedGameIndex)
        {
            GameAndDiscount gd = cart.Items.Keys.ToArray()[selectedGameIndex];
            cart.Remove(gd);
        }

        public void OnCartClear() => cart.Clear();

        public bool OnCheckout()
        {
            if (cart.Items.Count == 0)
                return false;

            foreach (GameAndDiscount gd in cart.Items.Keys)
            {
                var update = Builders<Game>.Update
                    .Set(g => g.Count, gd.Game.Count - cart.Items[gd]);
                gameRepository.UpdateById(gd.Game.Id, update);
            }
            cart.Clear();
            return true;
        }
    }
}
