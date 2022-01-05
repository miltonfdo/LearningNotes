### Dot Net Interview Question

Notes from Shiv prasad 

Question 1 :- Explain difference between .NET and C# ?
Question 2 :- .NET Framework vs .NET Core vs .NET 5.0
Question 3 :- What is IL ( Intermediate Language) Code ?
Question 4 :- What is the use of JIT ( Just in time compiler) ?
Question 5 :- Is it possible to view IL code ?
Question 6 :- What is the benefit of compiling in to IL code ?
Question 7 :- Does .NET support multiple programming languages ?
Question 8 :- What is CLR ( Common Language Runtime) ?

-CLR invokes JIT to compile to IL code
-cleans any unused objects by using GC

Question 9 :- What is managed and unmanaged code ?
- Code which does not run under .Net CLR are unmanaged code


Question 10 :- Explain the importance of Garbage collector ?

- Garbage collector is a background process which clears unused resources from manged code Resources 

Question 11 :- Can garbage collector claim unmanaged objects ?

NO

Question 12 :- What is the importance of CTS ?
- Common Type system

Question 13 :- Explain CLS ?

set of guidlines or rules

Question 14 :- Difference between Stack vs Heap ?

Stack and heap are memory type in dotnet

Stack supports primitive datatypes like int, boolean.. its FIFO

Heap stores objects ,pointers point to values.also called as refrence type

Question 15 :- What are Value types & Reference types?

Reference type is on heap 
value type is on stack

Question 16 :- Explain boxing and unboxing ?

Value type to reference is boxing

int i=10
object y=i

Reference type to value type is unboxing
int u = y 


Question 17 :- What is consequence of boxing and unboxing ?

its performance , moving from stack to heap or ther way

Question 18 :- Explain casting, implicit casting and explicit casting ?

if we dont want to do anything from lower datatype to higher data type implicit casting would happend automatically

<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104191548288.png" alt="image-20220104191548288" style="zoom:50%;" />



Explicit casting we have to mention the cast type and wont happen automatically happen,whioch owuld be from higher to lower. And possibility of data loss



Question 19 :- What can happen during explicit casting ?

Data loss when move data from higher to lower datatype eg,decimal to int we would loose decimal places

Question 20 :- Differentiate between Array and ArrayList ?

Array are fixed size and  fixed length but u can modify using Array.Resize method



<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104192106194.png" alt="image-20220104192106194" style="zoom:50%;" />

Question 21 :- Whose performance is better array or arraylist ?

Comparatively arrayList has less performance as it would involve boxing and unboxing when different datatypes are added

Question 22 :- What are generic collections ?

-Takes all good things of arrays and arraylist meaning strongly typed and also flexible on size

<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104192410440.png" alt="image-20220104192410440" style="zoom:50%;" />



Question 23 :- What are threads (Multithreading)?

- Helps to run code parallely
- <img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104192605763.png" alt="image-20220104192605763" style="zoom:50%;" />

Question 24 :- How are threads different from TPL ?

Task does parallel processing ,uses all resources,Thread would have process affinity will not utilize all resources by default and would need lot of code to do it



<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104192732007.png" alt="image-20220104192732007" style="zoom:50%;" />

<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104192832055.png" alt="image-20220104192832055" style="zoom:50%;" />



<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104193011978.png" alt="image-20220104193011978" style="zoom:50%;" />



Question 25 :- How do we handle exceptions in C#(try/catch)?



<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104193231727.png" alt="image-20220104193231727" style="zoom:50%;" />

Question 26 :- What is the need of finally?

Finally would always run irespective of exception

Question 27 :- Why do we need the out keyword ?

if we want return multiple return values from an function then we canse use out keyword

<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104193604220.png" alt="image-20220104193604220" style="zoom:50%;" />

Question 28 :- What is the need of Delegates ?

Delegate is a pointer to  a function and very useful as callbacks to communicate between threads

Question 29 :- What are events ?

Events are wrapper/encapsulation over delegates

Question 30 :- What's the difference between Abstract class and interface ?

Abstract is a half defined parent class while interface is a contract

Question 31  :- What is a delegate and How to create a delegate ?
Question 32  :- Where have you used delegates ?
Question 33  :- What is a Multicast delegates ?
Question 34  :- What is a Event ?
Question 35  :- How to create a event ?
Question 36  :- Delegate vs Events.
Question 37 :- Why do we need OOP ?
It forces developers to think in terms of real world
Question 38 :- What are the important pillars of OOPs ?
(A PIE)
Abstraction 
Polymorphishm
Inheritance
Encapsulation

Question 39 :- What is a class and object ?

Class is a type,Blue print 
Object is an instance of class

Question 40 :- Abstraction vs Encapsulation?

Abstraction - show only whats necessary,And happens during design phase
Encapsulation - is hiding complexity,Happens during execution (in a more simpler manner abstraction happens during encapsulation)

<img src="C:\MIlton\Repo\Githib\learning\Learning\interview questions\images\image-20220104214450962.png" alt="image-20220104214450962" style="zoom:50%;" />

Question 41 :- Explain Inheritance ?

Inheritance defines parent child relationship

Question 42 :- Explain virtual keyword ?



Question 43 :- What is overriding ?
Question 44 :- Explain overloading ?
Question 45 :- Overloading vs Overriding ?
Question 44 :- What is polymorphism ?
Question 45 :- Can polymorphism work with out inheritance ?
Question 46 :- Explain static vs dynamic polymorphism ?
Question 47 :- Explain operator overloading ?
Question 48  :- Why do we need Abstract classes ?
Question 49  :- Are Abstract methods virtual ?
Question 50  :- Can we create a instance of Abstract classes ?
Question 51  :- Is it compulsory to implement Abstract methods ?
Question 52  :- Why simple base class replace Abstract class ?
Question 53  :- Explain interfaces and why do we need it ?
Question 54  :- Can we write logic in interface ?
Question 55  :- Can we define methods as private in interface ?
Question 56  :- If i want to change interface what's the best practice ?
Question 57  :- Explain Multiple inheritance in Interface ?
Question 58  :- Explain Interface Segregation principle ?
Question 59  :- Can we create instance of interface ?
Question 60  :- Can we do Multiple inheritance with Abstract classes ?
Question 61 :- Difference between Abstract Class & Interfaces?
Question 62  :- Why do we need constructors ?
Question 63  :- In parent child which constructor fires first ?
Question 64  :- How are initializers executed ?
Question 65  :- How are static constructors executed in Parent child ?
Question 66  :- When does static constructor fires ?
Question 70 :- What is Shadowing?
Question 71 :- Explain method hiding?
Question 72 :- Shadowing vs Overriding ?
Question 73 :- When do we need Shadowing ?
Question 74 :- Explain Sealed Classes ?
Question 75 :- Can we create instance of sealed classes ?
Question 76 :- What are nested classes and when to use them ?
Question 77 :- Can Nested class access outer class variables ?
Question 78 :- Can we have public, protected access modifiers in nested class ?
Question 79 :- Explain Partial classes ?
Question 80 :- In What scenarios do we use partial classes ?