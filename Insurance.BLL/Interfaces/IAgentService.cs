using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.BLL.Interfaces
{
    public interface IAgentService
    {
        Task Create(Agent agent);
        Task<IEnumerable<Agent>> Get();
        Task<Agent> GetById(int id);
        Task Update(Agent agent, int id);
        Task Delete(int id);
    }
}