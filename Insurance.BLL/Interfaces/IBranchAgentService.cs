using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.BLL.Interfaces
{
    public interface IBranchAgentService
    {
        Task Create(BranchAgent branchAgent);
        Task<IEnumerable<BranchAgent>> Get();
        Task<BranchAgent> GetById(int id);
        Task Update(BranchAgent branchAgent, int id);
        Task Delete(int id);
    }
}