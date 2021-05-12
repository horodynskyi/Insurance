using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class TypeInsuranceService:ITypeInsuranceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TypeInsuranceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(TypeInsurance insurance)
        {
            await _unitOfWork.TypeInsuranceRepository.Create(insurance);
        }

        public async Task<IEnumerable<TypeInsurance>> Get(GenericParams parameters)
        {
            return await _unitOfWork.TypeInsuranceRepository.Get(parameters);
        }

        public async Task<TypeInsurance> GetById(int id)
        {
            return await _unitOfWork.TypeInsuranceRepository.GetById(id);
        }

        public async Task Update(TypeInsurance insurance, int id)
        {
             await _unitOfWork.TypeInsuranceRepository.Update(insurance, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.TypeInsuranceRepository.Delete(id);
        }
    }
}