using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Risk")]
    public class RiskController : Controller
    {
        private readonly IRiskService _riskService;

        public RiskController(IRiskService riskService)
        {
            _riskService = riskService;
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<Risk>> Get()
        {
            return await _riskService.Get();
        }

        [HttpPost]
        public async Task Add(Risk risk)
        {
            await _riskService.Create(risk);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _riskService.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Risk risk, int id)
        {
            await _riskService.Update(risk, id);
            return Ok(risk);
        }
    }
}