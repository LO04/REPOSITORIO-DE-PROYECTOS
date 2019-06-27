using EventosUPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventosUPC.AuthorizationAttribute
{
    public class AutorizacionAdministrador : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool result = false;
            if (httpContext.Session["MyUser"] != null)
            {
                EventosUPC.Models.Usuario Obj = (EventosUPC.Models.Usuario)httpContext.Session["MyUser"];
                if (Obj.Tipo_Usuario.Nombre.ToLower() == "Administrador")
                {
                    result = true;
                }
            }
            return result;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
            filterContext.Result = new RedirectResult("/Administrador/Index");
        }
    }
}