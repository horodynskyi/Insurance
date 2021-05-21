using System.Threading.Tasks;
using InsuranceQueue.Persistance.Interfaces;
using MongoDB.Driver;

namespace InsuranceQueue.Persistance
{
    public class DeleteClient:Client,IDeleteClient
    {
        public DeleteClient(int id, string firstName, string secondName) : base(id, firstName, secondName)
        {
        }

        public async Task Delete(IMongoCollection<Client> collection)
        {
            var filter = Builders<Client>.Filter.Eq(c => c.GetId(), GetId());
            await collection.DeleteOneAsync(filter);
        }

        
    }
}