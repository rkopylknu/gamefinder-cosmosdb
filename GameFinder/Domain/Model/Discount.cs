using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Domain.Model
{
    public class Discount
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("game")]
        public ObjectId GameId { get; set; }

        [BsonElement("price")]
        public int Price { get; set; }

        public Discount(ObjectId gameId, int price)
        {
            GameId = gameId;
            Price = price;
        }
    }
}
