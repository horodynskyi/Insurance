using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using MongoDB.Driver;

namespace Clients.Domain.Repositories
{
    public class ClientRepository:IClientRepository
    {
        private readonly IMongoCollection<Client> _collection;

        public ClientRepository(IMongoClient client)
        {
            var database = client.GetDatabase("Clients");
            var collection = database.GetCollection<Client>(nameof(Client));
            _collection = collection;
           
        }

        public async Task<IEnumerable<Client>> GetClient()
        {
            var  collection = await _collection.Find(_ => true).ToListAsync();
            return collection;
        }

        public async Task<Client> GetById(int id)
        {
            var filter = Builders<Client>.Filter.Eq(c => c.Id, id);
            var collection = await _collection.Find(filter).FirstOrDefaultAsync();
            return collection;
        }

        public async Task Create(Client client)
        {
            await _collection.InsertOneAsync(client);
        }
    }
}