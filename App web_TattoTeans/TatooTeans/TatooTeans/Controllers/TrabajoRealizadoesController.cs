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
    public class TrabajoRealizadoesController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();

        // GET: TrabajoRealizadoes
        public ActionResult Index()
        {
            var trabajoRealizadoes = db.TrabajoRealizadoes.Include(t => t.Usuario);
            return View(trabajoRealizadoes.ToList());
        }

        // GET: TrabajoRealizadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrabajoRealizado trabajoRealizado = db.TrabajoRealizadoes.Find(id);
            if (trabajoRealizado == null)
            {
                return HttpNotFound();
            }
            return View(trabajoRealizado);
        }

        // GET: TrabajoRealizadoes/Create
        public ActionResult Create()
        {
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre");
            return View();
        }

        // POST: TrabajoRealizadoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FechaRealizada,Puntuacion,ID_Usuario")] TrabajoRealizado trabajoRealizado)
        {
            if (ModelState.IsValid)
            {
                db.TrabajoRealizadoes.Add(trabajoRealizado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", trabajoRealizado.ID_Usuario);
            return View(trabajoRealizado);
        }

        // GET: TrabajoRealizadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrabajoRealizado trabajoRealizado = db.TrabajoRealizadoes.Find(id);
            if (trabajoRealizado == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", trabajoRealizado.ID_Usuario);
            return View(trabajoRealizado);
        }

        // POST: TrabajoRealizadoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FechaRealizada,Puntuacion,ID_Usuario")] TrabajoRealizado trabajoRealizado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trabajoRealizado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", trabajoRealizado.ID_Usuario);
            return View(trabajoRealizado);
        }

        // GET: TrabajoRealizadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrabajoRealizado trabajoRealizado = db.TrabajoRealizadoes.Find(id);
            if (trabajoRealizado == null)
            {
                return HttpNotFound();
            }
            return View(trabajoRealizado);
        }

        // POST: TrabajoRealizadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrabajoRealizado trabajoRealizado = db.TrabajoRealizadoes.Find(id);
            db.TrabajoRealizadoes.Remove(trabajoRealizado);
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
