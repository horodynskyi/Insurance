using System.Threading;
using System.Threading.Tasks;
using Clients.Application.Documents.Queries;
using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Documents.Handlers
{
    public class GetByIdHandler:IRequestHandler<GetByIdDocumentQuery,Document>
    {
        private readonly IDocumentService _service;

        public GetByIdHandler(IDocumentService service)
        {
            _service = service;
        }

        public async Task<Document> Handle(GetByIdDocumentQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetById(request.Id);
        }
    }
}