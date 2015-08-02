using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    // A controller we chose to name 'Home'.
    // Note that the routing registered in App_Start/RouteConfig.cs identifies "Home" (this controller) as the default.
    public class HomeController : Controller
    {
        // An action method we chose to name "Index".
        // Note that the routing registered in App_Start/RouteConfig.cs identifies "Index" (this action) as the default.
        // By virtue of the defaults in the registered routing, http://localhost:51706 will invoke this action method.
        public ActionResult Index()
        {
            // Example of passing a piece of data from the controller action to the associated view
            ViewBag.Data = "World!";

            // Display the view (Home/Index)
            return View();
        }
    }
}
