using GameFinder.Domain.Model;
using GameFinder.Data.Repository;
using MongoDB.Driver;
using System.Security.Authentication;
using System.Collections.Generic;
using MongoDB.Bson;
using System;

namespace GameFinder.DI
{
    public class RepositoryModule
    {
        private const string CONNECTION_STRING = "<INSERT CONNECTION STRING HERE>";
        
        private const string DATABASE_NAME = "<INSERT DATABASE NAME HERE>";

        public GameRepository GameRepository { get; }

        public DiscountRepository DiscountRepository { get; }

        public RepositoryModule()
        {
            MongoClientSettings settings = MongoClientSettings.FromUrl(
                new MongoUrl(CONNECTION_STRING)
            );
            settings.SslSettings =
              new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            var mongoClient = new MongoClient(settings);

            bool databaseExisted = mongoClient.ListDatabaseNames().ToList().IndexOf(DATABASE_NAME) >= 0;
            IMongoDatabase database = mongoClient.GetDatabase(DATABASE_NAME);
            
            GameRepository = new GameRepository(database.GetCollection<Game>("games"));
            DiscountRepository = new DiscountRepository(database.GetCollection<Discount>("discounts"));

            if (!databaseExisted)
            {
                GameRepository.FillWithDefault();
                DiscountRepository.FillWithDefault();
            }
        }
    }
}
