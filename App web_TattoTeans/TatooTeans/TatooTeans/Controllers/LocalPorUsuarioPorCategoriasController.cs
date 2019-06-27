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
    public class LocalPorUsuarioPorCategoriasController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();

        // GET: LocalPorUsuarioPorCategorias
        public ActionResult Index()
        {
            var localPorUsuarioPorCategorias = db.LocalPorUsuarioPorCategorias.Include(l => l.Local).Include(l => l.UsuarioPorCategoria);
            return View(localPorUsuarioPorCategorias.ToList());
        }

        // GET: LocalPorUsuarioPorCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalPorUsuarioPorCategoria localPorUsuarioPorCategoria = db.LocalPorUsuarioPorCategorias.Find(id);
            if (localPorUsuarioPorCategoria == null)
            {
                return HttpNotFound();
            }
            return View(localPorUsuarioPorCategoria);
        }

        // GET: LocalPorUsuarioPorCategorias/Create
        public ActionResult Create()
        {
            ViewBag.ID_Local = new SelectList(db.Locals, "ID", "Distrito");
            ViewBag.ID_UsuarioPorCategoria = new SelectList(db.UsuarioPorCategorias, "ID", "ID");
            return View();
        }

        // POST: LocalPorUsuarioPorCategorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_Local,ID_UsuarioPorCategoria")] LocalPorUsuarioPorCategoria localPorUsuarioPorCategoria)
        {
            if (ModelState.IsValid)
            {
                db.LocalPorUsuarioPorCategorias.Add(localPorUsuarioPorCategoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Local = new SelectList(db.Locals, "ID", "Distrito", localPorUsuarioPorCategoria.ID_Local);
            ViewBag.ID_UsuarioPorCategoria = new SelectList(db.UsuarioPorCategorias, "ID", "ID", localPorUsuarioPorCategoria.ID_UsuarioPorCategoria);
            return View(localPorUsuarioPorCategoria);
        }

        // GET: LocalPorUsuarioPorCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalPorUsuarioPorCategoria localPorUsuarioPorCategoria = db.LocalPorUsuarioPorCategorias.Find(id);
            if (localPorUsuarioPorCategoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Local = new SelectList(db.Locals, "ID", "Distrito", localPorUsuarioPorCategoria.ID_Local);
            ViewBag.ID_UsuarioPorCategoria = new SelectList(db.UsuarioPorCategorias, "ID", "ID", localPorUsuarioPorCategoria.ID_UsuarioPorCategoria);
            return View(localPorUsuarioPorCategoria);
        }

        // POST: LocalPorUsuarioPorCategorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_Local,ID_UsuarioPorCategoria")] LocalPorUsuarioPorCategoria localPorUsuarioPorCategoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localPorUsuarioPorCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Local = new SelectList(db.Locals, "ID", "Distrito", localPorUsuarioPorCategoria.ID_Local);
            ViewBag.ID_UsuarioPorCategoria = new SelectList(db.UsuarioPorCategorias, "ID", "ID", localPorUsuarioPorCategoria.ID_UsuarioPorCategoria);
            return View(localPorUsuarioPorCategoria);
        }

        // GET: LocalPorUsuarioPorCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalPorUsuarioPorCategoria localPorUsuarioPorCategoria = db.LocalPorUsuarioPorCategorias.Find(id);
            if (localPorUsuarioPorCategoria == null)
            {
                return HttpNotFound();
            }
            return View(localPorUsuarioPorCategoria);
        }

        // POST: LocalPorUsuarioPorCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LocalPorUsuarioPorCategoria localPorUsuarioPorCategoria = db.LocalPorUsuarioPorCategorias.Find(id);
            db.LocalPorUsuarioPorCategorias.Remove(localPorUsuarioPorCategoria);
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
