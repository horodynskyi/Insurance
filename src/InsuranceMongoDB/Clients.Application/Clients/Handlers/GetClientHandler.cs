using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Interfaces;
using Clients.Application.Queries;
using Clients.Application.Queries.Clients;
using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Handlers
{
      public class GetClientQueryHandler:IRequestHandler<GetClientQuery,Client>
        {
            private readonly IClientService _clientService;

            public GetClientQueryHandler(IClientService clientService)
            {
                _clientService = clientService;
            }

            public async Task<Client> Handle(GetClientQuery request, CancellationToken cancellationToken)
            {
                var result  = await _clientService.GetById(request.Id);
                return result;
            }
        }
}