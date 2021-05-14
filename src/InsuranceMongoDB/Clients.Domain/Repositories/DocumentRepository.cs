using System.Collections.Generic;
using System.Threading.Tasks;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using MongoDB.Driver;

namespace Clients.Domain.Repositories
{
    public class DocumentRepository:IDocumentRepository
    {
        private readonly IMongoCollection<Document> _collection;

        public DocumentRepository(IMongoClient client)
        {
            var database = client.GetDatabase("Clients");
            var collection = database.GetCollection<Document>(nameof(Document));
            _collection = collection;
        }

        public async Task Create(Document documents)
        {
            await _collection.InsertOneAsync(documents);
        }

        public async Task<IEnumerable<Document>> Get()
        {
            var  collection = await _collection.Find(_ => true).ToListAsync();
            return collection;
        }

        public async Task<Document> GetById(int id)
        {
            var filter = Builders<Document>.Filter.Eq(c => c.Id, id);
            var collection = await _collection.Find(filter).FirstOrDefaultAsync();
            return collection;
        }

        public async Task Update(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}