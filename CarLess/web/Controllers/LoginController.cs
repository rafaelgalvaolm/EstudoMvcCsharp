using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers;

    [Route("login")]

public class LoginController : Controller
{
    public IActionResult Index() => View();

    [HttpGet("signUp")]
    public IActionResult SignUp() => View();

    
    
}