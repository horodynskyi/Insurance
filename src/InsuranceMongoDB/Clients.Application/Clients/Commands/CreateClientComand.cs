using Clients.Domain.Models;
using MediatR;

namespace Clients.Application.Clients.Commands
{
    public class CreateClientComand:IRequest
    {
        public Client Client { get; set; }
        public CreateClientComand(Client client)
        {
            Client = client;
        }
    }
}