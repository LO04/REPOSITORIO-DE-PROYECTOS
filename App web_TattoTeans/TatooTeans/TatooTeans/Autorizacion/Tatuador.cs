using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatooTeans.Models;

namespace TatooTeans.Autorizacion
{
    public class Tatuador : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["Usuario"] != null)
            {
                TatooTeans.Models.Usuario Obj = (TatooTeans.Models.Usuario)httpContext.Session["Usuario"];
                if (Obj.TipoUsuario.Descripcion.ToLower() == "tatuador")
                {
                    return true;
                }
            }
            return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
            filterContext.Result = new RedirectResult("/Home/Index");
        }
    }
}