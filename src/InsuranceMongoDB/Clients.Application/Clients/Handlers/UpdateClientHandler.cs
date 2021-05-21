using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Clients.Commands;
using Clients.Domain.Interfaces;
using MediatR;

namespace Clients.Application.Clients.Handlers
{
    public class UpdateClientHandler:IRequestHandler<UpdateClientCommand,Unit>
    {
        private IClientRepository _repository;

        public UpdateClientHandler(IClientRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            await _repository.Update(request.Client, request.Id);
            return await Unit.Task;
        }
    }
}