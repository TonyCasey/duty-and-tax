using dt.Calculator.Api.Infratstructure.Validation;
using dt.Calculator.Api.Model;
using dt.Calculator.Api.Services;
using dt.Calculator.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Threading.Tasks;

namespace dt.Calculator.Api.Controllers
{
    /// <summary>
    /// Main calulator controler
    /// </summary>
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/Calculate")]
    public class CalculateController : Controller
    {
        private readonly ICalculatorService _calculatorService;
        private readonly DtDbContext _dbContext;

        /// <summary>
        /// Main controller for calculate requests
        /// </summary>
        /// <param name="calculatorService"></param>
        /// <param name="dbContext"></param>
        public CalculateController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        
        
        
        // POST: api/Calculate
        [HttpPost]
        [SwaggerOperation("Calculate")]
        [SwaggerResponse(444, typeof(NoResponseError), "Error, no response from server")]
        [SwaggerResponse(StatusCodes.Status200OK, typeof(CalculateResponseDto), "Calculation successful")]
        [SwaggerResponse(StatusCodes.Status202Accepted, null, "Accepted")]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, null, "InternalServerError")]
        public async Task<IActionResult> Post([FromBody]CalculateRequestDto requestDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (requestDto.ShippingToCountryIso == "CA" && String.IsNullOrEmpty(requestDto.CanadianProvinceCode))
                return BadRequest("You must specify the property CanadianProvinceCode with a valu for Canadian calculations");

            return Ok( _calculatorService.Calculate(requestDto));
        }
        
       
    }
}
