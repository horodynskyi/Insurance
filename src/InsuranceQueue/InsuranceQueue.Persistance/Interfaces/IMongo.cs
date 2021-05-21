using MongoDB.Driver;

namespace InsuranceQueue.Persistance.Interfaces
{
    public interface IMongo
    {
        IMongoCollection<Client> Collection { get; }
    }
}