using GameFinder.Data.Repository;
using GameFinder.DI;
using GameFinder.Domain.Model;
using System;
using System.Linq;

namespace GameFinder.UI.DiscountStorage.Create
{
    public class CreateDiscountViewModel
    {
        private GameRepository gameRepository;
        private DiscountRepository discountRepository;

        private Game selectedGame;

        public CreateDiscountViewModel(RepositoryModule repositoryModule)
        {
            gameRepository = repositoryModule.GameRepository;
            discountRepository = repositoryModule.DiscountRepository;
        }

        public int GetGamePrice() => selectedGame.Price;

        public bool TrySelectGame(
            string gameName,
            string gameManufacturer,
            string gameStore
        )
        {
            try
            {
                selectedGame = gameRepository.GetAll().Single(g =>
                    g.Name == gameName && g.Manufacturer == gameManufacturer && g.Store == gameStore
                );
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateDiscount(int price)
        {
            if (discountRepository.GetByGameId(selectedGame.Id) == null)
            {
                discountRepository.Insert(new Discount(selectedGame.Id, price));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
