﻿using System;
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
            new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
            "Admin",
            "{controller}/{action}",
            new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
            "NotFound",
            "{*url}",
            new { controller = "Home", action = "Index" }
            );
        }
    }
}
