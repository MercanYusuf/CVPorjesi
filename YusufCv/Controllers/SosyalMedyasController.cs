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
    public class SosyalMedyasController : Controller
    {
        private dataContext db = new dataContext();

        // GET: SosyalMedyas
        public ActionResult Index()
        {
            return View(db.SosyalMedya.ToList());
        }

        // GET: SosyalMedyas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SosyalMedya sosyalMedya = db.SosyalMedya.Find(id);
            if (sosyalMedya == null)
            {
                return HttpNotFound();
            }
            return View(sosyalMedya);
        }

        // GET: SosyalMedyas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SosyalMedyas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SosyalId,Email,Telefon,Linked,GitHub,Twitter,Facebook,Instagram")] SosyalMedya sosyalMedya)
        {
            if (ModelState.IsValid)
            {
                db.SosyalMedya.Add(sosyalMedya);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sosyalMedya);
        }

        // GET: SosyalMedyas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SosyalMedya sosyalMedya = db.SosyalMedya.Find(id);
            if (sosyalMedya == null)
            {
                return HttpNotFound();
            }
            return View(sosyalMedya);
        }

        // POST: SosyalMedyas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SosyalId,Email,Telefon,Linked,GitHub,Twitter,Facebook,Instagram")] SosyalMedya sosyalMedya)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sosyalMedya).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sosyalMedya);
        }

        // GET: SosyalMedyas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SosyalMedya sosyalMedya = db.SosyalMedya.Find(id);
            if (sosyalMedya == null)
            {
                return HttpNotFound();
            }
            return View(sosyalMedya);
        }

        // POST: SosyalMedyas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SosyalMedya sosyalMedya = db.SosyalMedya.Find(id);
            db.SosyalMedya.Remove(sosyalMedya);
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
