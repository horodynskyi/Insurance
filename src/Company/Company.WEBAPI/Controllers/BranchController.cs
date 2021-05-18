using System.Threading.Tasks;
using Company.BLL.Interfaces;
using Company.DAL.SQLEntities;
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
        public async Task<IActionResult> Get()
        {
            var result = await _branchService.Get();
            return Ok(result);
        }

        [HttpPost]
        public async Task Add(SqlBranch branch)
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
        public async Task<IActionResult> Update(SqlBranch branch, int id)
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