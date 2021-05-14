using System.Collections.Generic;
using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Documents.Queries
{
    public class GetAllDocumetsQuery:IRequest<IEnumerable<Document>>
    {
        
    }
}