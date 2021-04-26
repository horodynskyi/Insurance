using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Repositories.UnitOfWork;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class BranchAgentService:IBranchAgentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BranchAgentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(BranchAgent branchAgent)
        {
            await _unitOfWork.BranchAgentRepository.Create(branchAgent);
        }

        public async Task<IEnumerable<BranchAgent>> Get()
        {
            return await _unitOfWork.BranchAgentRepository.Get();
        }

        public async Task<BranchAgent> GetById(int id)
        {
            return await _unitOfWork.BranchAgentRepository.GetById(id);
        }

        public async Task Update(BranchAgent branchAgent, int id)
        {
            await _unitOfWork.BranchAgentRepository.Update(branchAgent, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.BranchAgentRepository.Delete(id);
        }
    }
}