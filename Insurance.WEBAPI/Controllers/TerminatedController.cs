using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
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

        public TerminatedController(ITerminatedContractService terminated)
        {
            _terminated = terminated;
        }

        [HttpGet]
        public async Task<IEnumerable<TerminatedContract>> Get()
        {
            return await _terminated.Get();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _terminated.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task Add(TerminatedContract terminatedContract)
        {
            await _terminated.Create(terminatedContract);
        }
        
        
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(TerminatedContract terminatedContract, int id)
        {
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