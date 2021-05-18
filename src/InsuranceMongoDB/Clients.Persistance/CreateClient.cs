using System.Threading.Tasks;
using MongoDB.Driver;

namespace Clients.Persistance
{
    public class CreateClient:Client
    {
        private Client _client;
        private IMongoCollection<Client> _collection;
        public async Task Create()
        {
            await _collection.InsertOneAsync(_client);
        }

        public CreateClient(Client client,IMongoClient mongoClient) : base(client)
        {
            _client = client;
            _collection = mongoClient.GetDatabase("Clients").GetCollection<Client>(nameof(Client));
        }
    }
}