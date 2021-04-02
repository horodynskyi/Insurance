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
    }
}