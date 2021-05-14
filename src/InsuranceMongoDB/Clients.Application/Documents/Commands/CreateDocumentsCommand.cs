using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Documents.Commands
{
    public class CreateDocumentsCommand:IRequest
    {
        public Document Document { get; set; }
        public CreateDocumentsCommand(Document document)
        {
            Document = document;
        }
    }
}