using System.Threading.Tasks;
using MongoDB.Driver;

namespace InsuranceQueue.Persistance.Interfaces
{
    public interface IDeleteClient:IClientGetId
    {
        Task Delete(IMongoCollection<Client> collection);
    }
}