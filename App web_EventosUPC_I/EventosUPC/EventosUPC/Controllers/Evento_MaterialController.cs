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
    public class Evento_MaterialController : Controller
    {
        private Eventos_TPEntitiesContext db = new Eventos_TPEntitiesContext();

        // GET: Evento_Material
        public ActionResult Index()
        {
            var evento_Material = db.Evento_Material.Include(e => e.Evento).Include(e => e.Material);
            return View(evento_Material.ToList());
        }

        // GET: Evento_Material/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Material evento_Material = db.Evento_Material.Find(id);
            if (evento_Material == null)
            {
                return HttpNotFound();
            }
            return View(evento_Material);
        }

        // GET: Evento_Material/Create
        public ActionResult Create()
        {
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre");
            ViewBag.id_material = new SelectList(db.Materials, "id_material", "nombre");
            return View();
        }

        // POST: Evento_Material/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_evento_material,id_evento,id_material")] Evento_Material evento_Material)
        {
            if (ModelState.IsValid)
            {
                db.Evento_Material.Add(evento_Material);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Material.id_evento);
            ViewBag.id_material = new SelectList(db.Materials, "id_material", "nombre", evento_Material.id_material);
            return View(evento_Material);
        }

        // GET: Evento_Material/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Material evento_Material = db.Evento_Material.Find(id);
            if (evento_Material == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Material.id_evento);
            ViewBag.id_material = new SelectList(db.Materials, "id_material", "nombre", evento_Material.id_material);
            return View(evento_Material);
        }

        // POST: Evento_Material/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_evento_material,id_evento,id_material")] Evento_Material evento_Material)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento_Material).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_evento = new SelectList(db.Eventoes, "id_evento", "nombre", evento_Material.id_evento);
            ViewBag.id_material = new SelectList(db.Materials, "id_material", "nombre", evento_Material.id_material);
            return View(evento_Material);
        }

        // GET: Evento_Material/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento_Material evento_Material = db.Evento_Material.Find(id);
            if (evento_Material == null)
            {
                return HttpNotFound();
            }
            return View(evento_Material);
        }

        // POST: Evento_Material/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento_Material evento_Material = db.Evento_Material.Find(id);
            db.Evento_Material.Remove(evento_Material);
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
