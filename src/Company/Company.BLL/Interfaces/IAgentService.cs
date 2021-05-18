using System.Collections.Generic;
using System.Threading.Tasks;
using Company.DAL.SQLEntities;

namespace Company.BLL.Interfaces
{
    public interface IAgentService
    {
        Task Create(SqlAgent agent);
        Task<IEnumerable<SqlAgent>> Get();
        Task<IEnumerable<SqlAgent>> GetByBranchId(int id);
        Task<SqlAgent> GetById(int id);
        Task Update(SqlAgent agent, int id);
        Task Delete(int id);
    }
}