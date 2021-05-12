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
    [Route("api/v1/Agent")]
    //[Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService _agentService;
        private readonly IMapper _mapper;

        public AgentController(IAgentService agentService, IMapper mapper)
        {
            _agentService = agentService;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GenericParams parameters)
        {
            var result = await _agentService.Get(parameters);
            var agents = _mapper.Map<IEnumerable<AgentDTO>>(result);
            return Ok(agents);
        }

        [HttpPost]
        public async Task Add(AgentDTO agentDto)
        {
            var agent = _mapper.Map<Agent>(agentDto);
            await _agentService.Create(agent);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _agentService.GetById(id);
            var agent = _mapper.Map<AgentDTO>(result);
            return Ok(agent);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(AgentDTO agentDto, int id)
        {
            var agent = _mapper.Map<Agent>(agentDto);
            await _agentService.Update(agent, id);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _agentService.Delete(id);
            return  Ok();
        }
    }
}