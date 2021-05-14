using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Documents.Commands;
using MediatR;

namespace Clients.Application.Documents.Handlers
{
    public class CreateDocumentHandler:IRequestHandler<CreateDocumentsCommand>
    {
        private readonly IDocumentService _documentService;

        public CreateDocumentHandler(IDocumentService documentService)
        {
            _documentService = documentService;
        }


        public async Task<Unit> Handle(CreateDocumentsCommand request, CancellationToken cancellationToken)
        {
            await _documentService.CreateDocument(request.Document);
            return Unit.Value;
        }
    }
}