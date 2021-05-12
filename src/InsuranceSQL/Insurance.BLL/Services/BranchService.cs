using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;
using Insurance.Repositories.UnitOfWork;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class BranchService:IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BranchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Branch branch)
        {
            await _unitOfWork.BranchRepository.Create(branch);
        }

        public async Task<IEnumerable<Branch>> Get(GenericParams parameters)
        {
            return await _unitOfWork.BranchRepository.Get(parameters);
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