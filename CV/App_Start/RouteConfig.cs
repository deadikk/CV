using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CV
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            "lang",
            "{lang}",
            new { controller = "Home", action = "Index", lang = "ru" }
            );

            routes.MapRoute(
            "NotFound",
            "{*url}",
            new { controller = "Home", action = "Index", lang = "ru" }
            );
        }
    }
}
