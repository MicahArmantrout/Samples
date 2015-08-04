using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using HelloWorld4.Models;

namespace HelloWorld4.Controllers
{
    public class HomeController : Controller
    {
        // We have a "Get" method (similar to other examples) to support page navigation to our form...
        [HttpGet]
        public ActionResult Index()
        {
            // We can initialize our form via the associated model
            var myData = new MyFormData {SomeValue = "3"};
            return View(myData);
        }

        // We add a "Post" method; form submit will post back to our form page, so will invoke this method
        // The model as parameter is how we recover the form data
        [HttpPost]
        public ActionResult Index(MyFormData myData)
        {
            // We do (or initiate) our form data processing here
            // We can get the framework to do data validation for us, but that's beyond the scope of this example.
            Debug.WriteLine("Name = {0}, IsTrue = {1}, SomeValue = {2}", myData.Name, myData.IsTrue, myData.SomeValue);

            // Done... we choose to redirect to a new page.
            // In this example, we redirect back to ourself. This will call the Get method for our page (will have the appearance of resetting the form).
            var path = VirtualPathUtility.ToAbsolute("~/");
            return Redirect(path);
        }
    }
}