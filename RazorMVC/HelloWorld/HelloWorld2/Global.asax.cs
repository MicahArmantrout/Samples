using System.Web;
using System.Web.Routing;

namespace HelloWorld2
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : HttpApplication
    {
        // This gets called when the application is loaded
        protected void Application_Start()
        {
            // Register controller routes
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}