using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Documents.Queries;
using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Documents.Handlers
{
    public class GetAllDocumentHandler:IRequestHandler<GetAllDocumetsQuery,IEnumerable<Document>>
    {
        private readonly IDocumentService _service;

        public GetAllDocumentHandler(IDocumentService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<Document>> Handle(GetAllDocumetsQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetDocument();
        }
    }
}