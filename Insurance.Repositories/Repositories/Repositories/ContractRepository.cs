using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class ContractRepository:GenericRepository<Contract,int>,IContractRepository
    {
        public ContractRepository(InsuranceDbContext context) : base(context)
        {
        }
    }
}