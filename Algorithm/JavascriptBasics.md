what is a program?
- It has to allocate memory
- It has to also parse and execure

Each browser has a Javascript Engine,In chrome we have v8 engine

Javasscript engine has 2 components 

1) memory heap
2) call stack

Javascript is a single threaded language that can be non blocking

Example:
//Below is memory heap

> const a=1;
> 
> const b=10;
> 
> const c=100;

//call stack

> console.log("this call stack1")
> 
> console.log("this call stack2")
> 
> console.log("this call stack3")



In order for javascript to run it needs javascript run-time environment
- on top of this we have webAPI,Callback queue and Event Loop avaiable from browsers

Example

//call stack
>console.log("this call stack1")

//web API(DOM(document),Ajax(xmlhttpReques),Timeout(setTimeout))
//call back queue(onclick,OnLoad,onDone)
//Event Loop


Javascript is asynchornous

> 
> element.addEventListner('click',()=>{
> 
>	console.log('click')
>	
> })
