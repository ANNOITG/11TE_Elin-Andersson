using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt_kattsida.Models;

namespace projekt_kattsida.Controllers
{
    public class StoreController : Controller
    {

        CatStoreEntities storeDB = new CatStoreEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var breeds = storeDB.Breeds.ToList();
            return View(breeds);
        }
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string breeds)
        {
            var breedsModel = storeDB.Breeds.Include("Cats").Single(b => b.Name == breeds);
            return View(breedsModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var cat = storeDB.Cats.Find(id);

            return View(cat);
        }

    }
}
