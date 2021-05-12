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
    [Route("api/v1/Reason")]
    //[Authorize]
    public class ReasonController : Controller
    {
        private readonly IReasonService _reasonService;
        private readonly IMapper _mapper;

        public ReasonController(IReasonService reasonService, IMapper mapper)
        {
            _reasonService = reasonService;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GenericParams parameters)
        {
            var result = await _reasonService.Get(parameters);
            var reasons = _mapper.Map<IEnumerable<ReasonDTO>>(result);
            return Ok(reasons);
        }

        [HttpPost]
        public async Task Add(ReasonDTO reasonDto)
        {
            var reason = _mapper.Map<Reason>(reasonDto);
            await _reasonService.Create(reason);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _reasonService.GetById(id);
            var reasons = _mapper.Map<ReasonDTO>(result);
            return Ok(reasons);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(ReasonDTO reasonDto, int id)
        {
            var reason = _mapper.Map<Reason>(reasonDto);
            await _reasonService.Update(reason, id);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reasonService.Delete(id);
            return  Ok();
        }
    }
}