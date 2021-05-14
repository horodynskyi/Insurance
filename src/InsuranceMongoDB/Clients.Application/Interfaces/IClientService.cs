using System.Collections.Generic;
using System.Threading.Tasks;

using Clients.Domain.Models;

namespace Clients.Application.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetClient();
        Task<Client> GetById(int id);

        Task CreateClient(Client client);
    }
}