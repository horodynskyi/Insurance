using Clients.Application.Documents;
using Clients.Application.Interfaces;
using Clients.Application.Services;
using Clients.Domain.Interfaces;
using Clients.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Clients.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services,IConfiguration configuration)
        {
            
           
            services.AddSingleton<IMongoClient, MongoClient>(sp => new MongoClient(configuration.GetConnectionString("MongoDB")));
           
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IClientRepository, ClientRepository>();

            services.AddTransient<IDocumentService, DocumentService>();
            services.AddTransient<IDocumentRepository, DocumentRepository>();
        }
    }
}