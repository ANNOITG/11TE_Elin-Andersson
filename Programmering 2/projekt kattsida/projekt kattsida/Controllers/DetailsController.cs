using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt_kattsida.Models;

namespace projekt_kattsida.Controllers
{
    public class DetailsController : Controller
    {
        //
        // GET: /Details/

        public ActionResult Details(int id)
        {

            var cat = new Cat { Name = "Cat " + id };
            return View(cat);
        }

        public ActionResult Browse(string breeds)
        {
            var breedsModel = new Breeds { Name = breeds };
            return View(breedsModel);
        }

    }
}
