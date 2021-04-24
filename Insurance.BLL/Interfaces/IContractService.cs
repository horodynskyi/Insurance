using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;

namespace Insurance.BLL.Interfaces
{
    public interface IContractService
    {
        Task Create(ContractDTO contractDto);
        Task<IEnumerable<Contract>> Get();
        Task<Contract> GetById(int id);
        Task Update(Contract contract, int id);
        Task Delete(int id);
    }
}