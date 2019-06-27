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
    public class FacturaComprasController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();

        // GET: FacturaCompras
        public ActionResult Index()
        {
            var facturaCompras = db.FacturaCompras.Include(f => f.TipoDePago).Include(f => f.Usuario);
            return View(facturaCompras.ToList());
        }

        // GET: FacturaCompras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaCompra facturaCompra = db.FacturaCompras.Find(id);
            if (facturaCompra == null)
            {
                return HttpNotFound();
            }
            return View(facturaCompra);
        }

        // GET: FacturaCompras/Create
        public ActionResult Create()
        {
            ViewBag.ID_TipoDePago = new SelectList(db.TipoDePagoes, "ID", "Nombre");
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre");
            return View();
        }

        // POST: FacturaCompras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_Usuario,ID_TipoDePago")] FacturaCompra facturaCompra)
        {
            if (ModelState.IsValid)
            {
                db.FacturaCompras.Add(facturaCompra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_TipoDePago = new SelectList(db.TipoDePagoes, "ID", "Nombre", facturaCompra.ID_TipoDePago);
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", facturaCompra.ID_Usuario);
            return View(facturaCompra);
        }

        // GET: FacturaCompras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaCompra facturaCompra = db.FacturaCompras.Find(id);
            if (facturaCompra == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_TipoDePago = new SelectList(db.TipoDePagoes, "ID", "Nombre", facturaCompra.ID_TipoDePago);
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", facturaCompra.ID_Usuario);
            return View(facturaCompra);
        }

        // POST: FacturaCompras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_Usuario,ID_TipoDePago")] FacturaCompra facturaCompra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facturaCompra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_TipoDePago = new SelectList(db.TipoDePagoes, "ID", "Nombre", facturaCompra.ID_TipoDePago);
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", facturaCompra.ID_Usuario);
            return View(facturaCompra);
        }

        // GET: FacturaCompras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaCompra facturaCompra = db.FacturaCompras.Find(id);
            if (facturaCompra == null)
            {
                return HttpNotFound();
            }
            return View(facturaCompra);
        }

        // POST: FacturaCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacturaCompra facturaCompra = db.FacturaCompras.Find(id);
            db.FacturaCompras.Remove(facturaCompra);
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
