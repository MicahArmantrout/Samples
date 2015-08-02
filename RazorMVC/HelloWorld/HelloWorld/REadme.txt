This project is designed to be the simplest possible working implementation of an MVC Razor web application.

It contains one view, and one controller, no styling or advanced features.
This project demonstrates the use of ViewBag as a way to pass information from the controller to the view.
Although ViewBag gets the job done for small, simple pieces of information, models are better (see HelloWorld2).

Simply running this project should launch a browser on localhost:nnnn
 where nnnn is the port number for the project

The Hello World page should appear in the browser.

The Hello World page derives its HTML from Views/Home/Index.cshtml, and is associated with the Index method of HomeController.

NOTES:

Controllers are added by right-clicking on the Controllers folder in the Solution Explorer, and choosing Add -> Controller

To add a view:
1.  Add a folder under Views and give it the same name as the controller
2.  Right click on the folder and choose Add -> View
     Turn off all options for the simple case as shown here
