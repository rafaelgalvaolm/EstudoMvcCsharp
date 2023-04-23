using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers;

    [Route("sign")]

public class SignController : Controller
{
    [HttpGet("index")]

    public IActionResult Index() => View();
    
}