using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Clients.Domain.Models;

namespace Clients.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClient();
        Task<Client> GetById(int id);
        Task Create(Client client);
    }
}