using ArabalarDunyasii.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArabalarDunyasii.Controllers
{
    public class ArabalarController : Controller
    {
        private readonly UygulamaDbContext db;

        public ArabalarController(UygulamaDbContext db)
        {
            this.db = db;
        }
        public IActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Yeni(Araba araba)
        {
            if (ModelState.IsValid)
            {
                db.Add(araba);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
