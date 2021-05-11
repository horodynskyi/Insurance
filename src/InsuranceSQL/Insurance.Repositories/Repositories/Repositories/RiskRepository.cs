using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class RiskRepository:GenericRepository<Risk,int>, IRiskRepository
    {
        public RiskRepository(InsuranceDbContext context) : base(context)
        {
        }
    }
}