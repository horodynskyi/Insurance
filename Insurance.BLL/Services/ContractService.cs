using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.DTO.Mapper;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class ContractService:IContractService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _autoMapper;
        public ContractService(IUnitOfWork unitOfWork, IMapper autoMapper)
        {
            _unitOfWork = unitOfWork;
            _autoMapper = autoMapper;
        }

        public async Task Create(ContractDTO contractDto)
        {
            var contract = _autoMapper.Map<Contract>(contractDto);
            await _unitOfWork.ContractRepository.Create(contract);
        }

        public async Task<IEnumerable<Contract>> Get()
        {
            return await _unitOfWork.ContractRepository.Get();
        }

        public async Task<Contract> GetById(int id)
        {
            return await _unitOfWork.ContractRepository.GetById(id);
        }

        public async Task Update(Contract contract, int id)
        {
             await _unitOfWork.ContractRepository.Update(contract,id);
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.ContractRepository.Delete(id);
        }
    }
}