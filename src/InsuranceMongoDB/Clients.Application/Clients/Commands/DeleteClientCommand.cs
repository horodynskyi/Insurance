using MediatR;

namespace Clients.Application.Clients.Commands
{
    public class DeleteClientCommand:IRequest
    {
        public DeleteClientCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        
    }
}