using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Helpers.Params;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Contract")]
   // [Authorize]
    public class ContractController : Controller
    {
        private readonly IContractService _contractService;
        private readonly IMapper _mapper;

        public ContractController(IContractService contractService, IMapper mapper)
        {
            _contractService = contractService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ContractParams parameters)
        {
            var result = await _contractService.Get(parameters);
            var contracts = _mapper.Map<IEnumerable<ContractDTO>>(result);
            return Ok(contracts);
        }
        
        [HttpGet("/api/v1/Contract/Info")]
        public async Task<IActionResult> GetAllInfo([FromQuery] ContractParams parameters)
        {
            var result = await _contractService.Get(parameters);
            var contracts = _mapper.Map<IEnumerable<ContractInfoDto>>(result);
            return Ok(contracts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _contractService.GetById(id);
            var contract = _mapper.Map<ContractDTO>(result);
            return Ok(contract);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ContractDTO contractDto)
        {
            var contract = _mapper.Map<Contract>(contractDto);
            var validationResult = _contractService.ContractValidation(contract).Result;
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(x => new { Error = x.ErrorMessage, Code = x.ErrorCode }).ToList());
            }
            await _contractService.Create(contract);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _contractService.Delete(id);
            return Ok();
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(ContractDTO contractDto, int id)
        {
            var contract = _mapper.Map<Contract>(contractDto);
            contract.Id = id;
            await _contractService.Update(contract,id);
            return Ok();
        }
    }
}