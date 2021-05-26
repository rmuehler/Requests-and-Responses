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
        
        
        
        
    }
}