using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.BLL.Interfaces
{
    public interface IContractService
    {
        Task Create(Contract contract);
        Task<IEnumerable<Contract>> Get();
        Task<Contract> GetById(int id);
        Task Update(Contract contract, int id);
        Task Delete(int id);
    }
}