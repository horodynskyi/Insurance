using InsuranceQueue.Persistance.Interfaces;
using MongoDB.Driver;

namespace InsuranceQueue.Persistance
{
    public class Mongo:IMongo
    {
        public Mongo(IMongoClient client)
        {
            Collection = client.GetDatabase("Clients").GetCollection<Client>("Clients");
        }

        public IMongoCollection<Client> Collection { get; }
    }
}