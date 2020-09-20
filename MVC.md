MVC

Page Lifecycle- https://stackoverflow.com/questions/24690896/what-is-the-difference-between-asp-net-page-life-cycle-and-asp-net-mvc-page-life/24691083

caching
-Page caching
-Data caching
-Fragment caching


Garbage collector- Garbage collector feature in .NET frees the unused code objects in the memory. The memory head is divided into 3 generations:
    Generation 0: It stores short-lived objects.
    Generation 1: This is for medium-lived objects.
    Generation 2: It stores long-lived objects.


MVC application life cycle?
 
 
Any web application has two main execution steps, first understanding the request and depending on the type of the request sending 
out an appropriate response. MVC application life cycle is not different it has two main phases, 
first creating the request object and second sending our response to the browser.
 
Creating the request object,
 
The request object creation has four major steps. The following is a detailed explanation of the same.
 
Step 1 - Fill route:MVC requests are mapped to route tables which in turn specify which controller and action to be invoked. 
So if the request is the first request the first thing is to fill the rout table with routes collection. 
This filling of the route table happens the global.asax file.
 
Step 2 - Fetch route :Depending on the URL sent “UrlRoutingModule” searches the route table to create “RouteData” object 
which has the details of which controller and action to invoke.
 
Step 3 - Request context created: 
The “RouteData” object is used to create the “RequestContext” object.
 
Step 4 - Controller instance created : 
This request object is sent to “MvcHandler” instance to create the controller class instance. Once the controller class object is created it calls the “Execute” method of the controller class.
 
Creating a Response object
 
This phase has two steps executing the action and finally sending the response as a result to the view.