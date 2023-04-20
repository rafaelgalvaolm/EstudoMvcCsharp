using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarRentModKrita.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarRentModKrita.web.Controllers
{
    public class CarroController : Controller
    {
        private readonly BaseDbContext _dbContext;

        public CarroController(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Carros.ToList());
        }

    }
}