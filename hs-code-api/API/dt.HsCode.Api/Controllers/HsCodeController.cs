using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dt.HsCode.Api.Infrastructure.Validation;
using dt.HsCode.Api.Model;
using dt.HsCode.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace dt.HsCode.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/HsCode")]
    public class HsCodeController : Controller
    {
        private readonly IHsCodeService _hsCodeService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hsCodeService"></param>
        public HsCodeController(IHsCodeService hsCodeService)
        {
            _hsCodeService = hsCodeService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: api/HsCode
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/HsCode/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/HsCode
        /// <summary>
        /// Insert a new Hs Code
        /// </summary>
        /// <param name="hsCodeRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody]HsCodeRequestDto hsCodeRequest)
        {
            // validate request
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            // add or update
            _hsCodeService.AddOrUpdate(hsCodeRequest);

            return Ok();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/HsCode/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
