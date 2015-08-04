Motivated by the issues described by this stackoverflow question:

http://stackoverflow.com/questions/31737223/using-razor-without-mvc-in-vs-2013-and-2015

...this project is intended to be a very simple Razor MVC app to illustrate the main elements which make it a Razor MVC app,
and provide hints for constructing, deconstructing, or extending this or other Razor MVC apps.

FWIW: Razor = syntax and associated rendering engine which allows for embedded C#/HTML (hence the .cshtml file extension).

Simply running each project should launch a browser on localhost:nnnn
 where nnnn is the port number for the project

HelloWorld is the simplest possible working MVC project (just a controller and a view) and demonstrates the ViewBag

HelloWorld2 introduces models, a second view on the same controller, and a simple way to construct a link between the views

HelloWorld3 adds a second controller and a couple of variations on linking

HelloWorld4 demonstrates a simple form posting

NOTES:

All of the projects in this solution were created in Visual Studio 2013 using the "Empty" ASP.NET MVC 4 Web Application template

i.e. in the "Add New Project" wizard, choose "ASP.NET MVC 4 Web Application",
     then choose "Empty", and make sure the view engine is set to "Razor".

When adding views, make sure they are in the Views folder, in subfolders named for the corresponding controller

Some extraneous files were removed from App_Start, as well as corresponding actions in the Application_Start (Global.asax.cs)
