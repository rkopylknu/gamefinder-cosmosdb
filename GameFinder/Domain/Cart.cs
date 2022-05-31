using GameFinder.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.Domain
{
    class Cart
    {
        private Dictionary<GameAndDiscount, int> items;
        public Dictionary<GameAndDiscount, int> Items => 
            items.ToDictionary(i => i.Key, i => i.Value);

        public Cart() {
            items = new Dictionary<GameAndDiscount, int>();
        }

        public int GetTotal() => items.Sum(gd =>
            gd.Key.Discount == null ? gd.Key.Game.Price * gd.Value :
                gd.Key.Discount.Price * gd.Value
        );

        public void Add(GameAndDiscount gd, int count) => items[gd] = count;

        public void Remove(GameAndDiscount gd) => items.Remove(gd);

        public void Clear() => items.Clear();
    }
}
