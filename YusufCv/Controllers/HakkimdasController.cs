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
    public class HakkimdasController : Controller
    {
        private dataContext db = new dataContext();

        // GET: Hakkimdas
        public ActionResult Index()
        {
            return View(db.Hakkimda.ToList());
        }

        // GET: Hakkimdas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hakkimda hakkimda = db.Hakkimda.Find(id);
            if (hakkimda == null)
            {
                return HttpNotFound();
            }
            return View(hakkimda);
        }

        // GET: Hakkimdas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hakkimdas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HakkimdaId,Aciklama")] Hakkimda hakkimda)
        {
            if (ModelState.IsValid)
            {
                db.Hakkimda.Add(hakkimda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hakkimda);
        }

        // GET: Hakkimdas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hakkimda hakkimda = db.Hakkimda.Find(id);
            if (hakkimda == null)
            {
                return HttpNotFound();
            }
            return View(hakkimda);
        }

        // POST: Hakkimdas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HakkimdaId,Aciklama")] Hakkimda hakkimda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hakkimda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hakkimda);
        }

        // GET: Hakkimdas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hakkimda hakkimda = db.Hakkimda.Find(id);
            if (hakkimda == null)
            {
                return HttpNotFound();
            }
            return View(hakkimda);
        }

        // POST: Hakkimdas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hakkimda hakkimda = db.Hakkimda.Find(id);
            db.Hakkimda.Remove(hakkimda);
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
