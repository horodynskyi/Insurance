using System;
using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Clients.Commands;
using Clients.Application.Interfaces;
using Clients.Domain.Models;
using MediatR;
using MongoDB.Driver;

namespace Clients.Application.Handlers
{
    public class CreateClientHandler : IRequestHandler<CreateClientComand>
    {
        private readonly IClientService _clientService;

        public CreateClientHandler(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<Unit> Handle(CreateClientComand request, CancellationToken cancellationToken)
        {
            await _clientService.CreateClient(request.Client);
            return Unit.Value;
        }
    }
}