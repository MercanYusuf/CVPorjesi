using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YusufCv.Models.dataContext;

namespace YusufCv.Controllers
{
  
    public class HomeController : Controller
    {
        private dataContext db = new dataContext();
        [Route("Anasayfa")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HakkimdaPartial()
        {
            return View(db.Hakkimda.SingleOrDefault());
        }

        public ActionResult DeneyimPartial()
        {
            return View(db.Deneyimler.ToList().OrderByDescending(i => i.DeneyimId));
        }

        public ActionResult ProjePartial()
        {
            return View(db.Proje.ToList().OrderByDescending(i => i.ProjeId));
        }

        public ActionResult KimlikPartial()
        {
            return View(db.Kimlik.ToList().SingleOrDefault());
        }

        public ActionResult SosyalMedyaPartial()
        {
            return View(db.SosyalMedya.ToList().SingleOrDefault());
        }

        public ActionResult EgitimPartial()
        {
            return View(db.Egitim.ToList().OrderByDescending(i => i.EgitimId));
        }

        public ActionResult HobiPartial()
        {
            return View(db.Hobiler.ToList().OrderByDescending(i=>i.HobilerId));
        }
    }
}