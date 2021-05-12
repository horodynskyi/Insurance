using System.Collections.Generic;
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
    [Route("api/v1/Risk")]
    //[Authorize]
    public class RiskController : Controller
    {
        private readonly IRiskService _riskService;
        private readonly IMapper _mapper;

        public RiskController(IRiskService riskService, IMapper mapper)
        {
            _riskService = riskService;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GenericParams parameters)
        {
            var result = await _riskService.Get(parameters);
            var risks = _mapper.Map<IEnumerable<RiskDTO>>(result);
            return Ok(risks);
        }

        [HttpPost]
        public async Task Add(RiskDTO riskDto)
        {
            var risk = _mapper.Map<Risk>(riskDto);
            await _riskService.Create(risk);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _riskService.GetById(id);
            var risk = _mapper.Map<RiskDTO>(result);
            return Ok(risk);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(RiskDTO riskDto, int id)
        {
            var risk = _mapper.Map<Risk>(riskDto);
            await _riskService.Update(risk, id);
            return Ok(risk);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _riskService.Delete(id);
            return  Ok();
        }
    }
}