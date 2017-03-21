using Seminaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminaire.Controllers
{
    public class SeminaireController : Controller
    {
        // GET: Seminaire
        public ActionResult Index()
        {
            SeminaireContext db = new SeminaireContext();

            IEnumerable<Conference> liste = db.Conferences;
            return View(liste);
        }


        public ActionResult Add(int i, int j)
        {
            return View(i + j);
        }
    }
}