using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VideoStoreRedux
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //     "Show", // Route name
            //     "{controller}/{id}", // URL with parameters
            //     new { action = "Show", id = @"\d+" }, // Parameter defaults
            //     new { httpMethod = new HttpMethodConstraint("GET") }
            //);

            //routes.MapRoute(
            //     "Create", // Route name
            //     "{controller}/{id}", // URL with parameters
            //     new { action = "Create", id = @"\d+" }, // Parameter defaults
            //     new { httpMethod = new HttpMethodConstraint("POST") }
            //);

            //routes.MapRoute(
            //     "Update", // Route name
            //     "{controller}/{id}", // URL with parameters
            //     new { action = "Update", id = @"\d+" }, // Parameter defaults
            //     new { httpMethod = new HttpMethodConstraint("PUT") }
            //);

            //routes.MapRoute(
            //     "Destroy", // Route name
            //     "{controller}/{id}", // URL with parameters
            //     new { action = "Destroy", id = @"\d+" }, // Parameter defaults
            //     new { httpMethod = new HttpMethodConstraint("DELETE") }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
