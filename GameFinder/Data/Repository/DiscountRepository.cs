using GameFinder.Domain.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.Data.Repository
{
    public class DiscountRepository
    {
        private IMongoCollection<Discount> external;

        public DiscountRepository(IMongoCollection<Discount> collection)
        {
            external = collection;
        }

        public List<Discount> GetAll() => external.Find(new BsonDocument()).ToList();

        public Discount GetByGameId(ObjectId gameId)
        {
            var filter = Builders<Discount>.Filter.Where(d => d.GameId == gameId);
            return external.Find(filter).SingleOrDefault();
        }

        public void Insert(Discount discount) => external.InsertOne(discount);

        public void DeleteById(ObjectId id) => external.DeleteOne(d => d.Id == id);

        public void FillWithDefault()
        {
            Insert(new Discount(
                gameId: new ObjectId("000000000000000000000003"),
                price: 1250
            ));
            Insert(new Discount(
                gameId: new ObjectId("000000000000000000000009"),
                price: 800
            ));
        }
    }
}
