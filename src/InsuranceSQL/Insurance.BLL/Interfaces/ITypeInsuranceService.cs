using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;

namespace Insurance.BLL.Interfaces
{
    public interface ITypeInsuranceService
    {
        Task Create(TypeInsurance insurance);
        Task<IEnumerable<TypeInsurance>> Get(GenericParams parameters);
        Task<TypeInsurance> GetById(int id);
        Task Update(TypeInsurance insurance, int id);
        Task Delete(int id);
    }
}