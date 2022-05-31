using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Domain.Model
{
    public class GameAndDiscount
    {
        public Game Game { get; }

        public Discount Discount { get; }

        public GameAndDiscount(Game game, Discount discount)
        {
            Game = game;
            Discount = discount;
        }
    }
}
