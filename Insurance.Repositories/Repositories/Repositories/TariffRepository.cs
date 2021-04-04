using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class TariffRepository:GenericRepository<Tariff,int>, ITariffRepository
    {
        public TariffRepository(InsuranceDbContext context) : base(context)
        {
        }
    }
}