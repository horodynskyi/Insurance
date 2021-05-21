using System.Threading.Tasks;
using MongoDB.Driver;

namespace InsuranceQueue.Persistance.Interfaces
{
    public interface IUpdateClient:IClient
    {
        Task Update(int id, string firstName, string secondNamet,IMongoCollection<Client> collection);
    }
}