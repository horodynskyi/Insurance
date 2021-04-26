using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation.Results;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;

namespace Insurance.BLL.Interfaces
{
    public interface IContractService
    {
        Task Create(Contract contract);
        Task<IEnumerable<Contract>> Get();
        Task<Contract> GetById(int id);
        Task Update(Contract contract, int id);
        Task Delete(int id);
        //Task<ValidationResult> ContractValidation(Contract contract);
    }
}