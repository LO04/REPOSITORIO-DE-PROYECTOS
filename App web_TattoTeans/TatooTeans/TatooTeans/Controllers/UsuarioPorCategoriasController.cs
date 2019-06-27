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
    public class UsuarioPorCategoriasController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();

        // GET: UsuarioPorCategorias
        public ActionResult Index()
        {
            var usuarioPorCategorias = db.UsuarioPorCategorias.Include(u => u.CategoriaTatuaje).Include(u => u.Usuario);
            return View(usuarioPorCategorias.ToList());
        }

        // GET: UsuarioPorCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioPorCategoria usuarioPorCategoria = db.UsuarioPorCategorias.Find(id);
            if (usuarioPorCategoria == null)
            {
                return HttpNotFound();
            }
            return View(usuarioPorCategoria);
        }

        // GET: UsuarioPorCategorias/Create
        public ActionResult Create()
        {
            ViewBag.ID_Categoria = new SelectList(db.CategoriaTatuajes, "ID", "Tipo");
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre");
            return View();
        }

        // POST: UsuarioPorCategorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_Categoria,ID_Usuario")] UsuarioPorCategoria usuarioPorCategoria)
        {
            if (ModelState.IsValid)
            {
                db.UsuarioPorCategorias.Add(usuarioPorCategoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Categoria = new SelectList(db.CategoriaTatuajes, "ID", "Tipo", usuarioPorCategoria.ID_Categoria);
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", usuarioPorCategoria.ID_Usuario);
            return View(usuarioPorCategoria);
        }

        // GET: UsuarioPorCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioPorCategoria usuarioPorCategoria = db.UsuarioPorCategorias.Find(id);
            if (usuarioPorCategoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Categoria = new SelectList(db.CategoriaTatuajes, "ID", "Tipo", usuarioPorCategoria.ID_Categoria);
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", usuarioPorCategoria.ID_Usuario);
            return View(usuarioPorCategoria);
        }

        // POST: UsuarioPorCategorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_Categoria,ID_Usuario")] UsuarioPorCategoria usuarioPorCategoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarioPorCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Categoria = new SelectList(db.CategoriaTatuajes, "ID", "Tipo", usuarioPorCategoria.ID_Categoria);
            ViewBag.ID_Usuario = new SelectList(db.Usuarios, "ID", "Nombre", usuarioPorCategoria.ID_Usuario);
            return View(usuarioPorCategoria);
        }

        // GET: UsuarioPorCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioPorCategoria usuarioPorCategoria = db.UsuarioPorCategorias.Find(id);
            if (usuarioPorCategoria == null)
            {
                return HttpNotFound();
            }
            return View(usuarioPorCategoria);
        }

        // POST: UsuarioPorCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuarioPorCategoria usuarioPorCategoria = db.UsuarioPorCategorias.Find(id);
            db.UsuarioPorCategorias.Remove(usuarioPorCategoria);
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
