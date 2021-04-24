using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Branch")]
    //[Authorize]
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<Branch>> Get()
        {
            return await _branchService.Get();
        }

        [HttpPost]
        public async Task Add(Branch branch)
        {
            await _branchService.Create(branch);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _branchService.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(Branch branch, int id)
        {
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