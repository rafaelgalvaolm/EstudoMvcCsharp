﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarRental.web.Models;

namespace CarRental.web.Controllers;

    [Route("Home")]
public class HomeController : Controller
{
    [HttpGet("Index")]
    public IActionResult Index() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
