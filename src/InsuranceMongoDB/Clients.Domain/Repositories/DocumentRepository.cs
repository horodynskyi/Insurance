using System.Collections.Generic;
using System.Threading.Tasks;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using MongoDB.Driver;

namespace Clients.Domain.Repositories
{
    public class DocumentRepository:Mongo<Document>,IDocumentRepository
    {
        public DocumentRepository(IMongoClient client):base(client)
        {
        }
        public async Task Create(Document documents)
        {
            var id =  await GetId();
            documents.Id = ++id;
            await Collection.InsertOneAsync(documents);
            await SetId(id);
        }

        public async Task<IEnumerable<Document>> Get()
        {
            var  collection = await Collection.Find(_ => true).ToListAsync();
            return collection;
        }

        public async Task<Document> GetById(int id)
        {
            var filter = Builders<Document>.Filter.Eq(c => c.Id, id);
            var collection = await Collection.Find(filter).FirstOrDefaultAsync();
            return collection;
        }

        public async Task Update(Document document,int id)
        {
            var filter = Builders<Document>.Filter.Eq(c => c.Id, id);
            var update = Builders<Document>.Update
                .Set(c => c, document);
            var result = await Collection.UpdateOneAsync(filter, update);
           
        }

        public async Task Delete(int id)
        {
            var filter = Builders<Document>.Filter.Eq(c => c.Id, id);
             await Collection.DeleteOneAsync(filter);
        }
    }
}