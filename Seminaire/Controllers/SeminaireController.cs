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


    public PartialViewResult _GetCarousel()
    {
      SeminaireContext db = new SeminaireContext();

      IEnumerable<Conference> liste = db.Conferences;

      return PartialView("_SeminaireCarousel",liste);
    }

    // GET: Seminaire/details/5
    public ActionResult Details(int id)
    {
      //1.vérifier que le séminaire existe.
      //2.aller chercher le seminaire

      SeminaireContext db = new SeminaireContext();
      Conference conf = db.Conferences.Find(id);

      if (conf == null)
      {
        return HttpNotFound();
      }
      else
      {
        return View(conf);
      }
    }


    //POST: Seminaire/Create/5
    [HttpPost()]
    public ActionResult Create(Participant part, int id)
    {
      SeminaireContext db = new SeminaireContext();

      if (!ModelState.IsValid)
      {
        return View("CreateFail");
      }
      Conference conf = db.Conferences.Find(id);
      if (conf == null)
      {
        return HttpNotFound();
      }
      else
      {
        part.Conferences.Add(conf);
        db.Participants.Add(part);
        db.SaveChanges();
        return View("CreateSucces");

      }



    }



    public ActionResult Inscriptions(int id)
    {
      SeminaireContext db = new SeminaireContext();
      Conference conf = db.Conferences.Find(id);
      if (conf == null)
      {
        return HttpNotFound();
      }
      else
      {
        return View(conf.Participants);
      }
    }


    public ActionResult Add(int i, int j)
    {
      return View(i + j);
    }
  }
}