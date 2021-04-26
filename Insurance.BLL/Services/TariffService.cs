using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.Repositories.UnitOfWork;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class TariffService:ITariffService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TariffService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Tariff tariff)
        {
            await _unitOfWork.TariffRepository.Create(tariff);
        }

        public async Task<IEnumerable<Tariff>> Get()
        {
            return await _unitOfWork.TariffRepository.Get();
        }

        public async Task<Tariff> GetById(int id)
        {
            return await _unitOfWork.TariffRepository.GetById(id);
        }

        public async Task Update(Tariff tariff, int id)
        {
            await _unitOfWork.TariffRepository.Update(tariff, id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.TariffRepository.Delete(id);
        }
    }
}