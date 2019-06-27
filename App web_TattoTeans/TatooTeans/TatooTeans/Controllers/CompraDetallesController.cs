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
    public class CompraDetallesController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();
        List<CompraDetalle> lista = new List<CompraDetalle>();
        // GET: CompraDetalles
        public ActionResult Index()
        {
            var compraDetalles = db.CompraDetalles.Include(c => c.FacturaCompra).Include(c => c.Producto);
            return View(compraDetalles.ToList());
        }



        // GET: CompraDetalles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraDetalle compraDetalle = db.CompraDetalles.Find(id);
            if (compraDetalle == null)
            {
                return HttpNotFound();
            }
            return View(compraDetalle);
        }

        // GET: CompraDetalles/Create
        public ActionResult Create()
        {
            ViewBag.ID_FacturaCompra = new SelectList(db.FacturaCompras, "ID", "ID");
            ViewBag.ID_Producto = new SelectList(db.Productoes, "ID", "Nombre");
            return View();
        }

        // POST: CompraDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_Producto,ID_FacturaCompra,Cantidad")] CompraDetalle compraDetalle)
        {
            if (ModelState.IsValid)
            {
                db.CompraDetalles.Add(compraDetalle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_FacturaCompra = new SelectList(db.FacturaCompras, "ID", "ID", compraDetalle.ID_FacturaCompra);
            ViewBag.ID_Producto = new SelectList(db.Productoes, "ID", "Nombre", compraDetalle.ID_Producto);
            return View(compraDetalle);
        }

        // GET: CompraDetalles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraDetalle compraDetalle = db.CompraDetalles.Find(id);
            if (compraDetalle == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_FacturaCompra = new SelectList(db.FacturaCompras, "ID", "ID", compraDetalle.ID_FacturaCompra);
            ViewBag.ID_Producto = new SelectList(db.Productoes, "ID", "Nombre", compraDetalle.ID_Producto);
            return View(compraDetalle);
        }

        // POST: CompraDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_Producto,ID_FacturaCompra,Cantidad")] CompraDetalle compraDetalle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compraDetalle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_FacturaCompra = new SelectList(db.FacturaCompras, "ID", "ID", compraDetalle.ID_FacturaCompra);
            ViewBag.ID_Producto = new SelectList(db.Productoes, "ID", "Nombre", compraDetalle.ID_Producto);
            return View(compraDetalle);
        }

        // GET: CompraDetalles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraDetalle compraDetalle = db.CompraDetalles.Find(id);
            if (compraDetalle == null)
            {
                return HttpNotFound();
            }
            return View(compraDetalle);
        }

        // POST: CompraDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompraDetalle compraDetalle = db.CompraDetalles.Find(id);
            db.CompraDetalles.Remove(compraDetalle);
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

        private void creacionPedido() //CrearNuevoPedido
        {
            //CrearNuevoPedido
            FacturaCompra objNuevoPedido = new FacturaCompra();
            Usuario objUser = (Usuario)Session["User"];
            objNuevoPedido.ID_Usuario = objUser.ID;
            objNuevoPedido.ID_TipoDePago = 0;
            db.FacturaCompras.Add(objNuevoPedido);
            db.SaveChanges();
            //Pedido objNuevoPedido = new Pedido();
            //objNuevoPedido.Atendido = false;
            //objNuevoPedido.Detalle = txtNombreCliente.Text;
            //objNuevoPedido.IdEmpleado = "ADMINMax";
        }
        void listaCrear(){
            //lista;
        }
        // GET: Productos_Pedidos/Create
        public ActionResult Orden()
        {
            lista = new List<CompraDetalle>();
            int cont = 0;
            var lista_de_productos = from c in db.Productoes.Include("CategoriaProducto")
                                     select c;
            ViewBag.Productos = lista_de_productos.ToList();
            ViewBag.Contador = cont;
            Usuario objUser = (Usuario)Session["Usuario"];
            ViewBag.Nombre = objUser.Nombre;
            return View(new List<CompraDetalle>());
        }
          
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Orden(int id, int ncontador)
        {
            //Producto producto = db.Productoes.Find(id);
            if (ncontador == 0)
            {
                //lista = new List<CompraDetalle>();
                //creacionPedido();
                ncontador++;
            }
            CompraDetalle aux = new CompraDetalle();
            aux.ID_Producto = id;
            aux.ID_FacturaCompra = 0;
            //aux.ID_FacturaCompra= (from c in db.FacturaCompras select c).Count();
            if (ModelState.IsValid)
            {
                //db.CompraDetalles.Add(aux);
                //db.SaveChanges();
                lista.Add(aux);
                //Productos
               
            }
            //Productos
            var lista_de_productos = from c in db.Productoes.Include("CategoriaProducto")
                                     select c;
            ViewBag.Productos = lista_de_productos.ToList();
            ViewBag.Contador = ncontador;

            return View(Getpedido());
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pedidos_Boleta()
        {
            double suma_total=0;
            for(int i=0;i<lista.Count();i++){
                suma_total += lista[i].Producto.Precio;
            }
            ViewBag.MontoTotal = suma_total;
            /*ViewBag.MontoTotal = (from a in db.PPS.
                            Include("Producto").Include("P").AsEnumerable()
                                  where a.IdPedido == indice
                                  select a.Producto.Precio).Sum();*/
            ViewBag.ID_TipoDePago = new SelectList(db.TipoDePagoes, "ID", "Nombre");
            return View();
        }

        [AllowAnonymous]
        public IEnumerable<TatooTeans.Models.CompraDetalle> Getpedido()
        {
            return lista.AsEnumerable<TatooTeans.Models.CompraDetalle>();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarPedido(int ID_TipoDePago)
        {
            FacturaCompra objFacturaCompra = new FacturaCompra();
            objFacturaCompra.ID_TipoDePago = ID_TipoDePago;
            Usuario objUser = (Usuario)Session["Usuario"];
            objFacturaCompra.ID_Usuario = objUser.ID;

            db.FacturaCompras.Add(objFacturaCompra);
            db.SaveChanges();

            var Facturas = from c in db.FacturaCompras.Include("TipoDePago").Include("Usuario")
                           select c;
            FacturaCompra ultimaFactura = (FacturaCompra) Facturas.LastOrDefault();
            
            for(int i=0; i<lista.Count();i++){
                lista[i].ID_FacturaCompra = ultimaFactura.ID;
                lista[i].Cantidad = 0;
            }

            IEnumerable<TatooTeans.Models.CompraDetalle> listaAux = Getpedido();

            db.CompraDetalles.AddRange(listaAux);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
