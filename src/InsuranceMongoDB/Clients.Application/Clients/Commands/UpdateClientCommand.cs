using MediatR;

namespace Clients.Application.Clients.Commands
{
    public class UpdateClientCommand:IRequest
    {
        public UpdateClientCommand(Domain.Models.Client client, int id)
        {
            this.Client = client;
            Id = id;
        }

        public int Id { get;}
        public Domain.Models.Client Client { get; }
    }
}