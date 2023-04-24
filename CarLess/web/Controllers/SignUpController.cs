using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace web.Controllers
{
    [Route("signUp")]
    public class SignUpController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index() => View();
    }
}