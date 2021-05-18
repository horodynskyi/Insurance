using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Helpers.Params;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusService _service;
        private IMapper _mapper;

        public StatusController(IStatusService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(StatusDTO statusDto)
        {
            var status = _mapper.Map<Status>(statusDto);
            await _service.Create(status);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GenericParams parameters)
        {
            var result = await _service.Get(parameters);
            var statuses = _mapper.Map<IEnumerable<StatusDTO>>(result);
            return Ok(statuses);
        }
    }
}