using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers;

    [Route("carro")]

public class CarroController : Controller
{
    [HttpGet("index")]
    
    public IActionResult Index() => View();
    
}