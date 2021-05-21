using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Clients.Domain
{
    public class Mongo<TEntity> : IMongo
    {
        protected readonly IMongoCollection<TEntity> Collection;
        protected readonly IMongoClient Client;

        public Mongo(IMongoClient client)
        {
            Client = client;
            var database = client.GetDatabase("Clients");
            var collection = database.GetCollection<TEntity>(typeof(TEntity).Name);
            Collection = collection;
        }

        public async Task<int> GetId()
        {
            var data = await Client.GetDatabase("Clients").GetCollection<BsonDocument>("EntityId").AsQueryable()
                .ToListAsync();
            return data[0][typeof(TEntity).Name + "Id"].AsInt32;
        }

        public async Task SetId(int id)
        {
            var collection = Client.GetDatabase("MongoDB").GetCollection<BsonDocument>("EntityId");
            var data = await collection.AsQueryable().ToListAsync();
            data[0][typeof(TEntity).Name + "Id"] = id;
            await collection.ReplaceOneAsync(Builders<BsonDocument>.Filter.Eq("_id", data[0]["_id"]),
                data[0].ToBsonDocument());
        }
    }
}