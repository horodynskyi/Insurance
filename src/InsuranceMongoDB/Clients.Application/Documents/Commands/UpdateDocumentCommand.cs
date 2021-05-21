using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Documents.Commands
{
    public class UpdateDocumentCommand:IRequest
    {
        public int Id { get;}
        private Document Document;

        public UpdateDocumentCommand(Document document, int id)
        {
            Document = document;
            Id = id;
        }
    }
}