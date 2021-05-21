using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Helpers.Params;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Branch")]
    //[Authorize]
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;
        private readonly IMapper _mapper;

        public BranchController(IBranchService branchService, IMapper mapper)
        {
            _branchService = branchService;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GenericParams parameters)
        {
            var result = await _branchService.Get(parameters);
            var branches = _mapper.Map<IEnumerable<BranchDTO>>(result);
            return Ok(branches);
        }

        [HttpPost]
        public async Task Add(BranchDTO branchDto)
        {
            var branch = _mapper.Map<Branch>(branchDto);
            await _branchService.Create(branch);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _branchService.GetById(id);
            var branch = _mapper.Map<BranchDTO>(result);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(BranchDTO branchDto, int id)
        {
            var branch = _mapper.Map<Branch>(branchDto);
            await _branchService.Update(branch, id);
            return Ok(branch);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _branchService.Delete(id);
            return  Ok();
        }

    }
}