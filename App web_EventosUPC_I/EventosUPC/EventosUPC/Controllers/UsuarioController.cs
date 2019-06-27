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
using System.Net.Mail;

namespace EventosUPC.Controllers
{
    [AutorizacionUsuario]
    public class UsuarioController : Controller
    {
        private Eventos_TPEntitiesContext db = new Eventos_TPEntitiesContext();

        // GET: Usuario
        public ActionResult Index()
        {
            var usuarios = db.Usuarios.Include(u => u.Tipo_Usuario);
            return View(usuarios.ToList());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.TipoUsuarioID = new SelectList(db.Tipo_Usuario, "ID", "Nombre");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Apellido,Celular,DNI,Direccion,Correo,Contraseña,TipoUsuarioID")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoUsuarioID = new SelectList(db.Tipo_Usuario, "ID", "Nombre", usuario.TipoUsuarioID);
            return View(usuario);
        }
        [AllowAnonymous]
        // GET: Usuario/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var ut = from t in db.Tipo_Usuario
                         where t.Nombre.ToLower()
                         == "Cliente"
                         select t;
                Tipo_Usuario objTipo_usuario = ut.FirstOrDefault();
                usuario.TipoUsuarioID= objTipo_usuario.ID;
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(usuario);
        }
        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoUsuarioID = new SelectList(db.Tipo_Usuario, "ID", "Nombre", usuario.TipoUsuarioID);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Apellido,Celular,DNI,Direccion,Correo,Contraseña,TipoUsuarioID")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoUsuarioID = new SelectList(db.Tipo_Usuario, "ID", "Nombre", usuario.TipoUsuarioID);
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        // GET: Users/Login
        public ActionResult Login()
        {
            return View();
        }
        // POST: Usuario/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var us = from u in db.Usuarios.Include("Tipo_Usuario")
                         where u.Correo==
                         usuario.Correo &&
                         u.Contraseña == usuario.Contraseña
                         select u;
                Usuario objUser = us.FirstOrDefault();
                if (objUser != null)
                {
                    Session["MyUser"] = objUser;
                    if (objUser.Tipo_Usuario.Nombre == "Administrador")
                    {
                        return RedirectToAction("Index","Usuario");
                    }
                    else if (objUser.Tipo_Usuario.Nombre == "Cliente")
                    {
                        return RedirectToAction("Index", "Evento");
                    }
                    else if (objUser.Tipo_Usuario.Nombre == "Organizador")
                    {
                        return RedirectToAction("Index", "Actividad");
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Correo o contraseña invalido";
                }
            }
            return View(usuario);
        }
        [AllowAnonymous]
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        //Recuperar
        [AllowAnonymous]
        // GET: Empleados/Create
        public ActionResult Restore_Password()
        {
            return View();
        }
        [AllowAnonymous]
        public void enviarEMail(string correo, string password)
        {
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("TatooTeans@gmail.com");
            Correo.To.Add(correo);
            Correo.Subject = ("Recuperar Contraseña EventosUPC");
            Correo.Body = "Hola! Buen dia, Usted solicito recuperar su contraseña: " + password;
            Correo.Priority = MailPriority.Normal;

            SmtpClient ServerEmail = new SmtpClient();
            ServerEmail.Credentials = new NetworkCredential("EventosUPC@gmail.com", "EventosUPC2018");
            ServerEmail.Host = "smtp.gmail.com";
            ServerEmail.Port = 587;
            ServerEmail.EnableSsl = true;
            try
            {
                ServerEmail.Send(Correo);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            Correo.Dispose();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Restore_Password(Usuario usuario)
        {
            var us = from u in db.Usuarios.Include("Tipo_Usuario")
                     where u.Correo == usuario.Correo
                     select u;
            Usuario usuario_encontrado = us.FirstOrDefault();
            if (usuario_encontrado != null)
                enviarEMail(usuario_encontrado.Correo, usuario_encontrado.Contraseña);
            return RedirectToAction("Index", "Home");
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
