using System.Threading.Tasks;
using InsuranceQueue.Persistance.Interfaces;
using MongoDB.Driver;

namespace InsuranceQueue.Persistance
{
    public class UpdateClient : Client, IUpdateClient
    {
        public UpdateClient(int id, string firstName, string secondName) : base(id, firstName, secondName)
        {
        }

        public async Task Update(int id, string firstName, string secondName, IMongoCollection<Client> collection)
        {
            SetId(id);
            SetFirstName(firstName);
            SetSecondName(secondName);
            var filter = Builders<Client>.Filter.Eq(c => c.GetId(), id);
            await collection.DeleteOneAsync(filter);
        }
    }
}