using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.BLL.Interfaces
{
    public interface ITerminatedContractService
    {
        Task Create(TerminatedContract terminated);
        Task<IEnumerable<TerminatedContract>> Get();
        Task<TerminatedContract> GetById(int id);
        Task Update(TerminatedContract terminated, int id);
        Task Delete(int id);
    }
}