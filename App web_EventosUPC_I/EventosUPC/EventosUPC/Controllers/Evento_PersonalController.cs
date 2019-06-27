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
    public class Evento_PersonalController : Controller
    {
        private Eventos_TPEntitiesContext db = new Eventos_TPEntitiesContext();

        // GET: Evento_Personal
        public ActionResult Index()
        {
            var evento_Personal = db.Evento_Personal.Include(e => e.Evento).Include(e => e.Personal);
            return View(evento_Personal.ToList());
        }

        // GET: Evento_Personal/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Personal evento_Personal = db.Evento_Personal.Find(id);
            if (evento_Personal == null)
            {
                return HttpNotFound();
            }
            return View(evento_Personal);
        }

        // GET: Evento_Personal/Create
        public ActionResult Create()
        {
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre");
            ViewBag.id_personal = new SelectList(db.Personals, "id_personal", "nombre");
            return View();
        }

        // POST: Evento_Personal/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_evento_personal,id_evento,id_personal,horas_trab")] Evento_Personal evento_Personal)
        {
            if (ModelState.IsValid)
            {
                db.Evento_Personal.Add(evento_Personal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Personal.id_evento);
            ViewBag.id_personal = new SelectList(db.Personals, "id_personal", "nombre", evento_Personal.id_personal);
            return View(evento_Personal);
        }

        // GET: Evento_Personal/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Personal evento_Personal = db.Evento_Personal.Find(id);
            if (evento_Personal == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Personal.id_evento);
            ViewBag.id_personal = new SelectList(db.Personals, "id_personal", "nombre", evento_Personal.id_personal);
            return View(evento_Personal);
        }

        // POST: Evento_Personal/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_evento_personal,id_evento,id_personal,horas_trab")] Evento_Personal evento_Personal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento_Personal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Personal.id_evento);
            ViewBag.id_personal = new SelectList(db.Personals, "id_personal", "nombre", evento_Personal.id_personal);
            return View(evento_Personal);
        }

        // GET: Evento_Personal/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Personal evento_Personal = db.Evento_Personal.Find(id);
            if (evento_Personal == null)
            {
                return HttpNotFound();
            }
            return View(evento_Personal);
        }

        // POST: Evento_Personal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento_Personal evento_Personal = db.Evento_Personal.Find(id);
            db.Evento_Personal.Remove(evento_Personal);
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
