using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWorld
{
    public class RouteConfig
    {
        // Register controller routes...
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                // TODO: Understand what this is for and whether it is needed for our sample app

            // Set up a routing with a default
            routes.MapRoute("Default", // name is just a name; must be unique over all routes.MapRoute calls
                "{controller}/{action}/{id}", // Route pattern
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}

                // NOTE: the above defaults are responsible for a simple URL like "http://localhost:51706"
                // taking effect as "http://localhost:51706/Home/Index", which is what gives us Hello World
                );
        }
    }
}