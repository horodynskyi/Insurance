using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class TypeInsuranceRepository:GenericRepository<TypeInsurance,int>,ITypeInsuranceRepository
    {
        public TypeInsuranceRepository(InsuranceDbContext context) : base(context)
        {
        }
    }
}