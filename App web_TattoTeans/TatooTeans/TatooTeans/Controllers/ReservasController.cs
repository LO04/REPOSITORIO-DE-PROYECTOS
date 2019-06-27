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
    public class ReservasController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();

        // GET: Reservas
        public ActionResult Index()
        {
            var reservas = db.Reservas.Include(r => r.LocalPorUsuarioPorCategoria).Include(r => r.Usuario);
            return View(reservas.ToList());
        }

        // GET: Reservas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // GET: Reservas/Create
        public ActionResult Create()
        {
            ViewBag.ID_LocalPorUsuarioPorCategoria = new SelectList(db.LocalPorUsuarioPorCategorias, "ID", "ID");
            ViewBag.ID_Cliente = new SelectList(db.Usuarios, "ID", "Nombre");
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_LocalPorUsuarioPorCategoria,FechaReserva,Descripcion,ID_Cliente")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Reservas.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_LocalPorUsuarioPorCategoria = new SelectList(db.LocalPorUsuarioPorCategorias, "ID", "ID", reserva.ID_LocalPorUsuarioPorCategoria);
            ViewBag.ID_Cliente = new SelectList(db.Usuarios, "ID", "Nombre", reserva.ID_Cliente);
            return View(reserva);
        }

        // GET: Reservas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_LocalPorUsuarioPorCategoria = new SelectList(db.LocalPorUsuarioPorCategorias, "ID", "ID", reserva.ID_LocalPorUsuarioPorCategoria);
            ViewBag.ID_Cliente = new SelectList(db.Usuarios, "ID", "Nombre", reserva.ID_Cliente);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_LocalPorUsuarioPorCategoria,FechaReserva,Descripcion,ID_Cliente")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_LocalPorUsuarioPorCategoria = new SelectList(db.LocalPorUsuarioPorCategorias, "ID", "ID", reserva.ID_LocalPorUsuarioPorCategoria);
            ViewBag.ID_Cliente = new SelectList(db.Usuarios, "ID", "Nombre", reserva.ID_Cliente);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reserva reserva = db.Reservas.Find(id);
            db.Reservas.Remove(reserva);
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
