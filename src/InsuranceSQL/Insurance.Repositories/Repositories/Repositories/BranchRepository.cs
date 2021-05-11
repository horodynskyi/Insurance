using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class BranchRepository:GenericRepository<Branch,int>, IBranchRepository
    {
        public BranchRepository(InsuranceDbContext context) : base(context)
        {
        }
    }
}