using System.Threading.Tasks;
using MongoDB.Driver;

namespace Clients.Persistance
{
    public class GetClient:Client
    {
        private Client _client;
        private IMongoCollection<Client> _collection;
        public GetClient(Client client,IMongoClient mongoClient) : base(client)
        {
            _client = client;
            _collection = mongoClient.GetDatabase("Clients").GetCollection<Client>(nameof(Client));
        }

        public async Task<Client> Get(int id)
        {
            var filter = Builders<Client>.Filter.Eq(c => c.Id, id);
            var collection = await _collection.Find(filter).FirstOrDefaultAsync();
            return collection;
        }
    }
}