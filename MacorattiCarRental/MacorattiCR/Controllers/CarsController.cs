using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MacorattiCR.Models;

namespace MacorattiCR.Controllers
{
    [Route("Cars")]
       public class CarsController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index() => View();
    }
}