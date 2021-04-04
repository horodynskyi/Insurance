using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Repositories.Interfaces;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class RiskService:IRiskService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RiskService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Risk risk)
        {
            await _unitOfWork.RiskRepository.Create(risk);
        }

        public async Task<IEnumerable<Risk>> Get()
        {
            return await _unitOfWork.RiskRepository.Get();
        }

        public async Task<Risk> GetById(int id)
        {
            return await _unitOfWork.RiskRepository.GetById(id);
        }

        public async Task Update(Risk risk, int id)
        {
            await _unitOfWork.RiskRepository.Update(risk,id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.RiskRepository.Delete(id);
        }
    }
}