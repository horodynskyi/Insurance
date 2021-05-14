using System.Collections.Generic;
using System.Threading.Tasks;
using Clients.Domain.Models;

namespace Clients.Domain.Interfaces
{
    public interface IDocumentRepository
    {
        Task Create(Document documents);
        Task<IEnumerable<Document>> Get();
        Task<Document> GetById(int i);
        Task Update(int id);
        Task Delete(int id);
    }
}