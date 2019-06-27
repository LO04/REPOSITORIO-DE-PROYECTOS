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
    public class Evento_ActividadController : Controller
    {
        private Eventos_TPEntitiesContext db = new Eventos_TPEntitiesContext();

        // GET: Evento_Actividad
        public ActionResult Index()
        {
            var evento_Actividad = db.Evento_Actividad.Include(e => e.Actividad).Include(e => e.Evento);
            return View(evento_Actividad.ToList());
        }

        // GET: Evento_Actividad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Actividad evento_Actividad = db.Evento_Actividad.Find(id);
            if (evento_Actividad == null)
            {
                return HttpNotFound();
            }
            return View(evento_Actividad);
        }

        // GET: Evento_Actividad/Create
        public ActionResult Create()
        {
            ViewBag.id_actividad = new SelectList(db.Actividads, "id_actividad", "nombre");
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre");
            return View();
        }

        // POST: Evento_Actividad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_evento_actividad,id_evento,id_actividad,hora_inicio,hora_fin")] Evento_Actividad evento_Actividad)
        {
            if (ModelState.IsValid)
            {
                db.Evento_Actividad.Add(evento_Actividad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_actividad = new SelectList(db.Actividads, "id_actividad", "nombre", evento_Actividad.id_actividad);
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Actividad.id_evento);
            return View(evento_Actividad);
        }

        // GET: Evento_Actividad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Actividad evento_Actividad = db.Evento_Actividad.Find(id);
            if (evento_Actividad == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_actividad = new SelectList(db.Actividads, "id_actividad", "nombre", evento_Actividad.id_actividad);
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Actividad.id_evento);
            return View(evento_Actividad);
        }

        // POST: Evento_Actividad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_evento_actividad,id_evento,id_actividad,hora_inicio,hora_fin")] Evento_Actividad evento_Actividad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento_Actividad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_actividad = new SelectList(db.Actividads, "id_actividad", "nombre", evento_Actividad.id_actividad);
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Actividad.id_evento);
            return View(evento_Actividad);
        }

        // GET: Evento_Actividad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Actividad evento_Actividad = db.Evento_Actividad.Find(id);
            if (evento_Actividad == null)
            {
                return HttpNotFound();
            }
            return View(evento_Actividad);
        }

        // POST: Evento_Actividad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento_Actividad evento_Actividad = db.Evento_Actividad.Find(id);
            db.Evento_Actividad.Remove(evento_Actividad);
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
