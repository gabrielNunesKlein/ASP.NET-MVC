using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace webMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "sobre_parametro",
                "sobre/{id}/gabriel",
                new { controller = "Home", action = "About", id = 0 }
            );

            routes.MapRoute(
                "sobre",
                "sobre",
                new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
                "contato",
                "contato",
                new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
