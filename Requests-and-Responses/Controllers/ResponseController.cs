using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Requests_and_Responses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResponseController : ControllerBase
    {
        [HttpGet("headers")]
        public IActionResult Get()
        {
            return Ok(base.Request.Headers.ToList());
        }
        
        [HttpGet("GetQueries")]
        public IActionResult GetQueries(int val1,int val2,int val3)
        {
            return Ok(base.Request.Query.ToList());
        }
    }
}