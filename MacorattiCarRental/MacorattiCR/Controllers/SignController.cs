using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MacorattiCR.Models;

namespace MacorattiCR.Controllers
{
    [Route("Sign")]
    public class SignController : Controller
    {

        [HttpGet("Index")]
        public IActionResult Index() => View();
    }
}