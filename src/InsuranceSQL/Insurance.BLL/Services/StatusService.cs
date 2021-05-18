using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;
using Insurance.Repositories.UnitOfWork;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class StatusService:IStatusService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatusService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Status status)
        {
            await _unitOfWork.StatusRepository.Create(status);
        }

        public async Task<IEnumerable<Status>> Get(GenericParams parameters)
        {
            return await _unitOfWork.StatusRepository.Get(parameters);
        }

        public async Task<Status> GetById(int id)
        {
            return await _unitOfWork.StatusRepository.GetById(id);
        }

        public async Task Update(Status status, int id)
        {
            await _unitOfWork.StatusRepository.Update(status, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.StatusRepository.Delete(id);
        }
    }
}