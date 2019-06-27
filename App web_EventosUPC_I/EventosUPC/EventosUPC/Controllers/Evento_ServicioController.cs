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
    public class Evento_ServicioController : Controller
    {
        private Eventos_TPEntitiesContext db = new Eventos_TPEntitiesContext();

        // GET: Evento_Servicio
        public ActionResult Index()
        {
            var evento_Servicio = db.Evento_Servicio.Include(e => e.Evento).Include(e => e.Servicio);
            return View(evento_Servicio.ToList());
        }

        // GET: Evento_Servicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Servicio evento_Servicio = db.Evento_Servicio.Find(id);
            if (evento_Servicio == null)
            {
                return HttpNotFound();
            }
            return View(evento_Servicio);
        }

        // GET: Evento_Servicio/Create
        public ActionResult Create()
        {
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre");
            ViewBag.id_servicio = new SelectList(db.Servicios, "id_servicio", "nombre");
            return View();
        }

        // POST: Evento_Servicio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_evento_servicio,id_evento,id_servicio")] Evento_Servicio evento_Servicio)
        {
            if (ModelState.IsValid)
            {
                db.Evento_Servicio.Add(evento_Servicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Servicio.id_evento);
            ViewBag.id_servicio = new SelectList(db.Servicios, "id_servicio", "nombre", evento_Servicio.id_servicio);
            return View(evento_Servicio);
        }

        // GET: Evento_Servicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Servicio evento_Servicio = db.Evento_Servicio.Find(id);
            if (evento_Servicio == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Servicio.id_evento);
            ViewBag.id_servicio = new SelectList(db.Servicios, "id_servicio", "nombre", evento_Servicio.id_servicio);
            return View(evento_Servicio);
        }

        // POST: Evento_Servicio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_evento_servicio,id_evento,id_servicio")] Evento_Servicio evento_Servicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento_Servicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Servicio.id_evento);
            ViewBag.id_servicio = new SelectList(db.Servicios, "id_servicio", "nombre", evento_Servicio.id_servicio);
            return View(evento_Servicio);
        }

        // GET: Evento_Servicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Servicio evento_Servicio = db.Evento_Servicio.Find(id);
            if (evento_Servicio == null)
            {
                return HttpNotFound();
            }
            return View(evento_Servicio);
        }

        // POST: Evento_Servicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento_Servicio evento_Servicio = db.Evento_Servicio.Find(id);
            db.Evento_Servicio.Remove(evento_Servicio);
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
