using System.Collections.Generic;
using System.Threading.Tasks;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;

namespace Clients.Application.Documents
{
    public class DocumentService:IDocumentService
    {
        private readonly IDocumentRepository _repository;

        public DocumentService(IDocumentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Document>> GetDocument()
        {
            return await _repository.Get();
        }

        public async Task<Document> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task CreateDocument(Document document)
        {
            await _repository.Create(document);
        }
    }
}