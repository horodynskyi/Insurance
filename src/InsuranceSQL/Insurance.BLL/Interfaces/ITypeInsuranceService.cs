using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.BLL.Interfaces
{
    public interface ITypeInsuranceService
    {
        Task Create(TypeInsurance insurance);
        Task<IEnumerable<TypeInsurance>> Get();
        Task<TypeInsurance> GetById(int id);
        Task Update(TypeInsurance insurance, int id);
        Task Delete(int id);
    }
}