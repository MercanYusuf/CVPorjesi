using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YusufCv.Models;
using YusufCv.Models.dataContext;

namespace YusufCv.Controllers
{
    public class DeneyimlersController : Controller
    {
        private dataContext db = new dataContext();

        // GET: Deneyimlers
        public ActionResult Index()
        {
            return View(db.Deneyimler.ToList());
        }

        // GET: Deneyimlers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deneyimler deneyimler = db.Deneyimler.Find(id);
            if (deneyimler == null)
            {
                return HttpNotFound();
            }
            return View(deneyimler);
        }

        // GET: Deneyimlers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deneyimlers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "DeneyimId,DeneyimAd,DeneyimAciklama,Sertifika,SertifikaAciklama,Tarih")] Deneyimler deneyimler)
        {
            if (ModelState.IsValid)
            {
                db.Deneyimler.Add(deneyimler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deneyimler);
        }

        // GET: Deneyimlers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deneyimler deneyimler = db.Deneyimler.Find(id);
            if (deneyimler == null)
            {
                return HttpNotFound();
            }
            return View(deneyimler);
        }

        // POST: Deneyimlers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "DeneyimId,DeneyimAd,DeneyimAciklama,Sertifika,SertifikaAciklama,Tarih")] Deneyimler deneyimler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deneyimler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deneyimler);
        }

        // GET: Deneyimlers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deneyimler deneyimler = db.Deneyimler.Find(id);
            if (deneyimler == null)
            {
                return HttpNotFound();
            }
            return View(deneyimler);
        }

        // POST: Deneyimlers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Deneyimler deneyimler = db.Deneyimler.Find(id);
            db.Deneyimler.Remove(deneyimler);
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
