using System.Collections.Generic;
using System.Threading.Tasks;
using Clients.Domain.Models;

namespace Clients.Application.Documents
{
    public interface IDocumentService
    {
        Task<IEnumerable<Document>> GetDocument();
        Task<Document> GetById(int id);

        Task CreateDocument(Document document);
    }
}