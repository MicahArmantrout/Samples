using System.Web.Mvc;
using HelloWorld3.Models;

namespace HelloWorld3.Controllers
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

            // Instantiate a model to be associated with our view
            var model = new MyFirstModel {SomeValue = "I am here!"};

            // Display the view (Home/Index)
            // Pass the model to the view as a parameter in the View method call
            return View(model);
        }

        // Another action corresponding to another view on this controller
        // Note that MyObjectValue takes its value from the URL querystring parameter of the same name.
        public ActionResult Linked(string MyObjectValue)
        {
            // This view also has an associated model
            var model = new MySecondModel {MyValue = MyObjectValue};
            return View(model);
        }
    }
}