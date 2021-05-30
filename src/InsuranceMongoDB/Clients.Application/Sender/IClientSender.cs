using System.Threading.Tasks;
using Clients.Domain.Models;

namespace Clients.Application.Sender
{
    public interface IClientSender
    {
        Task Send(Client client);
    }
}

