using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers;

    [Route("faq")]

public class FaqController : Controller
{
    [HttpGet("index")]
    
    public IActionResult Index() => View();
    
}