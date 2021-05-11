using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;

namespace Insurance.Repositories.Interfaces.IRepositories
{
    public interface IContractRepository:IGenericRepository<Contract,int>
    {
        Task<IEnumerable<Contract>> Get(ContractParams parameters);
    }
}