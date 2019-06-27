using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TatooTeans.Models;

namespace TatooTeans.Controllers
{
    public class OpinionsController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();

        // GET: Opinions
        public ActionResult Index()
        {
            var opinions = db.Opinions.Include(o => o.TrabajoRealizado);
            return View(opinions.ToList());
        }

        // GET: Opinions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opinion opinion = db.Opinions.Find(id);
            if (opinion == null)
            {
                return HttpNotFound();
            }
            return View(opinion);
        }

        // GET: Opinions/Create
        public ActionResult Create()
        {
            ViewBag.ID_TrabajoRealizado = new SelectList(db.TrabajoRealizadoes, "ID", "ID");
            return View();
        }

        // POST: Opinions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descripcion,ID_TrabajoRealizado")] Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                db.Opinions.Add(opinion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_TrabajoRealizado = new SelectList(db.TrabajoRealizadoes, "ID", "ID", opinion.ID_TrabajoRealizado);
            return View(opinion);
        }

        // GET: Opinions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opinion opinion = db.Opinions.Find(id);
            if (opinion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_TrabajoRealizado = new SelectList(db.TrabajoRealizadoes, "ID", "ID", opinion.ID_TrabajoRealizado);
            return View(opinion);
        }

        // POST: Opinions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descripcion,ID_TrabajoRealizado")] Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(opinion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_TrabajoRealizado = new SelectList(db.TrabajoRealizadoes, "ID", "ID", opinion.ID_TrabajoRealizado);
            return View(opinion);
        }

        // GET: Opinions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opinion opinion = db.Opinions.Find(id);
            if (opinion == null)
            {
                return HttpNotFound();
            }
            return View(opinion);
        }

        // POST: Opinions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Opinion opinion = db.Opinions.Find(id);
            db.Opinions.Remove(opinion);
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
