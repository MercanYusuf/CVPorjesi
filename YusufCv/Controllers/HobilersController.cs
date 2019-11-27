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
    public class HobilersController : Controller
    {
        private dataContext db = new dataContext();

        // GET: Hobilers
        public ActionResult Index()
        {
            return View(db.Hobiler.ToList());
        }

        // GET: Hobilers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobiler hobiler = db.Hobiler.Find(id);
            if (hobiler == null)
            {
                return HttpNotFound();
            }
            return View(hobiler);
        }

        // GET: Hobilers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hobilers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HobilerId,Aciklama")] Hobiler hobiler)
        {
            if (ModelState.IsValid)
            {
                db.Hobiler.Add(hobiler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hobiler);
        }

        // GET: Hobilers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobiler hobiler = db.Hobiler.Find(id);
            if (hobiler == null)
            {
                return HttpNotFound();
            }
            return View(hobiler);
        }

        // POST: Hobilers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HobilerId,Aciklama")] Hobiler hobiler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hobiler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hobiler);
        }

        // GET: Hobilers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobiler hobiler = db.Hobiler.Find(id);
            if (hobiler == null)
            {
                return HttpNotFound();
            }
            return View(hobiler);
        }

        // POST: Hobilers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hobiler hobiler = db.Hobiler.Find(id);
            db.Hobiler.Remove(hobiler);
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
