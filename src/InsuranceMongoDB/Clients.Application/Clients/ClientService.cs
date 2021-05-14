using System.Collections.Generic;
using System.Threading.Tasks;
using Clients.Application.Interfaces;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;

namespace Clients.Application.Services
{
    public class ClientService:IClientService
    {
        private IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Client>> GetClient()
        {
            return await _repository.GetClient();
        }

        public async Task<Client> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task CreateClient(Client client)
        {
            await _repository.Create(client);
        }
    }
}