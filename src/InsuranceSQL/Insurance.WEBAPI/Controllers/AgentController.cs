using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Helpers.Params;
using Insurance.Infrastracture.Infrastracture;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/agent")]
    //[Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService _agentService;
        private readonly IMapper _mapper;
        private InsuranceDbContext _context;

        public AgentController(IAgentService agentService, IMapper mapper, InsuranceDbContext context)
        {
            _agentService = agentService;
            _mapper = mapper;
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] AgentParams parameters)
        {
            var result = await _agentService.Get(parameters);
            var agents = _mapper.Map<IEnumerable<AgentDTO>>(result);
            return Ok(agents);
        }
        [HttpGet("/api/v1/Agent/Info")]
        public async Task<IActionResult> GetAllInfo([FromQuery] AgentParams parameters)
        {
            var result = await _agentService.Get(parameters);
            var agents = _mapper.Map<IEnumerable<AgentInfoDto>>(result);
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
            agent.Id = id;
            await _agentService.Update(agent, id);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _agentService.Delete(id);
            return  Ok();
        }

        [HttpGet("/test/")]
        public IActionResult Test([FromQuery]int Id , [FromQuery]int typeInsuranceId)
        {
            var result = _context.Agents
                .Where(ag => ag.Id == Id)
                .Join(
                    _context.Contracts,
                    c => c.Id,
                    ag => ag.Agent.Id,
                    (c, ag) =>
                        new
                        {
                            Name = c.FirstName,
                            TypeInsuranceId = ag.TypeInsurance.Id
                        }
                )
                .Where(ti => ti.TypeInsuranceId == typeInsuranceId)
                .AsQueryable();
              //  .Count(ti =>);
                
            return Ok(result);
        }
    }
}