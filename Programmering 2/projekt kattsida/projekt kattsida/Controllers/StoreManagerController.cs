using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt_kattsida.Models;

namespace projekt_kattsida.Controllers
{
    public class StoreManagerController : Controller
    {
        private CatStoreEntities db = new CatStoreEntities();

        //
        // GET: /StoreManager/

        public ActionResult Index()
        {
            return View(db.Cats.Include("Breeds").ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ActionResult Details(int id = 0)
        {
            Cat cat = db.Cats.Find(id);
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View(cat);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
            ViewBag.BreedsId = new SelectList(db.Breeds, "BreedsId", "Name");

            return View();
        }

        //
        // POST: /StoreManager/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cat cat)
        {
            if (ModelState.IsValid)
            {
                db.Cats.Add(cat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BreedsId = new SelectList(db.Breeds, "BreedsId", "Name", cat.BreedId);

            return View(cat);
        }

        //
        // GET: /StoreManager/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.BreedId = db.Breeds.ToList();
            Cat cat = db.Cats.Find(id);
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View(cat);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cat cat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BreedsId = new SelectList(db.Breeds, "BreedsId", "Name", cat.BreedId);
            return View(cat);
        }

        //
        // GET: /StoreManager/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cat cat = db.Cats.Find(id);
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View(cat);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cat cat = db.Cats.Find(id);
            db.Cats.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}