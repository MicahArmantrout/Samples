using HelloWorld3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld3.Controllers
{
    public class AnotherController : Controller
    {
        // Another controller, just to fill out the example
        // Note that because the routing names Index as a default,
        // We can use a URL that only names the controller
        //  i.e. http://localhost:51706/Another
        public ActionResult Index(string MyObjectValue)
        {
            var obj = new MySecondModel { MyValue = MyObjectValue };
            return View(obj);
        }
    }
}
