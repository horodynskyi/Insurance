using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;
using Insurance.Repositories.Interfaces;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class AgentService:IAgentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Agent agent)
        {
            await _unitOfWork.AgentRepository.Create(agent);
        }

        public async Task<IEnumerable<Agent>> Get(GenericParams parameters)
        {
            return await _unitOfWork.AgentRepository.Get(parameters);
        }

        public async Task<Agent> GetById(int id)
        {
            return await _unitOfWork.AgentRepository.GetById(id);
        }

        public async Task Update(Agent agent, int id)
        {
            await _unitOfWork.AgentRepository.Update(agent, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.AgentRepository.Delete(id);
        }
    }
}