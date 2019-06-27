using EventosUPC.AuthorizationAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventosUPC.Controllers
{
    [AutorizacionUsuario]
    [AutorizacionCliente]
    public class AdministradorController : Controller
    {

        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }
    }
}