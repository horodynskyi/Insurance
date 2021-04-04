using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.Repositories.Interfaces.IRepositories
{
    public interface IBranchAgentRepository
    {
        Task Create(BranchAgent branchAgent);
        Task<IEnumerable<BranchAgent>> Get();
        Task<BranchAgent> GetById(int agentId);
        Task Update(BranchAgent branchAgent, int agentId);
        Task Delete(int agentId);
    }
}