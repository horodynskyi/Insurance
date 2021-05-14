using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Documents.Queries
{
    public class GetByIdDocumentQuery:IRequest<Document>
    {
        public int Id { get; set; }

        public GetByIdDocumentQuery(int id)
        {
            Id = id;
        }
    }
}