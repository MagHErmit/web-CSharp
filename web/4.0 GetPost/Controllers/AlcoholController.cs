using _4._0_GetPost.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4._0_GetPost.Controllers
{
    public class AlcoholController : Controller
    {
        EssenceContext db;
        public AlcoholController(EssenceContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Alcohols.ToList());
        }
        [HttpGet]
        public IActionResult Properties(int? id)
        {
            //ViewBag.alc = db.Alcohols.Find(id);
            return View();
        }
    }
}
