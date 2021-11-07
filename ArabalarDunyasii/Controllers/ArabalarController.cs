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
        [HttpPost, ValidateAntiForgeryToken]
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
        
        public IActionResult Sil(int id)
        {
            return View(db.Arabalar.Find(id));
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SilOnaylandi(int id)
        {
            Araba araba = db.Arabalar.Find(id);
            db.Remove(araba);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Duzenle(int id)
        {
            return View(db.Arabalar.Find(id));
        }
        
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Duzenle (Araba araba)
        {
            if (ModelState.IsValid)
            {
                db.Update(araba);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View();
            
        }
    }
}
