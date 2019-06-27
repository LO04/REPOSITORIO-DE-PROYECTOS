using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventosUPC.AuthorizationAttribute
{
    [AutorizacionUsuario]
    public class AutorizacionUsuario : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool result = false;
            if (httpContext.Session["MyUser"] != null)
            {
                result = true;
            }
            return result;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Controller.TempData["ErrorMessage"]
                = "Please login to access the site!";
            base.HandleUnauthorizedRequest(filterContext);
            filterContext.Result = new RedirectResult("/Usuario/Login");
        }
    }
}