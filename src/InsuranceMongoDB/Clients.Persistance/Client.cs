using System.Threading.Tasks;
using MongoDB.Driver;

namespace Clients.Persistance
{
    public class Client
    {
        protected internal int Id { get; }
        private string FirstName;
        private string SecondName;
        private int DocumentsId;
       
        public Client(Client client)
        {
            Id = client.Id;
            FirstName = client.FirstName;
            SecondName = client.SecondName;
            DocumentsId = client.DocumentsId;
           
        }
    }
}