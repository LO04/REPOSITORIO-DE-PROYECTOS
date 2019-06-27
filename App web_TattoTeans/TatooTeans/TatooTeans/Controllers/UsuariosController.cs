using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TatooTeans.Models;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace TatooTeans.Controllers
{
    public class UsuariosController : Controller
    {
        private TattoTeansEntities db = new TattoTeansEntities();


        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CrearEventoCronograma()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario user)
        {
            if (ModelState.IsValid)
            {
                var us = from u in db.Usuarios.Include("TipoUsuario")
                         where u.Correo.ToLower() ==
                         user.Correo.ToLower() &&
                         u.Contraseña == user.Contraseña
                         select u;
                Usuario objUser = us.FirstOrDefault();
                if (objUser != null)
                {
                    Session["Usuario"] = objUser;
                    if (objUser.TipoUsuario.Descripcion.ToLower() == "tatuador")
                    {
                        return RedirectToAction("Index", "Tatuador");
                    }
                    else if (objUser.TipoUsuario.Descripcion.ToLower() == "administrador")
                    {
                        return RedirectToAction("Index", "Administrador");
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Correo o contraseña invalido";
                }
            }
            return View(user);
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult CerrarCuenta()
        {
            Usuario o = db.Usuarios.Find(((Usuario)Session["Usuario"]).ID);
            db.Usuarios.Remove(o);

            db.SaveChanges();
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    // GET: Usuarios
    public ActionResult Index()
        {
            var usuarios = db.Usuarios.Include(u => u.TipoUsuario);
            return View(usuarios.ToList());
        }

        // GET: Usuarios/Details/5
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

        // GET: Usuarios/Create
        public ActionResult CreateI()
        {
            ViewBag.ID_TipoUsuario = new SelectList(db.TipoUsuarios, "ID", "Descripcion");
            return View();
        }

        
        public string ValidarDatos(string cadena, string valor) {
            string respuesta = string.Empty;
            string expresionCelular = "^[0-9]{9}$";
            string expresionCorreo = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
            //string expresionCorreo = @"^[a-z|A-Z|0-9|_|-]{1,}+[@]+[a-z|A-Z|0-9]{1,}+[.]+[c]+[o]+[m]$";

            switch (cadena)
            {
                case "n": case "a": case "dist": case "dir": case "contra":
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        respuesta += "No debe ser vacio o espacios en blanco";
                    }
                    break;
                case "c":
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        respuesta += "No debe ser vacio o espacios en blanco";
                    }
                    else if (!Regex.IsMatch(valor, expresionCorreo))
                    {
                        respuesta += "Debe tener el formato: example@domain" + "\n";
                    }
                    break;
                case "cs":
                    if (!string.IsNullOrWhiteSpace(valor))
                    {
                        if (!Regex.IsMatch(valor, expresionCorreo))
                        {
                            respuesta += "Debe tener el formato: example@domain" + "\n";
                        }
                    }
                    break;
                case "cel":
                    if (!string.IsNullOrWhiteSpace(valor))
                    {
                        if (!Regex.IsMatch(valor, expresionCelular))
                        {
                            respuesta += "Debe tener el formato: XXXXXXXXX (SOLO NUMEROS)" + "\n";
                        }
                    }
                    break;
                default:
                    break;

            }
           
            return respuesta;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateI(Usuario usuario)
        {
            string s1 = string.Empty, s2 = string.Empty, s3 = string.Empty, s4 = string.Empty, s5 = string.Empty, s6 = string.Empty, s7 = string.Empty, s8 = string.Empty;


            s1 = ValidarDatos("n", usuario.Nombre);
            s2 = ValidarDatos("a", usuario.Apellido);
            s3 = ValidarDatos("dist", usuario.Distrito);
            s4 = ValidarDatos("dir", usuario.Direccion);
            s5 = ValidarDatos("contra", usuario.Contraseña);
            s6 = ValidarDatos("c", usuario.Correo);
            s7 = ValidarDatos("cel", usuario.Celular);
            s8 = ValidarDatos("cs", usuario.CorreoSecundario);





            ViewBag.NOMBRE = s1;
            ViewBag.APELLIDO = s2;
            ViewBag.DISTRITO = s3;
            ViewBag.DIRECCION = s4;
            ViewBag.CONTRASEÑA = s5;
            ViewBag.CORREO = s6;
            ViewBag.CELULAR = s7;
            ViewBag.CORREOSECUNDARIO = s8;

            bool x = false;
            bool y = false;




            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2) && string.IsNullOrEmpty(s3) && string.IsNullOrEmpty(s4)
                && string.IsNullOrEmpty(s5) && string.IsNullOrEmpty(s6) && string.IsNullOrEmpty(s7) && string.IsNullOrEmpty(s8))
            {
                x = true;
                
            }
            var c = from a in db.Usuarios where a.Correo == usuario.Correo select a;
            if (c.FirstOrDefault() == null)
            {
                y = true;
            }
            else
            {
                ViewBag.CORREO = "Esta direccion de correo ya esta registrada";
            }

            if (x && y)
            {
                var tipo = from u in db.TipoUsuarios where u.Descripcion.ToLower() == "cliente" select u;
                usuario.ID_TipoUsuario = tipo.FirstOrDefault().ID;
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                Session["SuccessfulMessage"] = "Se creo tu cuenta satisfactoriamente";
                return RedirectToAction("Login","Usuarios");
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult EditI(int? id)
        {
            id = (((Usuario)Session["Usuario"]).ID);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_TipoUsuario = new SelectList(db.TipoUsuarios, "ID", "Descripcion", usuario.ID_TipoUsuario);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditI([Bind(Include = "ID,ID_TipoUsuario,Nombre,Apellido,FechaNac,Distrito,Direccion,Correo,Contraseña")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var tipo = from u in db.TipoUsuarios where u.Descripcion.ToLower() == "cliente" select u;
                usuario.ID_TipoUsuario = tipo.FirstOrDefault().ID;

                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            ViewBag.ID_TipoUsuario = new SelectList(db.TipoUsuarios, "ID", "Descripcion", usuario.ID_TipoUsuario);
            return View(usuario);
        }
        // GET: Usuarios1/Create
        public ActionResult Create()
        {
            ViewBag.ID_TipoUsuario = new SelectList(db.TipoUsuarios, "ID", "Descripcion");
            return View();
        }

        // POST: Usuarios1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_TipoUsuario,Nombre,Apellido,FechaNac,Distrito,Direccion,Correo,Contraseña,Celular,CorreoSecundario")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_TipoUsuario = new SelectList(db.TipoUsuarios, "ID", "Descripcion", usuario.ID_TipoUsuario);
            return View(usuario);
        }

        // GET: Usuarios1/Edit/5
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
            ViewBag.ID_TipoUsuario = new SelectList(db.TipoUsuarios, "ID", "Descripcion", usuario.ID_TipoUsuario);
            return View(usuario);
        }

        // POST: Usuarios1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_TipoUsuario,Nombre,Apellido,FechaNac,Distrito,Direccion,Correo,Contraseña,Celular,CorreoSecundario")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_TipoUsuario = new SelectList(db.TipoUsuarios, "ID", "Descripcion", usuario.ID_TipoUsuario);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
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

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
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
                Correo.Subject = ("Recuperar Contraseña Tatoo Teans");
                Correo.Body = "Hola! Buen dia, Usted solicito recuperar su contraseña: " + password;
                Correo.Priority = MailPriority.Normal;

                SmtpClient ServerEmail = new SmtpClient();
                ServerEmail.Credentials = new NetworkCredential("TatooTeans@gmail.com", "TatooTeans2018");
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
        public ActionResult Restore_Password([Bind(Include = "ID,ID_TipoUsuario,Nombre,Apellido,FechaNac,Distrito,Direccion,Correo,Contraseña")] Usuario usuario)
        {
            var us = from u in db.Usuarios.Include("TipoUsuario")
                     where u.Correo == usuario.Correo
                     select u;
            Usuario usuario_encontrado = us.FirstOrDefault();
            if(usuario_encontrado!=null)
                enviarEMail(usuario_encontrado.Correo, usuario_encontrado.Contraseña);
            return RedirectToAction("Index", "Home");
        }

        // GET: Usuarios1/Buscar
        public ActionResult Buscar()
        {
            var lista = from u in db.Usuarios.Include("TipoUsuario")
                     where u.ID_TipoUsuario == 1 || u.ID_TipoUsuario == 2
                     select u;
            ViewBag.Usuarios = lista.ToList();
            return View(lista.ToList());
        }

        // POST: Usuarios1/Buscar
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Buscar(string nombre)
        {
            var usuarios = from u in db.Usuarios.Include("TipoUsuario")
                          where u.Nombre == nombre
                           select u;
            ViewBag.Usuarios = usuarios.ToList();
            return View(usuarios.ToList());
        }
        // POST: Usuarios1/Buscar
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Buscar_Usuarios(int id)
        {
            var usuario = from u in db.Usuarios.Include("TipoUsuario")
                          where u.ID == id
                          select u;
            Usuario user = usuario.FirstOrDefault();
            return View(user);
        }

    }
}
