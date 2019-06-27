using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventosUPC.Models;
using EventosUPC.AuthorizationAttribute;

namespace EventosUPC.Controllers
{
    [AutorizacionUsuario]
    public class Evento_EquipoController : Controller
    {
        private Eventos_TPEntitiesContext db = new Eventos_TPEntitiesContext();

        // GET: Evento_Equipo
        public ActionResult Index()
        {
            var evento_Equipo = db.Evento_Equipo.Include(e => e.Equipo).Include(e => e.Evento);
            return View(evento_Equipo.ToList());
        }

        // GET: Evento_Equipo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Equipo evento_Equipo = db.Evento_Equipo.Find(id);
            if (evento_Equipo == null)
            {
                return HttpNotFound();
            }
            return View(evento_Equipo);
        }

        // GET: Evento_Equipo/Create
        public ActionResult Create()
        {
            ViewBag.id_equipo = new SelectList(db.Equipoes, "id_equipo", "nombre");
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre");
            return View();
        }

        // POST: Evento_Equipo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_evento_equipo,id_evento,id_equipo")] Evento_Equipo evento_Equipo)
        {
            if (ModelState.IsValid)
            {
                db.Evento_Equipo.Add(evento_Equipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_equipo = new SelectList(db.Equipoes, "id_equipo", "nombre", evento_Equipo.id_equipo);
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Equipo.id_evento);
            return View(evento_Equipo);
        }

        // GET: Evento_Equipo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Equipo evento_Equipo = db.Evento_Equipo.Find(id);
            if (evento_Equipo == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_equipo = new SelectList(db.Equipoes, "id_equipo", "nombre", evento_Equipo.id_equipo);
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Equipo.id_evento);
            return View(evento_Equipo);
        }

        // POST: Evento_Equipo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_evento_equipo,id_evento,id_equipo")] Evento_Equipo evento_Equipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento_Equipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_equipo = new SelectList(db.Equipoes, "id_equipo", "nombre", evento_Equipo.id_equipo);
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Equipo.id_evento);
            return View(evento_Equipo);
        }

        // GET: Evento_Equipo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Equipo evento_Equipo = db.Evento_Equipo.Find(id);
            if (evento_Equipo == null)
            {
                return HttpNotFound();
            }
            return View(evento_Equipo);
        }

        // POST: Evento_Equipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento_Equipo evento_Equipo = db.Evento_Equipo.Find(id);
            db.Evento_Equipo.Remove(evento_Equipo);
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
