using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Clients.Commands;
using Clients.Domain.Interfaces;
using MediatR;

namespace Clients.Application.Clients.Handlers
{
    public class DeleteClientHandler:IRequestHandler<DeleteClientCommand,Unit>
    {
        private IClientRepository _repository;

        public DeleteClientHandler(IClientRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            await _repository.Delete(request.Id);
            return await Unit.Task;
        }
    }
}