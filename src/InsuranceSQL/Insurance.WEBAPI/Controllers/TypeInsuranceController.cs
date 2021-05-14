using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.BLL.Interfaces;
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

        public TypeInsuranceController(ITypeInsuranceService typeInsuranceService)
        {
            _typeInsuranceService = typeInsuranceService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GenericParams parameters)
        {
            var result = await _typeInsuranceService.Get(parameters);
            return Ok(result);
        }
    }
}