﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Exceptions
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            // See http://stackoverflow.com/questions/13905164/how-to-make-custom-error-pages-work-in-asp-net-mvc-4
            // for additional context on use of this technique

            var exception = Server.GetLastError();
            if (exception != null)
            {
                // This would be a good place to log any relevant details about the exception.
                // Since we are going to pass exception information to our error page via querystring,
                // it will only be practical to issue a short message. Further detail would have to be logged somewhere.

                // This will invoke our error page, passing the exception message via querystring parameter
                // Note that we chose to use Server.TransferRequest, which is only supported in IIS 7 and above.
                // As an alternative, Response.Redirect could be used instead.
                // Server.Transfer does not work (see https://support.microsoft.com/en-us/kb/320439 )
                Server.TransferRequest("~/Error?Message=" + exception.Message);
            }

            // TODO: Investigate the following:

            //try
            //{
            //    // This is to stop a problem where we were seeing "gibberish" in the
            //    // chrome and firefox browsers
            //    HttpApplication app = sender as HttpApplication;
            //    app.Response.Filter = null;
            //}
            //catch
            //{
            //}
        }
    }
}