using core.Interfaces.Repositories;
using core.Models;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

    [Route("login")]

public class LoginController : Controller
{
    private readonly IUserRepository _userRepository;
    public LoginController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public IActionResult Index() => View();

    [HttpGet("sign-up")]
    public async Task<IActionResult> SignUp()
    {
        var usuarios = await _userRepository.GetUsersAsync();
        return View(usuarios);
    } 

    // [HttpPost("sign-up")]

    // public async Task<IActionResult> SignUp(User user)
    // {

    //     return RedirectToAction("Index", "Home");
    // }
    
}