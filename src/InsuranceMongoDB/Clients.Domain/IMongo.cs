using System.Threading.Tasks;

namespace Clients.Domain
{
    public interface IMongo
    {
        Task<int> GetId();
        Task SetId(int id);
    }
}