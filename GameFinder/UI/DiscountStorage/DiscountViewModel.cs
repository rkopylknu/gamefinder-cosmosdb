using GameFinder.Data.Repository;
using GameFinder.DI;
using GameFinder.Domain.Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace GameFinder.UI.DiscountStorage
{
    public class DiscountViewModel
    {
        private GameRepository gameRepository;
        private DiscountRepository discountRepository;

        public DiscountViewModel(RepositoryModule repositoryModule)
        {
            gameRepository = repositoryModule.GameRepository;
            discountRepository = repositoryModule.DiscountRepository;
        }

        public List<Game> GetGames() => gameRepository.GetAll();

        public List<GameAndDiscount> GetGamesAndDiscounts()
        {
            var discounts = discountRepository.GetAll();

            List<GameAndDiscount> gamesAndDiscounts = new List<GameAndDiscount>();
            foreach (var discount in discounts)
            {
                gamesAndDiscounts.Add(
                    new GameAndDiscount(
                        game: gameRepository.GetById(discount.GameId),
                        discount: discount
                    )
                );
            }

            return gamesAndDiscounts;
        }

        public void OnIncreaseGameCount(int selectedGameIndex)
        {
            Game game = gameRepository.GetAll()[selectedGameIndex];
            var countUpdate = Builders<Game>.Update.Set(g => g.Count, game.Count + 1);
            gameRepository.UpdateById(game.Id, countUpdate);
        }

        public void OnDecreaseGameCount(int selectedGameIndex)
        {
            Game game = gameRepository.GetAll()[selectedGameIndex];
            if (game.Count > 0)
            {
                var countUpdate = Builders<Game>.Update.Set(g => g.Count, game.Count - 1);
                gameRepository.UpdateById(game.Id, countUpdate);
            }
        }

        public void OnDeleteGame(int selectedGameIndex)
        {
            Game game = gameRepository.GetAll()[selectedGameIndex];
            Discount discount = discountRepository.GetByGameId(game.Id);
            if (discount != null)
            {
                discountRepository.DeleteById(discount.Id);
            }

            gameRepository.DeleteById(game.Id);
        }

        public void OnDeleteDiscount(int selectedDiscountIndex)
        {
            Discount discount = discountRepository.GetAll()[selectedDiscountIndex];
            discountRepository.DeleteById(discount.Id);
        }
    }
}
