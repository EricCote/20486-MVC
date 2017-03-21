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

        // GET: Seminaire/details/5
        public ActionResult Details(int id)
        {
            //1.vérifier que le séminaire existe.
            //2.aller chercher le seminaire

            SeminaireContext db = new SeminaireContext();
            Conference conf =   db.Conferences.Find(id);

            if (conf == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(conf);
            }
        }




        public ActionResult Add(int i, int j)
        {
            return View(i + j);
        }
    }
}