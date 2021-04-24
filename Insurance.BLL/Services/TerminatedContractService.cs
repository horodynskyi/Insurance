using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Repositories.UnitOfWork;

namespace Insurance.BLL.Services
{
    public class TerminatedContractService:ITerminatedContractService
    {
        private readonly UnitOfWork _unitOfWork;

        public TerminatedContractService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(TerminatedContract terminated)
        {
            await _unitOfWork.TerminatedContractRepository.Create(terminated);
        }

        public async Task<IEnumerable<TerminatedContract>> Get()
        {
            return await _unitOfWork.TerminatedContractRepository.Get();
        }

        public async Task<TerminatedContract> GetById(int id)
        {
            return await _unitOfWork.TerminatedContractRepository.GetById(id);
        }

        public async Task Update(TerminatedContract terminated, int id)
        {
            await _unitOfWork.TerminatedContractRepository.Update(terminated, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.TerminatedContractRepository.Delete(id);
        }
    }
}