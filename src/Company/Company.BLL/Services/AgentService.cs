using System.Collections.Generic;
using System.Threading.Tasks;
using Company.BLL.Interfaces;
using Company.DAL.SQLEntities;
using Company.Repositories.UnitOfWork;

namespace Company.BLL.Services
{
    public class AgentService:IAgentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(SqlAgent agent)
        {
            await _unitOfWork.AgentRepository.Create(agent);
        }

        public async Task<IEnumerable<SqlAgent>> Get()
        {
            return await _unitOfWork.AgentRepository.Get();
        }

        public async Task<IEnumerable<SqlAgent>> GetByBranchId(int id)
        {
            return await _unitOfWork.AgentRepository.GetByBranchId(id);
        }

        public async Task<SqlAgent> GetById(int id)
        {
            return await _unitOfWork.AgentRepository.GetById(id);
        }

        public async Task Update(SqlAgent agent, int id)
        {
            await _unitOfWork.AgentRepository.Update(agent, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.AgentRepository.Delete(id);
        }
    }
}