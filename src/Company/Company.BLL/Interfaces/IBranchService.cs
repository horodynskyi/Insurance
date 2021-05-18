using System.Collections.Generic;
using System.Threading.Tasks;
using Company.DAL.SQLEntities;

namespace Company.BLL.Interfaces
{
    public interface IBranchService
    {
        Task Create(SqlBranch branch);
        Task<IEnumerable<SqlBranch>> Get();
        Task<SqlBranch> GetById(int id);
        Task Update(SqlBranch branch, int id);
        Task Delete(int id);
    }
}