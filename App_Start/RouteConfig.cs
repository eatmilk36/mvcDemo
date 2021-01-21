using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvcDEMO
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //這個可以
            //routes.MapRoute(
            //    name: "demo",
            //    url: "demo/demo2/{id}",
            //    defaults: new { controller = "Jeter", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "demo",
                url: "demo/demo2",
                defaults: new { controller = "Jeter", action = "Index" }
            );

            //這個不行
            //routes.MapRoute(
            //    name: "demo",
            //    url: "demo/{id}",
            //    defaults: new { controller = "Jeter", action = "Index", id = UrlParameter.Optional }
            //);

            //這個可以
            //routes.MapRoute(
            //    name: "Jeter_id",
            //    url: "Jeter",
            //    defaults: new { controller = "Jeter", action = "Index" }
            //);

            //routes.MapRoute(
            //    name: "Jeter",
            //    url: "Jeter/{controller}/{action}",
            //    defaults: new { controller = "Jeter", action = "Index" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
