This project is intended to be a very simple Razor MVC app to illustrate the main elements which make it a Razor MVC app,
and provide hints for constructing, deconstructing, or extending this or other Razor MVC apps.

FWIW: Razor = syntax and associated rendering engine which allows for embedded C#/HTML (hence the .cshtml file extension).

Simply running the project should launch a browser on localhost:51706
 (or whatever the project URL is set for in the project's Web properties page)

The Hello World page should appear in the browser.

The Hello World page derives its HTML from Views/Home/Index.cshtml, and is associated with the Index method of HomeController.

This project contains numerous NuGet and other references, some of which are likely unnecessary (to be cleaned out)
