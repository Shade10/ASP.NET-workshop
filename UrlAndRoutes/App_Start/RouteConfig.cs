using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace UrlAndRoutes {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("MyRoute", myRoute);

            //routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });

            //routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            //routes.MapRoute("", "X{controller}/{action}");

            //the same as above in comment
            //routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });

            //routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "DefaultId" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            //routes.MapRoute("AddControllerRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new[] { "UrlAndRoutes.AdditionalControllers" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new[] { "UrlAndRoutes.Controllers" });

            //Route myRoute = routes.MapRoute("AddControllerRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new[] { "UrlAndRoutes.AdditionalControllers" });
            //myRoute.DataTokens["UseNameSpaceFallback"] = false;

            //routes.MapRoute("AddControllerRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new { controller = "^H.*" },
            //    new[] { "UrlAndRoutes.AdditionalControllers" });

            //routes.MapRoute("AddControllerRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new { controller = "^H.*", action = "^Index$|^About$" },
            //    new[] { "UrlAndRoutes.AdditionalControllers" });

            routes.MapRoute("AddControllerRoute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new {
                    controller = "^H.*",
                    action = "^Index$|^About$",
                    httpMethod = new HttpMethodConstraint("GET"),
                    id = new CompoundRouteConstraint(new IRouteConstraint[]
                    {
                        new AlphaRouteConstraint(), 
                        new MinLengthRouteConstraint(6), 
                    })
                },
                new[] { "UrlAndRoutes.AdditionalControllers" });
        }   
    }
}
