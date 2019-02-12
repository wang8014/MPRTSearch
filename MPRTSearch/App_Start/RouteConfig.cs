using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MPRTSearch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional },
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                namespaces: new[] { "MPRTSearch.Areas.SPA.Controllers" }
            ).DataTokens.Add("Area", "SPA");

            routes.MapRoute(
                name: "Default2",
                url: "home",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional },
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                namespaces: new[] { "MPRTSearch.Areas.SPA.Controllers" }
            ).DataTokens.Add("Area", "SPA");
            routes.MapRoute(
                name: "Default3",
                url: "home/index",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional },
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                namespaces: new[] { "MPRTSearch.Areas.SPA.Controllers" }
            ).DataTokens.Add("Area", "SPA");
            routes.MapRoute(
                name: "Default4",
                url: "home/about",
                defaults: new { controller = "Main", action = "about", id = UrlParameter.Optional },
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                namespaces: new[] { "MPRTSearch.Areas.SPA.Controllers" }
            ).DataTokens.Add("Area", "SPA");
            routes.MapRoute(
                name: "Default5",
                url: "{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional },
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                namespaces: new[] { "MPRTSearch.Areas.SPA.Controllers" }
            ).DataTokens.Add("Area", "SPA");

            //routes.MapRoute(
            //    name: "NormalRoute",
            //    url: "SPA/{controller}/{action}/{id}",
            //    defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
