using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Agent")]
    //[Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService _agentService;

        public AgentController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<Agent>> Get()
        {
            return await _agentService.Get();
        }

        [HttpPost]
        public async Task Add(Agent agent)
        {
            await _agentService.Create(agent);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _agentService.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(Agent agent, int id)
        {
            await _agentService.Update(agent, id);
            return Ok(agent);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _agentService.Delete(id);
            return  Ok();
        }
    }
}