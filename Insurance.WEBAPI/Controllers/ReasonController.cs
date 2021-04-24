using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Reason")]
    //[Authorize]
    public class ReasonController : Controller
    {
        private readonly IReasonService _reasonService;

        public ReasonController(IReasonService reasonService)
        {
            _reasonService = reasonService;
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<Reason>> Get()
        {
            return await _reasonService.Get();
        }

        [HttpPost]
        public async Task Add(Reason reason)
        {
            await _reasonService.Create(reason);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _reasonService.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(Reason reason, int id)
        {
            await _reasonService.Update(reason, id);
            return Ok(reason);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reasonService.Delete(id);
            return  Ok();
        }
    }
}