using System.Collections.Generic;
using System.Threading.Tasks;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using MongoDB.Driver;

namespace Clients.Domain.Repositories
{
    public class ClientRepository:Mongo<Client>,IClientRepository
    {
        public ClientRepository(IMongoClient client):base(client)
        {
           
        }
        public async Task<IEnumerable<Client>> GetClient()
        {
            var  collection = await Collection.Find(_ => true).ToListAsync();
            return collection;
        }

        public async Task<Client> GetById(int id)
        {
            var filter = Builders<Client>.Filter.Eq(c => c.Id, id);
            var collection = await Collection.Find(filter).FirstOrDefaultAsync();
            return collection;
        }

        public async Task Create(Client client)
        {
            var id = await GetId();
            client.Id = ++id;
            await Collection.InsertOneAsync(client);
            await SetId(id);
        }

        public async Task Update(Client client,int id)
        {
            var filter = Builders<Client>.Filter.Eq(c => c.Id, id);
            await Collection.DeleteOneAsync(filter);
        }

        public async Task Delete(int id)
        {
            var filter = Builders<Client>.Filter.Eq(c => c.Id, id);
            await Collection.DeleteOneAsync(filter);
        }
    }
}