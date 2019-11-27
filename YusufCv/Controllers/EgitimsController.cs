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
    public class EgitimsController : Controller
    {
        private dataContext db = new dataContext();

        // GET: Egitims
        public ActionResult Index()
        {
            return View(db.Egitim.ToList());
        }

        // GET: Egitims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egitim egitim = db.Egitim.Find(id);
            if (egitim == null)
            {
                return HttpNotFound();
            }
            return View(egitim);
        }

        // GET: Egitims/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Egitims/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "EgitimId,Baslik,Aciklama")] Egitim egitim)
        {
            if (ModelState.IsValid)
            {
                db.Egitim.Add(egitim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(egitim);
        }

        // GET: Egitims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egitim egitim = db.Egitim.Find(id);
            if (egitim == null)
            {
                return HttpNotFound();
            }
            return View(egitim);
        }

        // POST: Egitims/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "EgitimId,Baslik,Aciklama")] Egitim egitim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(egitim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(egitim);
        }

        // GET: Egitims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Egitim egitim = db.Egitim.Find(id);
            if (egitim == null)
            {
                return HttpNotFound();
            }
            return View(egitim);
        }

        // POST: Egitims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Egitim egitim = db.Egitim.Find(id);
            db.Egitim.Remove(egitim);
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
