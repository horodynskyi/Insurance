using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Insurance.BLL.Interfaces;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Helpers.Params;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeInsuranceController : ControllerBase
    {
        private readonly ITypeInsuranceService _typeInsuranceService;
        private IMapper _mapper;

        public TypeInsuranceController(ITypeInsuranceService typeInsuranceService, IMapper mapper)
        {
            _typeInsuranceService = typeInsuranceService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GenericParams parameters)
        {
            
            var result = await _typeInsuranceService.Get(parameters);
            var typeIns = _mapper.Map<IEnumerable<TypeInsurance>>(result);
            return Ok(typeIns);
        }
    }
}