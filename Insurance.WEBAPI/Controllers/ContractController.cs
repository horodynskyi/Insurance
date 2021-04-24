using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Contract")]
   // [Authorize]
    public class ContractController : Controller
    {
        private readonly IContractService _contractService;

        public ContractController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _contractService.Get();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _contractService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task Add(ContractDTO contractDto)
        {
            await _contractService.Create(contractDto);
        }
    }
}