using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app_four.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController: ControllerBase
    {
        
        public IActionResult Get(){
            
            return Ok("four");
        }
    }
}