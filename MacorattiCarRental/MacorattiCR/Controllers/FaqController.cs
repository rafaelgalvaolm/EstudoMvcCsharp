using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MacorattiCR.Models;

namespace MacorattiCR.Controllers
{
    [Route("Faq")]
    public class FaqController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index() => View();
    }
}