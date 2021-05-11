using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.Repositories.Interfaces.IRepositories
{
    public interface ITerminatedContractRepository
    {
        Task Create(TerminatedContract contract);
        Task<IEnumerable<TerminatedContract>> Get();
        Task<TerminatedContract> GetById(int contractId);
        Task Update(TerminatedContract contract, int contractId);
        Task Delete(int contractId);
    }
}