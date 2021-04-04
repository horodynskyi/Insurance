using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class AgentRepository:GenericRepository<Agent,int> , IAgentRepository
    {
        public AgentRepository(InsuranceDbContext context) : base(context)
        {
        }
    }
}