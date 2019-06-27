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
    public class CategoriaTatuajesController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();

        public ActionResult BuscarCategoriaTatuaje()
        {
            var cat = from l in db.CategoriaTatuajes select l;
            var t = from y in db.TrabajoRealizadoes.Include("Usuario") select y;
            ViewBag.categoria = cat.ToList();
            return View(t.ToList());
        }
        [HttpPost]
        public ActionResult BuscarCategoriaTatuaje(int?id)
        {
            var i = from a in db.UsuarioPorCategorias where a.ID_Categoria == id select a;
            var cat = from l in db.CategoriaTatuajes select l;
            ViewBag.categoria = cat.ToList();
            ViewBag.c = id;
            List<TrabajoRealizado> trabajo = new List<TrabajoRealizado>();
            foreach(var item in i.ToList())
            {
                var g  = from k in db.TrabajoRealizadoes.Include("Usuario") where k.ID_Usuario == item.ID_Usuario select k;
                if (g.ToList() != null)
                {
                    trabajo.AddRange(g.ToList());
                }
            }

            return View(trabajo);
        }
        // GET: CategoriaTatuajes
        public ActionResult Index()
        {
            return View(db.CategoriaTatuajes.ToList());
        }

        // GET: CategoriaTatuajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTatuaje categoriaTatuaje = db.CategoriaTatuajes.Find(id);
            if (categoriaTatuaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTatuaje);
        }

        // GET: CategoriaTatuajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaTatuajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Tipo,Descripcion")] CategoriaTatuaje categoriaTatuaje)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaTatuajes.Add(categoriaTatuaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaTatuaje);
        }

        // GET: CategoriaTatuajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTatuaje categoriaTatuaje = db.CategoriaTatuajes.Find(id);
            if (categoriaTatuaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTatuaje);
        }

        // POST: CategoriaTatuajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Tipo,Descripcion")] CategoriaTatuaje categoriaTatuaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaTatuaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaTatuaje);
        }

        // GET: CategoriaTatuajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTatuaje categoriaTatuaje = db.CategoriaTatuajes.Find(id);
            if (categoriaTatuaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTatuaje);
        }

        // POST: CategoriaTatuajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaTatuaje categoriaTatuaje = db.CategoriaTatuajes.Find(id);
            db.CategoriaTatuajes.Remove(categoriaTatuaje);
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
