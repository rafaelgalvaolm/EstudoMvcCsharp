using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarRentModKrita.web.Models;

namespace CarRentModKrita.web.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
