using System.Collections.Generic;
using System.Threading.Tasks;
using Company.BLL.Interfaces;
using Company.DAL.SQLEntities;
using Company.Repositories.UnitOfWork;

namespace Company.BLL.Services
{
    public class BranchService:IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BranchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(SqlBranch branch)
        {
            await _unitOfWork.BranchRepository.Create(branch);
        }

        public async Task<IEnumerable<SqlBranch>> Get()
        {
            return await _unitOfWork.BranchRepository.Get();
        }

        public async Task<SqlBranch> GetById(int id)
        {
            return await _unitOfWork.BranchRepository.GetById(id);
        }

        public async Task Update(SqlBranch branch, int id)
        {
            await _unitOfWork.BranchRepository.Update(branch, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.BranchRepository.Delete(id);
        }
    }
}