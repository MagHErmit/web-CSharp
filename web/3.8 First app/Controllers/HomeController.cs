using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _3._8_First_app.Models;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult ExplicitLoad()
        {
            return View(db.Orders.ToList());
            //return View(db.Orders.Include(p => p.Tablet).ToList());
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.TabletId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }
    }
}
