using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers;

    [Route("carro")]

public class CarroController : Controller
{
    public IActionResult Index() => View();

    [HttpGet("suv")]
    public IActionResult Suv() => View("_Suv");

    [HttpGet("esportivo")]
    public IActionResult Esportivo() => View("_Esportivo");

    [HttpGet("performace")]
    public IActionResult Performace() => View("_Performace");

    [HttpGet("utilitario")]
    public IActionResult Utilitario() => View("_Utilitario");
    
}