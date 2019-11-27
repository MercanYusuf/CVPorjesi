using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using YusufCv.Models;
using YusufCv.Models.dataContext;

namespace YusufCv.Controllers
{
    public class KimliksController : Controller
    {
        private dataContext db = new dataContext();

        // GET: Kimliks
        public ActionResult Index()
        {
            return View(db.Kimlik.ToList());
        }

        // GET: Kimliks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kimlik kimlik = db.Kimlik.Find(id);
            if (kimlik == null)
            {
                return HttpNotFound();
            }
            return View(kimlik);
        }

        // GET: Kimliks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kimliks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "KimlikId,Ad,Soyad,Unvan,ResimURL")] Kimlik kimlik, HttpPostedFileBase ResimURL)
        {
            if (ModelState.IsValid)
            {
                if (ResimURL != null)
                {

                    WebImage img = new WebImage(ResimURL.InputStream);
                    FileInfo imginfo = new FileInfo(ResimURL.FileName);

                    string kimliksimgname = Guid.NewGuid().ToString() + imginfo.Extension; // isimlendirme.
                    img.Resize(300 , 250); //yükseklik genişlik.
                    img.Save("~/Upload/Kimlik/" + kimliksimgname); // kayıt yeri.

                    kimlik.ResimURL = "/Upload/Kimlik/" + kimliksimgname;

                }
                db.Kimlik.Add(kimlik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kimlik);
        }

        // GET: Kimliks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kimlik kimlik = db.Kimlik.Find(id);
            if (kimlik == null)
            {
                return HttpNotFound();
            }
            return View(kimlik);
        }

        // POST: Kimliks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "KimlikId,Ad,Soyad,Unvan,ResimURL")] Kimlik kimlik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kimlik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kimlik);
        }

        // GET: Kimliks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kimlik kimlik = db.Kimlik.Find(id);
            if (kimlik == null)
            {
                return HttpNotFound();
            }
            return View(kimlik);
        }

        // POST: Kimliks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kimlik kimlik = db.Kimlik.Find(id);
            db.Kimlik.Remove(kimlik);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
