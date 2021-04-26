using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Repositories.UnitOfWork;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class ReasonService:IReasonService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReasonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Reason reason)
        {
            await _unitOfWork.ReasonRepository.Create(reason);
        }

        public async Task<IEnumerable<Reason>> Get()
        {
            return await _unitOfWork.ReasonRepository.Get();
        }

        public async Task<Reason> GetById(int id)
        {
            return await _unitOfWork.ReasonRepository.GetById(id);
        }

        public async Task Update(Reason reason, int id)
        {
            await _unitOfWork.ReasonRepository.Update(reason, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.ReasonRepository.Delete(id);
        }
    }
}