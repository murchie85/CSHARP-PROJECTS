# C# & .NET BASICS

![C# IMAGE](https://static.gunnarpeipman.com/wp-content/uploads/2009/10/csharp-featured.png)

1. [SETUP](#SETUP)
2. [VS CODE](#VS-CODE)
3. [KEYS CONVENTION AND SYNTAX](#KEYS-CONVENTION-AND-SYNTAX)
4. [METHODS](#METHODS)
5. [TERMINAL COMMANDS](#TERMINAL-COMMANDS)
6. [LINKS](#LINKS)
7. [.NET FUNDAMENTALS](#.NET-FUNDAMENTALS)

# SETUP  

![summary](image/summary.png)
  
- Install VSCode or VS 
- Download .NET	Core SDK [SDK](https://www.microsoft.com/net/download)
- Install c# package --> view --> extensions
- Install C# XML Documentation, C# Extensions, REST Client, ILSpy .NET Decompiler and SharpPad
  
## C# Role Requirements
  
- IB ‘Risk, Finance and Treasury’    
- Code review     
- C#, .NET Framework & .NET Core, Visual Studios 2019, XML,XSLT  [link1](https://hackr.io/blog/c-sharp-interview-questions) , [link2](https://www.guru99.com/c-sharp-interview-questions.html), [link3](https://en.wikipedia.org/wiki/ASP.NET)
- [ASP.Net MVC](https://www.youtube.com/watch?v=phyV-OQNeRM)
- Multi-threaded server side development  
- Microservice / Service oriented architecture  
- Unit and integration testing  
- [SOLID](https://scotch.io/bar-talk/s-o-l-i-d-the-first-five-principles-of-object-oriented-design) design principles
- Team City  
- SQL Server , PostgreSQL, Middleware (MQ, Solace), Elasticsearch, AWS  
- Test Coverage   
- Distributed Systems Dataynase, NServiceBus. Messaging - Solace, RabbitMQ, Kafka  

## 10 BEST PRACTICES  

### Name things carefully 
  
Solution name should be different from project (even although its defaulted that way).   
Use pascal case (caps for every letter)  
Name class Libraries with the affix `library` at the end.  
So when you go to `add reference` in references, you know which one it is.


### One class per file   
**Add** A new class file for each class (don't have 2 or more in teh one file )  
Delete class1 that is autocreated when making a library.   

### Use Properties Not Public Variables  

Correct way is to declare the var in a class, then in main construct the object of that class and instantiate it like below.

```
*** person.cs class ***
// declaring the person class
public class person
{
  public string FirstName {get; set;}

}

*** program.cs class ***
// referencing the person
static void Main(string[] args){

	person firstUser = new Person();	// construct
	firstUser.FirstName = "Tim";        // Instantiate
}

```

**WRONG** WAY 

```
*** person.cs class ***
// declaring the person class
public class person
{
  public string FirstName {get; set;}
  public string LastName; // public variable (bad idea)

}

*** program.cs class ***
// referencing the person
static void Main(string[] args){

	person firstUser = new Person();	// construct
	firstUser.FirstName = "Tim";        // Instantiate

	firstUser.LastName = "Corey";      //Still works this way but NOT A GOOD PRACTICE 
}

```

### Methods should do One thing! 




## LINKS & NOTES 

[Practice online at ](https://dotnetfiddle.net/ )   
[FAQ](https://github.com/dotnet/standard/blob/master/docs/faq.md)   
[NET Core Command-Line Interface (CLI) tool](https://aka.ms/dotnet-cli-docs)  

**UWP APPS** Universal Windows Platfrom   
XCODE required to run on MAC.

## VS CODE 
  
VS is Windows and slower
VS Code is Open Source but bigger   
  
VS Code creates a bunch of utilities such as `references` existing libraries. `program.cs` the c# you can write your code. `App.config` includes version info.  


- Desktop Windows App : select WPF App .NET framework (Windows forms is old way)  
- Web App : select ASP.NET   
- Text only: Console App  
 


**Tips**   

In VS Code type ctl & backtick to open command pallet.  
Go to Definition: F12   
Type `prop` to create a method/class definition. 
  

`
Good Practice: When you try to use Go To Definition you will sometimes see an error saying, No definition found. This is because the C# extension does not know about the current project. Navigate to View | Command Palette, enter and select OmniSharp: Select Project, and then select the correct project that you want to work with.`  

## KEYS CONVENTION AND SYNTAX

![KEY SHORTCUTS](image/keys.png)  
  
| Naming convention	   |      Examples      |  Use for |
|----------|:-------------:|------:|
| Camel case |  cost, orderDetail, dateOfBirth | Local variables, private fields. |
| Title case |    String, Int32, Cost, DateOfBirth, Run  |   Types, non-private fields, and other members like methods.|

## Comments

`//` Single line comments.  
`/* .....*/` Multi-line comments.  
`///` XML comments, notice in the image below, the popup text includes details from the comments section.   

![comments](image/comments.png)

## Variables 
  
- Variabels declared inside a block stay there:: but variables amended inside and global will be amended outside 
- Use block brackets for all loops  
  

### Assigning Null   
  
To assign null, you need to add question mark or it will fail to compile.   
  
`int? eggs = null;`  
  

### Escape Characters

#### Space  

`string fullNameWithTabSeparator = "Bob\tSmith";`  becomes `Bob Smith`

#### Verbatim String (Ignore Escape char)
  
use the `@` symbol before the string.  

`string filePath = @"C:\televisions\sony\bravia.txt";`

#### Interpolated string 
  
A literal string prefixed with $ to enable embedded formatted variables. You will learn more about this later in this chapter.

### NUMBERS 

```
// unsigned integer means positive whole number

// including 0

uint naturalNumber = 23;

// integer means negative or positive whole number

// including 0

int integerNumber = -23;

// float means single-precision floating point

// F suffix makes it a float literal

float realNumber = 2.3F;

// double means double-precision floating point

double anotherRealNumber = 2.3; // double literal
```

### BINARY & HEX

Start a number with `0b` for binary and `0x` for hex.


```
// three variables that store the number 2 million

int decimalNotation = 2_000_000;

int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;

int hexadecimalNotation = 0x_001E_8480;
```
  
**Boolean compare**  
  
```
Console.WriteLine($"{decimalNotation == binaryNotation}");
```
  
### Operands 
 
#### INT VS DOUBLE   

``` 
int x =1;
int y =1;
int sum;

sum = x + y; // evaluates to 2
```

```

double double1 = 5.0/2.0; Evaluates to 2.5
double double2 = 5 / 2; Evaluates to 2

```

#### MODULUS 

`%`

#### INCREMENT AND DECREMENT 

```
int y =1; 
int x = ++y; // y is incremented to 2, x is set to 2. So X =2 and Y =2 
  
int y =1; 
int x = y++; // x is set to 1, y is incremented to 2. So X = 1 and Y = 2
```

### Datatype conversion 
**IMPLICIT vs EXPLICIT**  
```
int myinteger = 765;
double mydouble = 7.2; 

mydouble=myinteger; //Implicit (765.0)
myInteger= (int)mydouble; //Explicit and if was 7.0 you would drop the 0 maybe.
```  
   
### Convert string to int
string mystring = "5";
myInteger = Convert.ToInt32(mystring);
   



## FLOW CONTROL

### BOOL 
  
`bool answer; // true or false`
  

```
// all evaluates to true 
answer = (1 == 1);
answer = (1 != 2); 
answer = !(false);  

answer = (true && true)

```

### DECISION STATEMENTS  

Always use block statements in loop.   
 	
### IF STATEMENT 
```
int age = 20;

if (age>=18)
{
	Console.WriteLine("You are old enough to vote");
}
else if (Age>=21)
{
	Console.WriteLine("You are old enough to buy alcohol")
}
else
{
	Console.WriteLine("You are not allowed to vote");
}
```
  
### SWITCH STATEMENT 

```

switch(variable)
{
	case value:
		// do this 
		break;
	case value:
		// do this 
		break;
	default:
		// do this 
		break;
}




```
    
### WHILE STATEMENT 
  
```
int i = 3;

while(i<3)
{
	Console.WriteLine(i);
	i++; 
}

```

### DO WHILE STATEMENT 
  
Same as while, but condition is tested at the end. 

```

int i =1;
do{
	Console.WriteLine(i);
	i++;
}
while(i<=3);

```

### FOR LOOP
  
More compact format.    

```

for (initialise var; expression; update var)
{
	// do this 
}

for (int i =1; i<=3; i++)
{
	Console.WriteLine(i)
}
```


```

for (int i =1; i<=3; i++)
{
	if(i==2)
	{
		continue; // will skip i=2 
	}
	Console.WriteLine(i);
}

```
## METHODS
   
  
A nice way to call programs/blocks of code from within a current program.    
To write our own custom methods, they need to be outside main method code block but inside the program class.  
The method can be referred to in multiple parts through the program, but only changed in one place.  
    
```
// return type can be int, string etc. For no return type it must be void  

returntype name(parameters)
{
	do this
}

```


```

static void Main(string[] args)
{
	Console.WriteLine('You are doing well!');
	printCongrats();
}
static void printCongrats()
{
	Console.WriteLine('Congratulations')
}


```

### RETURN DATA IN STRING   
  
```
static void Main(string[] args)
{

	Console.WriteLine("You are doing so well!");
	Console.WriteLine(returnCongrats());
}
static string returnCongrats()
{
	return "Congratulations!"
}

```
  

```
static void Main(string[] args)
{

	int result;

	result = NumberSquared(4)
	Console.WriteLine("The number squred is");
	Console.WriteLine(result);
}
static int NumberSquared(int x)
{
	return x * x;
}

```

### OPTIONAL PARAMETERS 
  
by making a parameter `int power =2` we have assigned it, so its optional.  
Optional parms must come at the end . 
  
```

static void Main(string[] args)
{
	Console.WriteLine(RaiseToPower(2));  // 2^2 = 4
	Console.WriteLine(RaiseToPower(2,3)) // 2^3 = 8 
}

static int RaiseToPower(int baseNumber, int power =2)
{
	int result =1;

	for (int i =1; i<= power; i++)
	{
		result *= basenumber;
	}

	return result;
}


``` 
  
### REFERENCE VARIABLE (Pointers?)
  
If you pass a variable into a method and change that variable within the method, only the method var changes. 


```

static void Main(string[] args)
{
	int x = 5;

	ChangeNumber(x)

	Console.WriteLine(x); // output remains 5
}

static int ChangeNumber(int y)
{
	y = 0;
}


``` 
  
To change the variable outside you need to use ref prior to the number    
This way allows you to return multiple values from a method. 
Because there is only one return, you can return multiple values by using multiple `ref parameters` 
If you dont want to initialise the variable, use the `out` term instead of `ref`  
  

```

static void Main(string[] args)
{
	int x = 5;

	ChangeNumber(ref x)

	Console.WriteLine(x); // output remains 5
}

static int ChangeNumber(ref int y)
{
	y = 0;
}


``` 


### METHOD OVERLOADING 
  
Declaring more than one method with `the same name` inside `the same scope`. The requirement is that they can't have `the same name and combination of parameters`    
The compiler knowns which one to call based on the arguments you pass in.   
`Console.WriteLine()` is actually a bunch of overloaded methods, i.e. write method for an int, a write method for a string and so on. All the same name.      

![OVERLOADING](image/overloading.png)


### USEFUL METHODS

**Console.ReadKey()**     

`Console.ReadKey()`
  
Read in single character from user.   

```
char userinput; // only one key allowed
Console.Write("Enter a character: ");
userInput = Console.ReadKey().KeyChar;

Console.WriteLine();
Console.WriteLine("You entered: " + userInput);
```
  
  
**Console.ReadLine()**
  
Same as above, but use `string` instead of `char` and `ReadLine()` method. 

**Console.WriteLine()** 


**SIZE OFF**   
  
Run in console   
`Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");`  
  
`Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");`  
  
  
*NOTE A DOUBLE CAN STORE BIGGER NUMBERS THAN A DECIMAL BUT MAY NOT BE ACCURATE BECAUSE SOME NUMBERS CAN NOT BE REPRESENTED AS A FLOATING POINT VALUE*  

  



## TERMINAL COMMANDS
  
In terminal run the following:  

### Generate Console Application components  

`dotnet new console`  
  
### Compile & Run  

`dotnet run`
  
### Documentation  

`dotnet help new`
  
or get help for command line argument 
  
`dotnet new console -h`






### PDF LINKS 

- [Windows:](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf)
- [macOS:](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf)
- [Linux:](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-linux.pdf)

















# .NET FUNDAMENTALS
  
For Developers to build applications. Originally optimised for windows.  
.NET **is core to windows operating system** and installed on over one billion computers, this is why it must change as little as possible. So bugfixes and updates are infrequent. 

## Good Practice

Practically speaking, .NET Framework is Windows-only and a legacy platform. **Do not create new apps using it**  


### Three main .NET framworks 
  
- .NET Core
- .NET Framework
- .NET Standard 
  
Includes : 

1. Common Language Runtime (CLR), manages code execution
2. Base Class Library (BCL)

- Mono and Xamarin projects are community/open source Xamarin bought over. 
```
.NET Core: for cross-platform and new apps.
.NET Framework: for legacy apps.
Xamarin: for mobile apps.
```  

## .NET core 

.NET Core includes a cross-platform implementation of the CLR known as CoreCLR and a streamlined library of classes known as CoreFX.  
Fast moving, lots of changes; 'does not affect application stability' as it can be deployed side by side with an App.  
Is getting smaller as non essential (windows only stuff) gets removed .
 
## Future of .NET  
  
.NET Core 3.0 will be renamed to .NET and skip version 4 not to be confused with NET Framework 4.x. So, the next version of .NET Core will be .NET 5.0 and it is scheduled for release in November 2020.   
After that releases will be annually.    
UWP will be on custom .NET core as its not cross platform.   
 
**ASP.NET Web Forms** and **Windows Communication Foundation (WCF)** are old web application and service technologies that fewer developers are choosing to use for new development projects today, so they have also been removed from .NET Core. Instead, developers prefer to use ASP.NET MVC and ASP.NET Web API. These two technologies have been refactored and combined into a new product that runs on .NET Core, named **ASP.NET Core**.  
  
```
By the end of 2020, Microsoft promises that there will be a single .NET platform instead of three. 
```

## .NET STANDARD 

. NET Standard solves the code sharing problem for . NET developers across all platforms by bringing all the APIs that you expect and love across the environments that you need: desktop applications, mobile apps & games, and cloud services.  

. NET Standard is a formal specification of . NET APIs that are intended to be available on all . NET implementations.  

To use the .NET Standard, you must install a .NET platform that implements the .NET Standard specification. .NET Standard 2.0 is implemented by the latest versions of .NET Framework, .NET Core, and Xamarin.
  
The latest .NET Standard, 2.1, is only implemented by .NET Core 3.0, Mono, and Xamarin. Some features of C# 8.0 require .NET Standard 2.1. .NET Standard 2.1 is not implemented by .NET Framework 4.8 so we should treat .NET Framework as legacy.

## C# Intermediate Langauge (IL)
  
- C# Compilire is called **Roslyn** 
- Used by the .net CLI tool converts it into **IL** code and stores the IL in an assembly (a **DLL** or **EXE file**). 
- .NET Core's virtual machine, known as  **CoreCLR** exeutes IL code DLL/EXE
  
## JUST IN TIME COMPILATION 

At runtime,  **CoreCLR loads the IL code** from the assembly, the just-in-time (JIT) compiler compiles it into native CPU instructions, and then it is executed by the CPU on your machine. The benefit of this three-step compilation process is that Microsoft is able to create CLRs for Linux and macOS, as well as for Windows. The same IL code runs everywhere because of the second compilation process, which generates code for the native operating system and CPU instruction set.

## Understanding .NET Native 

Another .NET initiative is called .NET Native. This compiles C# code to native CPU instructions ahead of time (AoT), rather than using the CLR to compile IL code JIT to native code later. .NET Native improves execution speed and reduces the memory footprint for applications because the native code is generated at build time and then deployed instead of the IL code. 
  
### JIT VS NATIVE 

JIT:   
1. Compile to Exe/Dll
2. CoreCLR Loads
3. JIT Compiles to Native 
4. Executes 

NATIVE :  
1. Compiles direct to native 
2. Executes at run on mac/linux whatever