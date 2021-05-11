using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class ReasonRepository:GenericRepository<Reason,int>, IReasonRepository
    {
        public ReasonRepository(InsuranceDbContext context) : base(context)
        {
        }
    }
}