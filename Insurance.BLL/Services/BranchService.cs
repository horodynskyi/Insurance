using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Repositories.UnitOfWork;

namespace Insurance.BLL.Services
{
    public class BranchService:IBranchService
    {
        private readonly UnitOfWork _unitOfWork;

        public BranchService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Branch branch)
        {
            await _unitOfWork.BranchRepository.Create(branch);
        }

        public async Task<IEnumerable<Branch>> Get()
        {
            return await _unitOfWork.BranchRepository.Get();
        }

        public async Task<Branch> GetById(int id)
        {
            return await _unitOfWork.BranchRepository.GetById(id);
        }

        public async Task Update(Branch branch, int id)
        {
            await _unitOfWork.BranchRepository.Update(branch, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.BranchRepository.Delete(id);
        }
    }
}