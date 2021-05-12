using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Terminated")]
    //[Authorize]
    public class TerminatedController : Controller
    {
        private readonly ITerminatedContractService _terminated;
        private readonly IMapper _mapper;

        public TerminatedController(ITerminatedContractService terminated, IMapper mapper)
        {
            _terminated = terminated;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _terminated.Get();
            var termContracts = _mapper.Map<IEnumerable<TerminatedContractDTO>>(result);
            return Ok(termContracts);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _terminated.GetById(id);
            var termContract = _mapper.Map<TerminatedContractDTO>(result);
            return Ok(termContract);
        }

        [HttpPost]
        public async Task Add(TerminatedContractDTO terminatedContractDto)
        {
            var terminated = _mapper.Map<TerminatedContract>(terminatedContractDto);
            await _terminated.Create(terminated);
        }
        
        
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(TerminatedContractDTO terminatedContractDto, int id)
        {
            var terminatedContract = _mapper.Map<TerminatedContract>(terminatedContractDto);
            await _terminated.Update(terminatedContract, id);
            return Ok(terminatedContract);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _terminated.Delete(id);
            return  Ok();
        }
    }
}