using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Interfaces;
using Clients.Application.Queries.Clients;
using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Handlers
{
    public class GetAllClientHandler:IRequestHandler<GetlAllClientsQuery,IEnumerable<Client>>
    {
        private readonly IClientService _clientService;

        public GetAllClientHandler(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IEnumerable<Client>> Handle(GetlAllClientsQuery request, CancellationToken cancellationToken)
        {
            return await _clientService.GetClient();
        }
    }
}