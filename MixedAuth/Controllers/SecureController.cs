using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MixedAuth.Controllers
{
    [Produces("application/json")]
    [Route("api/Secure")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SecureController : Controller
    {
        public IActionResult GetData()
        {
            return Ok(new { value1 = "test", value2 = "test2", value3 = "test3" });
        }
    }
}