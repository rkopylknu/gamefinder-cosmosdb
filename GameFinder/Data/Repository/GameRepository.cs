using GameFinder.Domain.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.Data.Repository
{
    public class GameRepository
    {
        private IMongoCollection<Game> external;

        public GameRepository(IMongoCollection<Game> collection)
        {
            external = collection;
        }

        public List<Game> GetAll() => external.Find(new BsonDocument()).ToList();

        public List<Game> GetByName(string name) {
            var filter = Builders<Game>.Filter.Where(g => g.Name.Contains(name));
            return external.Find(filter).ToList();
        }

        public Game GetById(ObjectId id) => external.Find(g => g.Id == id).Single();

        public void Insert(Game game) => external.InsertOne(game);


        public void UpdateById(ObjectId id, UpdateDefinition<Game> update)
        {
            var filter = Builders<Game>.Filter.Eq(g => g.Id, id);
            external.UpdateOne(filter, update);
        }


        public void DeleteById(ObjectId id) => external.DeleteOne(g => g.Id == id);


        public void FillWithDefault()
        {
            Insert(new Game(
                name: "Far Cry 6",
                manufacturer: "Ubisoft",
                store: "True Games",
                genres: new List<string>() { "shooter", "adventure" },
                year: 2021,
                price: 1800,
                languages: new List<string>() { "en", "fr", "de", "sp", "ru", "ja" },
                count: 25
            ));
            Insert(new Game(
                name: "Battlefield 4",
                manufacturer: "Electronic Arts",
                store: "True Games",
                genres: new List<string>() { "shooter" },
                year: 2013,
                price: 900,
                languages: new List<string>() { "en", "fr", "de", "sp", "ru", "ua", "ja" },
                count: 10
            ));
            Insert(new Game(
                id: new ObjectId("000000000000000000000003"),
                name: "Battlefield 5",
                manufacturer: "Electronic Arts",
                store: "True Games",
                genres: new List<string>() { "shooter", "battle royale" },
                year: 2015,
                price: 1500,
                languages: new List<string>() { "en", "fr", "de", "sp", "ru", "ja" },
                count: 25
            ));
            Insert(new Game(
                name: "Cyberpunk 2077",
                manufacturer: "CD Projekt RED",
                store: "True Games",
                genres: new List<string>() { "role-playing" },
                year: 2020,
                price: 1700,
                languages: new List<string>() { "en", "fr", "de", "sp", "ru", "ja" },
                count: 40
            ));
            Insert(new Game(
                name: "The Witcher 3: Wild Hunt",
                manufacturer: "CD Projekt RED",
                store: "True Games",
                genres: new List<string>() { "role-playing" },
                year: 2015,
                price: 750,
                languages: new List<string>() { "en", "fr", "de", "sp", "ru", "ua", "ja" },
                count: 15
            ));
            Insert(new Game(
                name: "The Witcher 2: Assassins of Kings",
                manufacturer: "CD Projekt RED",
                store: "Digitalize",
                genres: new List<string>() { "role-playing" },
                year: 2011,
                price: 500,
                languages: new List<string>() { "en", "fr", "de", "sp", "ru" },
                count: 5
            ));
            Insert(new Game(
                name: "Half-Life 2",
                manufacturer: "Valve",
                store: "Digitalize",
                genres: new List<string>() { "shooter" },
                year: 2004,
                price: 300,
                languages: new List<string>() { "en", "fr", "de", "sp", "ja" },
                count: 10
            ));
            Insert(new Game(
                name: "Portal 2",
                manufacturer: "Valve",
                store: "Digitalize",
                genres: new List<string>() { "puzzle-platform" },
                year: 2011,
                price: 250,
                languages: new List<string>() { "en", "fr", "de", "sp", "ru", "ja" },
                count: 15
            ));
            Insert(new Game(
                id: new ObjectId("000000000000000000000009"),
                name: "Half-Life: Alyx",
                manufacturer: "Valve",
                store: "Digitalize",
                genres: new List<string>() { "shooter" },
                year: 2020,
                price: 1100,
                languages: new List<string>() { "en", "fr", "de", "sp" },
                count: 30
            ));
        }
    }
}