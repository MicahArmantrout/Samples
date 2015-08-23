using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exceptions.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// The home page for our sample site
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// A second page on our site which throws an exception
        /// </summary>
        /// <returns></returns>
        public ActionResult Page2()
        {
            // Demonstrate the exception handling process by throwing an exception in response to a request for this page
            throw new Exception("A demonstration exception");
        }

    }
}
