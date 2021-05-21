using MediatR;

namespace Clients.Application.Documents.Commands
{
    public class DeleteDocumentCommand:IRequest
    {
        public DeleteDocumentCommand(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}