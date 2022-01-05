Angular is a javaascript binding framework which binds the HTML UI and javascript model.

This helps to reduce effort on writing those lengthy lines of code for binding.


View <--> View Model <--> Model
 ^              ^          ^
 |              |          |

HTML          angular     object



Databinding:
- How data binds frm controller to view
- {{}} -Expression /interpolation binding eg,<td> {{cust.CustomerId}} </td>
- []- property binidng  eg <input [{ngModel}]="obj">
- () - Event binging,seding eg,(click)
-[()] - two way binding

Angular architecture:
 1)template - the html view of angular
 2)View/component - Binds the view and Model 
 3)Modules - Groups components logically
 4)Binding - Defines hoe view and components communicate
 5)Directives - Changes DOM behaviour
 6)Services - helps to share common logic across the project
 7)Dependecy Injection - helps to inject instance across constructor


 SPA
 - we load the page onces and dont reload the entire page again
 - Only based on user action part of the function reloads

 Routing
 -  routing has URL and component  mapping
 - 3 components
 		-collections of routes and compnonent
 		- define router outlet--> where component loads
 		- define routerlink and comp --> where links in thml page are loaded

what is lazy loading?
 - loading only when required
 - also called as ondemand loading
 - how it can be implemented is by seperating moudles and have loadchildren defines


 Differnce b/w ngserve vs ngBuild
  -  ngServe - builds the applicaiton inmemory
  - ng Builld - builds the applicaiton in Harddisk
  - ngbuild 
   -- is used to build in production,creates a folder dist and puts code 
   -- its builds in compressed code


   

