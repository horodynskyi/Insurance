using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.DTO.Mapper;
using Insurance.Helpers.Params;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.BLL.Services
{
    public class ContractService:IContractService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<Contract> _validator;
        public ContractService(IUnitOfWork unitOfWork, IValidator<Contract> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task Create(Contract contract)
        {
            
            await _unitOfWork.ContractRepository.Create(contract);
        }

        public async Task<IEnumerable<Contract>> Get(ContractParams parameters)
        {
            return await _unitOfWork.ContractRepository.Get(parameters);
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

        public async Task<ValidationResult> ContractValidation(Contract contract)
        {
            return await _validator.ValidateAsync(contract);
        }
    }
}