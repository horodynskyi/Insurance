using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Helpers.Params;
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
        private readonly IMapper _mapper;

        public TariffController(ITariffService tariffService, IMapper mapper)
        {
            _tariffService = tariffService;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GenericParams parameters)
        {
            var result = await _tariffService.Get(parameters);
            var tariffs = _mapper.Map<IEnumerable<TariffDTO>>(result);
            return Ok(tariffs);
        }

        [HttpPost]
        public async Task Add(TariffDTO tariffDto)
        {
            var tariff = _mapper.Map<Tariff>(tariffDto);
            await _tariffService.Create(tariff);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _tariffService.GetById(id);
            var tariff = _mapper.Map<TariffDTO>(result);
            return Ok(tariff);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(TariffDTO tariffDto, int id)
        {
            var tariff = _mapper.Map<Tariff>(tariffDto);
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