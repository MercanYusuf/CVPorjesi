using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using YusufCv.Models.dataContext;
using YusufCv.Models.Entity;

namespace YusufCv.Controllers
{
    public class AdminController : Controller
    {
        private dataContext db = new dataContext();
        // GET: Admin
      
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var login = db.Admin.Where(i => i.Eposta == admin.Eposta).SingleOrDefault();
            if (login.Eposta == admin.Eposta && login.Sifre == admin.Sifre)
            {
                Session["adminid"] = login.AdminId;
                Session["eposta"] = login.Eposta;
                return RedirectToAction("Index", "Admin");
            }

            ViewBag.uyari = "kullanicı adı yada şifre yanlış";
            return View(admin);
        }

        public ActionResult Logout()
        {
            Session["adminid"] = null;
            Session["espota"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        }
    }
}