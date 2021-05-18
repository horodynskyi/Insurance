using System.Threading.Tasks;
using Company.DAL.SQLEntities;

namespace Company.Repositories.Repositories.Interfaces
{
    public interface IBranchRepository:IGenericRepository<SqlBranch,int>
    {
       
    }
}