using core.Models;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

    [Route("login")]

public class LoginController : Controller
{
    public IActionResult Index() => View();

    [HttpGet("sign-up")]
    public IActionResult SignUp() => View();

    [HttpPost("sign-up")]

    public IActionResult SignUp(User user)
    {
                
        return RedirectToAction("Index", "Home");
    }
    
}