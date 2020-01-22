using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _6._2_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace _6._2_EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly For6AppContext db;
        public HomeController(ILogger<HomeController> logger, For6AppContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult LazyIndex()
        {
            return View();
        } 
        public IActionResult EagerIndex()
        {
            
            return View(db.Users.Include(u => u.Phone).ToList());
        }
        public IActionResult ExplictIndex()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
