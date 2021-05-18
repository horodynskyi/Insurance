using System.Threading.Tasks;
using Company.BLL.Interfaces;
using Company.DAL.SQLEntities;
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
        public async Task<IActionResult> Get()
        {
            var result = await _agentService.Get();
            return Ok(result);
        }

        [HttpPost]
        public async Task Add(SqlAgent agent)
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
        public async Task<IActionResult> Update(SqlAgent agent, int id)
        {
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