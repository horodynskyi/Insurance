using System;
using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Clients.Commands;
using Clients.Application.Interfaces;
using Clients.Application.Sender;
using Clients.Domain.Models;
using MediatR;
using MongoDB.Driver;

namespace Clients.Application.Handlers
{
    public class CreateClientHandler : IRequestHandler<CreateClientComand>
    {
        private readonly IClientService _clientService;
        private readonly IClientSender _clientSender;
        public CreateClientHandler(IClientService clientService, IClientSender clientSender)
        {
            _clientService = clientService;
            _clientSender = clientSender;
        }

        public async Task<Unit> Handle(CreateClientComand request, CancellationToken cancellationToken)
        {
            await _clientService.CreateClient(request.Client);
            await _clientSender.Send(request.Client);
            return Unit.Value;
        }
    }
}