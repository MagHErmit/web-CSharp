using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _3._8_First_app.Models;

namespace _3._8_First_app.Controllers
{
    public class HomeController : Controller
    {
        TabletContext db;
        public HomeController(TabletContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }
    }
}
