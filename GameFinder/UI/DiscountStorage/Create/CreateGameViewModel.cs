using GameFinder.Data.Repository;
using GameFinder.DI;
using GameFinder.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.UI.DiscountStorage.Create
{
    public class CreateGameViewModel
    {
        private GameRepository gameRepository;

        public CreateGameViewModel(RepositoryModule repositoryModule)
        {
            gameRepository = repositoryModule.GameRepository;
        }

        public void CreateGame(
            string name,
            string manufacturer,
            string store,
            List<string> genres,
            int year,
            int price,
            List<string> languages,
            int count
        )
        {
            gameRepository.Insert(
                new Game(
                    name,
                    manufacturer,
                    store,
                    genres,
                    year,
                    price,
                    languages,
                    count
                )
            );
        }
    }
}
