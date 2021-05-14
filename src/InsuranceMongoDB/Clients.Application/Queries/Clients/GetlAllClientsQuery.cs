using System.Collections.Generic;
using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Queries.Clients
{
    public class GetlAllClientsQuery:IRequest<IEnumerable<Client>>
    {
        
    }
}