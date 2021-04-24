using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Tariff")]
    //[Authorize]
    public class TariffController : Controller
    {
        private readonly ITariffService _tariffService;

        public TariffController(ITariffService tariffService)
        {
            _tariffService = tariffService;
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<Tariff>> Get()
        {
            return await _tariffService.Get();
        }

        [HttpPost]
        public async Task Add(Tariff tariff)
        {
            await _tariffService.Create(tariff);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _tariffService.GetById(id);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(Tariff tariff, int id)
        {
            await _tariffService.Update(tariff, id);
            return Ok(tariff);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tariffService.Delete(id);
            return  Ok();
        }
    }
}