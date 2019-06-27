using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventosUPC.Models;
using System.Net;
using EventosUPC.AuthorizationAttribute;

namespace EventosUPC.Controllers
{
    [AutorizacionUsuario]
    public class ReportesController : Controller
    {
        private Eventos_TPEntitiesContext db = new Eventos_TPEntitiesContext();
        // GET: Reportes
        
        public ActionResult IndexRepo()
        {
            var eventoes = db.Eventoes.Include(e => e.Local).Include(e => e.Usuario);
            return View(eventoes.ToList());
        }
        [ChildActionOnly]
        public ActionResult DetalleEquipo(int EventoID)
        {
            List<Evento_Equipo> EE = db.Evento_Equipo.Where(e => e.id_evento == EventoID).ToList();

            return PartialView(EE);
            
        }

        [ChildActionOnly]
        public ActionResult DetalleActividad(int EventoID)
        {
            List<Evento_Actividad> EA = db.Evento_Actividad.Where(e => e.id_evento == EventoID).ToList();

            return PartialView(EA);

        }
        [ChildActionOnly]
        public ActionResult DetalleMaterial(int EventoID)
        {
            List<Evento_Material> EA = db.Evento_Material.Where(e => e.id_evento == EventoID).ToList();

            return PartialView(EA);

        }
        [ChildActionOnly]
        public ActionResult DetallePersonal(int EventoID)
        {
            List<Evento_Personal> EA = db.Evento_Personal.Where(e => e.id_evento == EventoID).ToList();

            return PartialView(EA);

        }
        [ChildActionOnly]
        public ActionResult DetalleServicio(int EventoID)
        {
            List<Evento_Servicio> EA = db.Evento_Servicio.Where(e => e.id_evento == EventoID).ToList();

            return PartialView(EA);

        }
        // GET: Evento/Edit/5
        public ActionResult EditEve(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_local = new SelectList(db.Locals, "id_local", "nombre", evento.id_local);
            ViewBag.id_cliente = new SelectList(db.Usuarios, "ID", "Nombre", evento.id_cliente);
            return View(evento);
        }

        // POST: Evento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEve(Evento evento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IndexRepo");
            }
            ViewBag.id_local = new SelectList(db.Locals, "id_local", "nombre", evento.id_local);
            ViewBag.id_cliente = new SelectList(db.Usuarios, "ID", "Nombre", evento.id_cliente);
            return View(evento);
        }
        // GET: Evento/Create
        public ActionResult CreateEve()
        {
            ViewBag.id_local = new SelectList(db.Locals, "id_local", "nombre");
            ViewBag.id_cliente = new SelectList(db.Usuarios, "ID", "Nombre");
            return View();
        }

        // POST: Evento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEve([Bind(Include = "id_evento,id_cliente,id_local,nombre,objetivo,nro_asistentes,fecha_evento,encargado")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                db.Eventoes.Add(evento);
                db.SaveChanges();
                return RedirectToAction("IndexRepo");
            }

            ViewBag.id_local = new SelectList(db.Locals, "id_local", "nombre", evento.id_local);
            ViewBag.id_cliente = new SelectList(db.Usuarios, "ID", "Nombre", evento.id_cliente);
            return View(evento);
        }
        //// GET: Evento/Delete/5
        //public ActionResult DeleteEve(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Evento evento = db.Eventoes.Find(id);
        //    if (evento == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(evento);
        //}

        //// POST: Evento/Delete/5
        //[HttpPost, ActionName("DeleteEve")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Evento evento = db.Eventoes.Find(id);
        //    db.Eventoes.Remove(evento);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

    }
}