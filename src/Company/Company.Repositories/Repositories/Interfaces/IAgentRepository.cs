using System.Collections.Generic;
using System.Threading.Tasks;
using Company.DAL.SQLEntities;

namespace Company.Repositories.Repositories.Interfaces
{
    public interface IAgentRepository:IGenericRepository<SqlAgent,int>
    {
        Task<IEnumerable<SqlAgent>> GetByBranchId(int id);
    }
}