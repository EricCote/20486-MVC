using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Seminaire
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "blog",
               url: "blog/{annee}/{mois}/{jour}/{titre}",
               defaults: new { controller = "Php", action = "Bonjour" }
           );

            routes.MapRoute(
              name: "php",
              url: "{page}.php",
              defaults: new { controller = "Php", action = "Test" }
          );


            routes.MapRoute(
                name: "bonjour",
                url: "bonjour/{prenom}/{nom}",
                defaults: new { controller = "Php", action = "Bonjour" }
            );


            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
