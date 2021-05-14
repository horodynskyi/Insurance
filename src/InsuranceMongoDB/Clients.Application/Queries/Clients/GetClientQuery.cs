using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Queries.Clients
{
    public class GetClientQuery:IRequest<Client>
    {
        public int Id { get; set; }

        public GetClientQuery(int id)
        {
            Id = id;
        }
      
    }
}