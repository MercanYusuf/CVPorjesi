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
    public class ProgramalamaDilisController : Controller
    {
        private dataContext db = new dataContext();

        // GET: ProgramalamaDilis
        public ActionResult Index()
        {
            return View(db.ProgramalamaDili.ToList());
        }

        // GET: ProgramalamaDilis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramalamaDili programalamaDili = db.ProgramalamaDili.Find(id);
            if (programalamaDili == null)
            {
                return HttpNotFound();
            }
            return View(programalamaDili);
        }

        // GET: ProgramalamaDilis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProgramalamaDilis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProgramlamaId,Programalama")] ProgramalamaDili programalamaDili)
        {
            if (ModelState.IsValid)
            {
                db.ProgramalamaDili.Add(programalamaDili);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(programalamaDili);
        }

        // GET: ProgramalamaDilis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramalamaDili programalamaDili = db.ProgramalamaDili.Find(id);
            if (programalamaDili == null)
            {
                return HttpNotFound();
            }
            return View(programalamaDili);
        }

        // POST: ProgramalamaDilis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProgramlamaId,Programalama")] ProgramalamaDili programalamaDili)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programalamaDili).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(programalamaDili);
        }

        // GET: ProgramalamaDilis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramalamaDili programalamaDili = db.ProgramalamaDili.Find(id);
            if (programalamaDili == null)
            {
                return HttpNotFound();
            }
            return View(programalamaDili);
        }

        // POST: ProgramalamaDilis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProgramalamaDili programalamaDili = db.ProgramalamaDili.Find(id);
            db.ProgramalamaDili.Remove(programalamaDili);
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
