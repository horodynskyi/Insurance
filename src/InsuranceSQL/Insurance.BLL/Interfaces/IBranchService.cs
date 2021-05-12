using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;

namespace Insurance.BLL.Interfaces
{
    public interface IBranchService
    {
        Task Create(Branch branch);
        Task<IEnumerable<Branch>> Get(GenericParams parameters);
        Task<Branch> GetById(int id);
        Task Update(Branch branch, int id);
        Task Delete(int id);
    }
}