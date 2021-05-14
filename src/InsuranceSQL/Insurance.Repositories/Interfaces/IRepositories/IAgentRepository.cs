using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;

namespace Insurance.Repositories.Interfaces.IRepositories
{
    public interface IAgentRepository:IGenericRepository<Agent,int>
    {
        Task GetCountContracts(AgentParams agentParams);
    }
}