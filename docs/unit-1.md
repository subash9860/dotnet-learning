## Language Preliminaries

## Index

- [Introduction to .Net framework](#intro),
- [ Compilation and execution of .Net applications](#comp),
- [Basic Languages constructs](#basic),
- [Constructor](#constructor)
- [Properties](#properties),
- [Indexers](#indexers),
- [Inheritance](#inheritance),
- [use of “base” keyword](#base),
- [Method hiding and overriding](#overriding),
- [applying polymorphism in code extensibility](#ploymorphism),
- [structs and enums](#structs-enums),
- [abstract class sealed class and interface](#abstract-sealed-interface),
- [Delegate and Events](#delegate-events),
- [Partial class](#partial-class),
- [Collections](#collections),
- [Generics](#generics),
- [File IO](#file-io),
- [LINQ (Language Integrated Query)](#linq)
- [Fundamentals: Lambda Expressions, Try statements and Exceptions, Attributes: Attribute Classes, Named and Positional Attribute Parameters, Attribute Targets, Specifying Multiple Attributes](#fundamentals),
- [Asynchronous Programming: Principle of Asynchrony, Async/Await patterns in C#](#asyn)

### <a id="intro"></a> Introduction to .Net framework

The .NET Framework is a software development platform developed by Microsoft. It provides a comprehensive and consistent programming model for building applications that can run on different platforms and devices. The framework includes a large library of pre-built code and tools that developers can use to create a wide range of applications, from web and desktop applications to mobile and gaming applications.

The .NET Framework consists of several components:

1. Common Language Runtime (CLR): The CLR is the execution engine of the .NET Framework. It provides features such as memory management, exception handling, and security. The CLR also enables interoperability between different programming languages supported by the framework, allowing developers to write code in languages like C#, Visual Basic, F#, and more.

2. Base Class Library (BCL): The BCL is a collection of reusable classes, types, and methods that provide common functionality to .NET applications. It includes classes for working with files, networking, databases, user interfaces, and more. The BCL simplifies application development by providing pre-built components that developers can leverage.

3. Language-Integrated Query (LINQ): LINQ is a powerful feature of the .NET Framework that enables developers to perform query operations directly within their code. It allows querying data from different data sources, such as databases, XML files, and in-memory collections, using a unified syntax. LINQ provides a consistent way to manipulate and retrieve data, regardless of the underlying data source.

4. ASP.NET: ASP.NET is a web development framework within the .NET Framework. It allows developers to build dynamic, data-driven websites and web applications. ASP.NET provides a model-view-controller (MVC) architecture, server controls, and a rich set of tools and libraries for web development.

5. Windows Presentation Foundation (WPF): WPF is a framework for building desktop applications with rich user interfaces. It provides a powerful and flexible way to create visually appealing applications that can leverage animations, multimedia, and advanced graphical capabilities.

6. Windows Communication Foundation (WCF): WCF is a framework for building service-oriented applications. It enables developers to create distributed systems that communicate over various protocols, such as HTTP, TCP, and MSMQ. WCF provides a unified programming model for building secure and reliable services.

7. Windows Workflow Foundation (WF): WF is a framework for building workflow-based applications. It allows developers to design, implement, and execute workflows, which represent a series of tasks or activities. WF provides tools and services for creating and managing workflows in applications.

The .NET Framework has evolved over time, and with the release of .NET Core, Microsoft introduced a cross-platform, open-source version of the framework called ".NET 5" (later renamed to ".NET 6"). It aims to unify the development experience across different platforms, including Windows, macOS, and Linux.

Overall, the .NET Framework provides developers with a powerful and flexible platform for building a wide range of applications, leveraging a rich set of libraries and tools to streamline the development process.

##  <a id="comp"></a> Compilation and execution of .Net applications

To compile and execute .NET applications, you can follow these general steps:

1. Install .NET SDK: Make sure you have the .NET SDK (Software Development Kit) installed on your system. You can download it from the official Microsoft website.

2. Create a new project: Use the `dotnet new` command to create a new .NET project. For example, to create a console application, you can run `dotnet new console`.

3. Write code: Open your preferred code editor and write the necessary code for your application. For a console application, you'll typically find a file named `Program.cs` where you can define your entry point.

4. Restore dependencies: Run `dotnet restore` command to restore the dependencies specified in your project file. This command will fetch the required packages from NuGet, the .NET package manager.

5. Build the project: Execute `dotnet build` command to build your application. It compiles the source code and generates the executable or DLL file.

6. Run the application: Use `dotnet run` command to run your application. It automatically compiles and executes your code. If you prefer to run the compiled executable directly, you can find it in the output directory (usually in the `bin` folder).

Additional options and parameters can be provided with the commands above. For instance, you can specify the target framework, output directory, etc., depending on your requirements.

Note that these steps assume you're working with the .NET Core or .NET 5+ versions. If you're working with the older .NET Framework, the process may differ slightly.

Once your application is built and executed, you should see the output in the console or any other appropriate output mechanism you have implemented in your code.

## <a id="basic"></a>  Basic Languages constructs

Certainly! Here are some additional basic language constructs commonly found in programming languages:

1. Constants: Constants are similar to variables but their values cannot be changed once assigned. They are often used to represent fixed values or settings in a program.

2. Control Flow:

   - Break and Continue: These keywords are used within loops to alter the control flow. 'Break' terminates the loop and continues with the next statement outside the loop, while 'Continue' skips the rest of the current iteration and moves to the next iteration.
   - Return: The 'return' statement is used in functions or methods to exit the current function and optionally return a value back to the caller.

3. Scope: Scope defines the visibility and accessibility of variables, functions, and other constructs within a program. Variables declared within a scope are typically only accessible within that scope or nested scopes.

4. Operators (continued):

   - Increment and Decrement: These operators (++ and --) are used to increase or decrease the value of a variable by 1.
   - Ternary Operator: The ternary operator (condition ? expression1 : expression2) provides a concise way to write conditional expressions.

5. Strings: Strings are used to represent sequences of characters. They often have associated operations for concatenation, comparison, and manipulation.

6. Input and Output (continued):

   - Formatted Output: Programming languages provide ways to format output, allowing you to control the appearance of values when displayed to the user. This can include specifying the number of decimal places, alignment, padding, etc.

7. Object-Oriented Programming (OOP) Constructs:
   - Classes and Objects: OOP languages allow the creation of classes, which are blueprint or templates for creating objects. Objects are instances of classes and encapsulate data and behavior.
   - Inheritance: Inheritance allows classes to inherit properties and methods from other classes, forming a hierarchical relationship. It enables code reuse and the creation of specialized classes.
   - Polymorphism: Polymorphism allows objects of different classes to be treated as objects of a common base class. It enables methods to be overridden in derived classes and invoked dynamically based on the object's actual type.

These additional constructs provide more flexibility and functionality to programs and are commonly found in various programming languages.

### <a id="constructor"></a> Constructs

A constructor is a special method within a class that is used to initialize objects of that class. It is called automatically when an object is created or instantiated. The purpose of a constructor is to ensure that the object is properly initialized and ready for use.

Here are some key points about constructors:

1. Naming: Constructors have the same name as the class they belong to. They do not have a return type, not even void.

2. Initialization: Constructors are responsible for initializing the member variables or properties of an object. They can set default values or accept parameters to initialize the object's state.

3. Multiple Constructors: A class can have multiple constructors with different parameter lists. This is known as constructor overloading. It allows objects to be created with different initializations based on the provided arguments.

4. Default Constructor: If a class does not explicitly define any constructors, a default constructor is automatically provided by the language. The default constructor has no parameters and performs default initialization.

5. Implicit and Explicit Invocation: Constructors are invoked implicitly when an object is created using the 'new' keyword. However, constructors can also be explicitly invoked within other constructors using the 'this' keyword to invoke another constructor in the same class, or the 'base' keyword to invoke a constructor in the base class.

6. Initialization Order: Constructors are executed in a specific order. If a class inherits from a base class, the base class constructor is executed first, followed by the derived class constructor. Within a class, constructors are executed based on the order in which they are invoked.

7. Use Cases: Constructors are commonly used to initialize member variables, set up dependencies, perform validation, and prepare the object for use. They can also be used to establish connections to databases or external resources.

Here's an example of a constructor in C#:

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor with parameters
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Default constructor
    public Person()
    {
        // Default initialization
        Name = "Unknown";
        Age = 0;
    }
}

// Creating objects using constructors
Person person1 = new Person("John", 25);
Person person2 = new Person();
```

In the example above, the `Person` class has two constructors. The first constructor takes parameters for name and age and initializes the object with the provided values. The second constructor is the default constructor that sets default values for name and age. Objects of the `Person` class can be created using either constructor based on the desired initialization.

### <a id="properties"></a> Properties

Properties are a programming language construct that allows you to define attributes or characteristics of an object or class. They provide a way to encapsulate data and control access to it, ensuring proper encapsulation and abstraction.

Here are some key points about properties:

1. Accessors: Properties typically have two accessors: a get accessor and a set accessor.
   - Get accessor: It retrieves the value of the property. It is used to read the property value.
   - Set accessor: It sets the value of the property. It is used to assign a new value to the property.

2. Syntax: Properties are defined using a combination of a get keyword and/or a set keyword, followed by a code block or expression that defines the logic for retrieving or assigning the property value.

3. Encapsulation: Properties allow you to control the visibility and accessibility of data. You can specify access modifiers (such as public, private, protected) to restrict or allow access to the property from other parts of the program.

4. Automatic Properties: Some programming languages, such as C#, provide a simplified syntax for defining properties known as automatic properties. In automatic properties, the compiler automatically generates the underlying private field for the property.

5. Read-only and Write-only Properties: Properties can be defined as read-only (with only a get accessor) or write-only (with only a set accessor), depending on the desired behavior.

6. Property Validation and Logic: Properties can contain additional logic to validate the assigned values or perform calculations before returning the value. This allows you to enforce constraints or apply business rules to the data.

7. Backing Fields: Properties are commonly used to encapsulate data stored in a private field known as a backing field. The backing field is typically accessed and modified through the get and set accessors of the property.

Here's an example of a property in C#:

```csharp
public class Person
{
    private string name; // backing field

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

// Using the property
Person person = new Person();
person.Name = "John"; // Sets the property value
Console.WriteLine(person.Name); // Retrieves the property value
```

In the example above, the `Person` class has a property called `Name`, which encapsulates the private field `name`. The get accessor returns the value of the `name` field, and the set accessor assigns a new value to it.

Properties provide a way to control access to the underlying data and enforce logic or validation if needed. They enable consistent and controlled interaction with the object's attributes, improving encapsulation and maintainability of the code.

## Indexers

Indexers are a language construct that allows objects to be accessed using an index or key, similar to how arrays or collections are accessed. They provide a way to define custom index-based access to an object's elements or members.

Here are some key points about indexers:

1. Purpose: Indexers provide a convenient way to access elements or members of an object by using an index or key, similar to how arrays are accessed using an index. They enable objects to be treated like arrays or collections, allowing for more intuitive and flexible access patterns.

2. Syntax: Indexers are defined within a class using the `this` keyword followed by the index parameter type(s) in square brackets, similar to array indexing. The indexers can have one or more parameters, depending on the desired indexing scheme.

3. Accessors: Indexers have get and set accessors, similar to properties, that define the logic for accessing or modifying elements based on the provided index. The get accessor is used to retrieve the value associated with the index, and the set accessor is used to assign a value to the element at the given index.

4. Overloading: Like methods and constructors, indexers can be overloaded to handle different index types or multiple parameters. This allows for different indexing schemes or flexible access patterns.

5. Example Use Cases: Indexers are useful when working with custom collections, dictionaries, or objects that represent a set of related elements. They allow direct access to elements based on a specified index or key without exposing the internal implementation details.

Here's an example of an indexer in C#:

```csharp
public class MyCollection
{
    private string[] elements = new string[5];

    // Indexer
    public string this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }
}

// Using the indexer
MyCollection collection = new MyCollection();
collection[0] = "Element 1"; // Sets the element at index 0
string element = collection[0]; // Retrieves the element at index 0
```

In the example above, the `MyCollection` class has an indexer defined using the `this` keyword with an integer index parameter. The indexer allows accessing the elements of the `elements` array directly using square bracket notation. The get accessor retrieves the element at the specified index, and the set accessor assigns a value to the element at the given index.

Indexers provide a flexible and convenient way to access elements or members of an object using an index or key, improving the usability and readability of the code when working with custom collections or objects that can be indexed.

### <a id="inheritance"></a> Inheritance
Inheritance is a fundamental concept in object-oriented programming (OOP) that allows classes to inherit properties, methods, and other members from other classes. In .NET, inheritance is supported by the Common Intermediate Language (CIL) and is a key feature of the .NET Framework.

Inheritance allows you to create a hierarchy of classes, where a derived class inherits the characteristics (members) of its base class(es). The derived class can then extend or modify the inherited members and add its own members as needed.

To define a class that inherits from another class in .NET, you use the `:` symbol followed by the name of the base class. Here's an example of a class inheritance in C#:

```csharp
class Vehicle
{
    protected string brand;

    public void Start()
    {
        Console.WriteLine("Starting the vehicle.");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping the vehicle.");
    }
}

class Car : Vehicle
{
    private int numberOfDoors;

    public void Accelerate()
    {
        Console.WriteLine("Accelerating the car.");
    }

    public void Brake()
    {
        Console.WriteLine("Applying the brakes.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Start();       // Inherited from Vehicle class
        myCar.Accelerate();  // Car-specific method
        myCar.Stop();        // Inherited from Vehicle class
    }
}
```

In the example, the `Vehicle` class serves as the base class, and the `Car` class is derived from it using the `:` symbol. The `Car` class inherits the `brand` field and the `Start()` and `Stop()` methods from the `Vehicle` class. It also defines its own fields (`numberOfDoors`) and methods (`Accelerate()`, `Brake()`).

When an instance of `Car` is created, it can access and utilize both the inherited members from the base class and its own members. In this case, the `myCar` object can call the `Start()`, `Accelerate()`, and `Stop()` methods.

Inheritance promotes code reuse, encapsulation, and the concept of "is-a" relationships. It allows for the creation of more specialized classes by building upon existing classes, leading to more manageable and structured code.


### <a id="base"></a> Use of "base" keyword

The "base" keyword is used in object-oriented programming languages, such as C# and Java, to access members (methods, properties, fields) of the base class from a derived class. It allows derived classes to extend or modify the behavior of the base class while still having access to its members.

Here are some key uses of the "base" keyword:

1. Calling Base Class Constructors: When a derived class is constructed, the base class constructor is automatically invoked. By using the "base" keyword followed by parentheses, you can explicitly call a specific constructor in the base class. This is useful when the base class has multiple constructors with different parameter lists, and you want to ensure the appropriate base class constructor is called.

2. Accessing Base Class Members: In a derived class, the "base" keyword can be used to access and call members (methods, properties, fields) defined in the base class. This is particularly useful when a derived class overrides a base class member but still needs to access the original implementation. By prefixing the member access with "base.", you can refer to the base class member explicitly.

3. Overriding Base Class Members: When a derived class overrides a virtual or abstract member (method, property) of the base class, the "base" keyword can be used to invoke the base class implementation within the derived class's override. This allows you to extend or modify the base class behavior while retaining the functionality of the base class member.

Here's an example to illustrate the use of the "base" keyword:

```csharp
public class BaseClass
{
    public virtual void MethodA()
    {
        Console.WriteLine("BaseClass MethodA");
    }
}

public class DerivedClass : BaseClass
{
    public override void MethodA()
    {
        base.MethodA(); // Calling the base class implementation
        Console.WriteLine("DerivedClass MethodA");
    }
}

// Creating objects and invoking methods
DerivedClass obj = new DerivedClass();
obj.MethodA();
```

In the example above, we have a base class called `BaseClass` with a virtual method `MethodA`. The derived class `DerivedClass` overrides `MethodA` and uses the "base" keyword to call the base class implementation. By doing so, the derived class can extend the behavior of the base class method while still invoking and incorporating the base class logic.

Output:

```
BaseClass MethodA
DerivedClass MethodA
```

In this example, the base class implementation of `MethodA` is invoked first using the "base" keyword, followed by the derived class implementation.

## <a id="overriding"></a> Method hiding and overriding

In .NET, method hiding and method overriding are two different concepts related to inheritance and polymorphism.

Method Hiding:
Method hiding occurs when a derived class defines a method with the same name as a method in its base class, but without using the `override` keyword. When an instance of the derived class calls the method, the method defined in the derived class is executed instead of the base class method. This behavior is known as method hiding.

Here's an example to illustrate method hiding in C#:

```csharp
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Base class method");
    }
}

class DerivedClass : BaseClass
{
    public new void Display()
    {
        Console.WriteLine("Derived class method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseObj = new BaseClass();
        baseObj.Display();  // Output: "Base class method"

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.Display();  // Output: "Derived class method"

        BaseClass derivedAsBaseObj = new DerivedClass();
        derivedAsBaseObj.Display();  // Output: "Base class method"
    }
}
```

In the example, `DerivedClass` defines a method called `Display` without using the `override` keyword. When this method is called on an instance of `DerivedClass`, it hides the base class method with the same name. However, when the same method is called on a base class reference pointing to an instance of the derived class, the base class method is executed.

Method Overriding:
Method overriding is a feature of object-oriented programming that allows a derived class to provide a different implementation of a method that is already defined in its base class. To override a method, you use the `override` keyword in the derived class.

Here's an example to demonstrate method overriding in C#:

```csharp
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Base class method");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("Derived class method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseObj = new BaseClass();
        baseObj.Display();  // Output: "Base class method"

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.Display();  // Output: "Derived class method"

        BaseClass derivedAsBaseObj = new DerivedClass();
        derivedAsBaseObj.Display();  // Output: "Derived class method"
    }
}
```

In this example, `DerivedClass` overrides the `Display` method from its base class using the `override` keyword. When the method is called on an instance of `DerivedClass`, the overridden method in the derived class is executed. Even when the method is called through a base class reference pointing to an instance of the derived class, the derived class method is still executed.

Method overriding allows for polymorphic behavior, where the appropriate implementation of the method is determined at runtime based on the actual type of the object.

## <a id="ploymorphism"></a> Applying polymorphism in code extensibility

When applying polymorphism in code extensibility, you create a base class that defines a common interface or behavior, and then derive multiple classes from it to provide specific implementations. This allows you to write code that can work with objects of different derived classes through the common base class interface. Here are some steps to apply polymorphism for code extensibility:

1. Define a Base Class: Create a base class that contains the common interface or behavior that you want to expose to derived classes. This can include methods, properties, or any other members.

2. Declare Virtual or Abstract Members: Declare some members (such as methods) in the base class as `virtual` or `abstract`. This allows derived classes to override or provide their own implementations for these members.

3. Derive from the Base Class: Create derived classes that inherit from the base class. Each derived class should provide its own implementation for the virtual or abstract members defined in the base class.

4. Utilize Polymorphism: Write code that operates on objects of the base class type but can work with objects of any derived class type. This is achieved by treating objects of derived classes as instances of the base class.

5. Override Virtual Members: In derived classes, override the virtual members declared in the base class to provide specific implementations. This enables the derived classes to customize the behavior defined in the base class.

6. Instantiate Derived Class Objects: Create objects of the derived classes and use them in your code. The objects can be assigned to variables of the base class type, allowing you to access the common interface or behavior defined in the base class.

By following these steps, you can achieve code extensibility through polymorphism. New derived classes can be added in the future without modifying the existing code that works with the base class, as long as they adhere to the common interface or behavior defined in the base class. This promotes modular and maintainable code, allowing for easy addition and customization of functionality.


## <a id="structs-enums"></a> structs and enums
Structs and enums are two different types in C# that serve distinct purposes.

1. Structs:
   - Structs, short for structures, are value types that can encapsulate related data fields. They are commonly used for small, lightweight data structures.
   - Structs are allocated on the stack and have value semantics. This means that when a struct is assigned to another variable or passed as a parameter, a copy of its entire value is made.
   - Structs can contain fields, properties, methods, and constructors. However, they cannot inherit from other structs or classes, and they cannot be used as a base for other types.
   - Structs are generally useful for representing simple data structures, such as coordinates, points, or small collections of related values.

   Here's an example of a struct in C#:

   ```csharp
   struct Point
   {
       public int X;
       public int Y;
   }

   // Usage:
   Point point;
   point.X = 10;
   point.Y = 20;
   Console.WriteLine($"Point: ({point.X}, {point.Y})");
   ```

2. Enums:
   - Enums, short for enumerations, are used to define a set of named constants, typically representing a specific domain or range of values.
   - Enums in C# are value types, and each enum value represents a named constant within the enum.
   - Enum values are usually defined using integer literals, and each value within the enum has an associated underlying numeric value.
   - Enums provide a way to assign meaningful names to numeric values, improving code readability and maintainability.

   Here's an example of an enum in C#:

   ```csharp
   enum DayOfWeek
   {
       Monday,
       Tuesday,
       Wednesday,
       Thursday,
       Friday,
       Saturday,
       Sunday
   }

   // Usage:
   DayOfWeek today = DayOfWeek.Monday;
   Console.WriteLine($"Today is {today}");
   ```

   In this example, the `DayOfWeek` enum represents the days of the week. Each day is assigned an underlying value starting from 0 (Monday) to 6 (Sunday). The `today` variable is assigned the value `DayOfWeek.Monday`, and it can be used throughout the code to represent Monday.

Enums are useful when you have a fixed set of options or when you want to improve code readability by using meaningful names instead of raw numeric values. Structs, on the other hand, are suitable for creating small data structures that contain related fields and have value semantics.


## <a id="abstract-sealed-interface"></a> Abstract class sealed class

In object-oriented programming, an abstract class and a sealed class are two distinct concepts with different purposes. Let's explore each of them:

1. Abstract Class:
   An abstract class is a class that cannot be instantiated directly. It serves as a blueprint for other classes and is intended to be subclassed. The main characteristics of an abstract class are:

- It can have both abstract and non-abstract (concrete) methods.
- It may contain abstract methods, which are declared but not implemented in the abstract class itself.
- Subclasses of an abstract class must provide implementations for all the abstract methods defined in the superclass.
- It can also provide default implementations for some or all of its methods.
- An abstract class can have instance variables, constructors, and other features commonly found in regular classes.

The purpose of an abstract class is to provide common behavior and attributes to its subclasses while allowing each subclass to define its own specific implementation.

2. Sealed Class:
   A sealed class, on the other hand, is a class that restricts inheritance. It means that other classes cannot inherit from it outside of its own assembly or module (depending on the programming language). The key characteristics of a sealed class are:

- It is often used to create a hierarchy of classes where inheritance is limited to a specific set of classes within the same assembly or module.
- A sealed class can have both abstract and non-abstract methods.
- It can be instantiated directly, unlike an abstract class.
- The primary purpose of a sealed class is to prevent further extension by prohibiting the creation of subclasses outside the defined hierarchy.

By sealing a class, you enforce that it remains in its current form and cannot be further extended or modified by other developers, ensuring the stability and consistency of the class's behavior.

In summary, an abstract class is a class that provides a blueprint for subclasses and cannot be directly instantiated, while a sealed class restricts inheritance and prevents the creation of subclasses outside its defined hierarchy.


## <a id="delegate-events"></a> Delegate and Events

In programming, especially in object-oriented languages, delegates and events are concepts related to event handling and asynchronous programming. They are commonly used to implement the observer pattern, allowing objects to communicate and respond to events that occur in the system.

1. Delegates:
A delegate is a type that represents a reference to a method with a particular signature. It acts as a function pointer or a callback function. Delegates are particularly useful when you want to pass methods as parameters to other methods or when you want to define callback mechanisms.

In C# (as an example), delegates are declared using the `delegate` keyword. Here's a simple example of a delegate:

```csharp
public delegate void MyDelegate(string message);

// Usage of the delegate:
public void MyMethod(string message)
{
    Console.WriteLine("Received message: " + message);
}

// Assigning the method to the delegate and invoking it:
MyDelegate delegateInstance = MyMethod;
delegateInstance("Hello, delegates!");
```

2. Events:
Events are a higher-level concept built on top of delegates. They provide a more controlled way of allowing objects to interact with each other. In contrast to delegates, events can only be invoked from within the class where they are defined. This restriction helps in encapsulating the event mechanism and ensuring that events can only be triggered by the owning class.

In C# (again, as an example), events are typically declared using the `event` keyword:

```csharp
public class EventPublisher
{
    // Declare an event using a delegate as the type.
    public event MyDelegate MyEvent;

    public void TriggerEvent(string message)
    {
        // Check if there are any subscribers (event handlers) before invoking the event.
        MyEvent?.Invoke(message);
    }
}

public class EventSubscriber
{
    public EventSubscriber(EventPublisher publisher)
    {
        // Subscribe to the event by providing the event handler method.
        publisher.MyEvent += HandleEvent;
    }

    public void HandleEvent(string message)
    {
        Console.WriteLine("Event received: " + message);
    }
}

// Usage:
EventPublisher publisher = new EventPublisher();
EventSubscriber subscriber = new EventSubscriber(publisher);

// Trigger the event, and the subscriber's handler will be invoked.
publisher.TriggerEvent("Hello, events!");
```

In this example, the `EventPublisher` class declares an event `MyEvent` of type `MyDelegate`. The `EventSubscriber` class subscribes to this event, and when the `TriggerEvent` method of the `EventPublisher` is called, it invokes all the registered event handlers, including the `HandleEvent` method in the `EventSubscriber` class.

Events are especially useful in scenarios where multiple objects are interested in receiving notifications about certain occurrences without the need for direct coupling between the objects. They promote loose coupling and maintain separation of concerns, making code more maintainable and extensible.



### <a id="partial-class"></a> Partial Class

In .NET, a partial class is a feature that allows a single class to be split into multiple physical files. This enables developers to separate the implementation of a class into different files while still treating it as a single entity. Partial classes are a language-specific feature available in C# and Visual Basic .NET.

Partial classes are mainly used to address the following scenarios:

1. Separation of Concerns: When a class becomes large and complex, it can be challenging to maintain. Using partial classes, developers can divide the class into smaller, manageable pieces, each focusing on a specific aspect of the class.

2. Code Generation: Partial classes are often used in code generation scenarios. For example, a tool or designer can generate part of the class code, while developers can provide the remaining implementation in another partial class file.

3. Collaboration: If different developers or teams are working on the same class simultaneously, they can work on separate files without causing merge conflicts in version control systems.

Here's an example of a partial class in C#:

**File: MyClass.cs**
```csharp
// MyClass.cs - Part 1
public partial class MyClass
{
    public void Method1()
    {
        // Implementation of Method1
    }
}
```

**File: MyClassPartial.cs**
```csharp
// MyClassPartial.cs - Part 2
public partial class MyClass
{
    public void Method2()
    {
        // Implementation of Method2
    }
}
```

In this example, the `MyClass` class is divided into two physical files, `MyClass.cs` and `MyClassPartial.cs`. Both files use the `partial` keyword before the class name. At compile time, the compiler combines the two partial class files into a single class, treating them as a single unit.

It's important to note that a partial class must have the same accessibility modifier (e.g., `public`, `internal`, etc.) in all of its parts. Also, you cannot split individual methods or properties across multiple files; each method or property must be defined entirely in one of the partial class files.

Partial classes provide a useful organizational feature in larger projects and promote code separation, making it easier to manage and maintain the codebase.

### <a id="collections"></a> Collections

In .NET, collections are used to store and manage groups of objects. They provide various data structures and algorithms for efficiently storing, retrieving, and manipulating data. The .NET Framework and .NET Core offer several built-in collection classes that you can use to work with collections of data. Some of the commonly used collection types are as follows:

1. **List<T>:** `List<T>` is a generic dynamic array that can grow or shrink in size. It allows you to store elements of the same type in a sequential manner. It supports indexed access, adding, removing, and searching for items.

2. **Dictionary<TKey, TValue>:** `Dictionary<TKey, TValue>` is a generic collection that stores key-value pairs. It provides fast look-up and retrieval of values based on their corresponding keys. The keys in a dictionary are unique.

3. **HashSet<T>:** `HashSet<T>` is a collection that represents a set of unique elements. It does not allow duplicate items, making it useful for removing duplicates from a collection.

4. **Queue<T>:** `Queue<T>` is a first-in-first-out (FIFO) collection, where the item added first is the first one to be removed. It supports enqueue (adding) and dequeue (removing) operations.

5. **Stack<T>:** `Stack<T>` is a last-in-first-out (LIFO) collection, where the item added last is the first one to be removed. It supports push (adding) and pop (removing) operations.

6. **LinkedList<T>:** `LinkedList<T>` is a doubly linked list that allows fast insertion and removal of elements. It provides operations to add, remove, and traverse the elements.

7. **SortedSet<T>:** `SortedSet<T>` is a set of unique elements sorted in ascending order. It automatically maintains the sorted order when adding or removing items.

8. **SortedDictionary<TKey, TValue>:** `SortedDictionary<TKey, TValue>` is similar to `Dictionary<TKey, TValue>`, but it keeps the keys in sorted order.

9. **ObservableCollection<T>:** `ObservableCollection<T>` is a collection that provides notifications when items are added, removed, or updated. It's commonly used with data binding in user interface frameworks like WPF and Xamarin.

These collections are part of the `System.Collections.Generic` namespace in C#. Additionally, there are non-generic collections available in the `System.Collections` namespace, but it's recommended to use the generic versions whenever possible because they offer better type safety and performance.

You can use these collection classes to effectively manage data in your .NET applications, depending on the specific requirements and scenarios of your application.


## <a id="generics"></a> Generics

Generics in .NET are a powerful feature that allows you to create reusable and type-safe classes, methods, and data structures. They enable you to define classes and methods that can work with different data types without sacrificing type safety at compile time.

Prior to generics, developers often used object-oriented techniques like inheritance and interfaces to create classes that could work with multiple data types. However, this approach had limitations, as it required casting objects at runtime and didn't provide compile-time type checking, which could lead to potential runtime errors.

With generics, you can create classes, interfaces, and methods that are parameterized with one or more types. These type parameters are specified between angle brackets ("<" and ">") when defining a generic class or method. The type parameters serve as placeholders for actual types that will be provided when creating instances of the generic class or invoking the generic method.

Here's a simple example of a generic class in C#:

```csharp
public class GenericList<T>
{
    private T[] items;
    private int count;

    public GenericList(int capacity)
    {
        items = new T[capacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count < items.Length)
        {
            items[count] = item;
            count++;
        }
    }

    public T GetItem(int index)
    {
        if (index >= 0 && index < count)
        {
            return items[index];
        }
        throw new IndexOutOfRangeException();
    }
}
```

In this example, `GenericList<T>` is a generic class with a single type parameter `T`. It uses this type parameter to define an array of type `T` and other methods that work with elements of type `T`. The actual type will be provided when creating an instance of the `GenericList<T>` class.

Usage of the generic class:

```csharp
GenericList<int> intList = new GenericList<int>(5);
intList.Add(10);
intList.Add(20);

GenericList<string> stringList = new GenericList<string>(3);
stringList.Add("Hello");
stringList.Add("World");
```

In the example above, we created instances of `GenericList<int>` and `GenericList<string>`, which are specific instances of the generic class with `T` replaced by `int` and `string`, respectively. The compiler ensures that the type safety is maintained at compile-time.

Generics are widely used in .NET for collections (e.g., `List<T>`, `Dictionary<TKey, TValue>`), LINQ, delegates, and many other scenarios. They provide improved performance and type safety while reducing the need for casting and boxing/unboxing operations at runtime.


## <a id="file-io"></a> File IO

In .NET, File I/O (Input/Output) allows you to read from and write to files on the file system. The .NET Framework and .NET Core provide classes and methods to handle file operations efficiently. The key namespaces involved in File I/O are `System.IO` and `System.Text`.

Here's a brief overview of the most commonly used File I/O operations in .NET:

1. **Reading from a File:**

   - `File.ReadAllText(string path)`: Reads the contents of a text file and returns it as a string.
   - `File.ReadAllLines(string path)`: Reads all lines from a text file and returns them as an array of strings.
   - `File.ReadAllBytes(string path)`: Reads all bytes from a binary file and returns them as a byte array.

Example of reading from a text file:

```csharp
using System;
using System.IO;

string filePath = "path/to/your/file.txt";

// Read all lines from the text file and store them in an array.
string[] lines = File.ReadAllLines(filePath);

foreach (string line in lines)
{
    Console.WriteLine(line);
}
```

2. **Writing to a File:**

   - `File.WriteAllText(string path, string contents)`: Writes the specified string to a text file, overwriting the existing content.
   - `File.WriteAllLines(string path, string[] contents)`: Writes an array of strings to a text file, each string as a separate line.
   - `File.WriteAllBytes(string path, byte[] bytes)`: Writes a byte array to a binary file.

Example of writing to a text file:

```csharp
using System;
using System.IO;

string filePath = "path/to/your/file.txt";
string[] lines = { "Line 1", "Line 2", "Line 3" };

// Write the array of lines to the text file.
File.WriteAllLines(filePath, lines);

Console.WriteLine("File written successfully.");
```

3. **Appending to a File:**

   - `File.AppendAllText(string path, string contents)`: Appends the specified string to a text file.
   - `File.AppendAllLines(string path, string[] contents)`: Appends an array of strings to a text file, each string as a separate line.

Example of appending to a text file:

```csharp
using System;
using System.IO;

string filePath = "path/to/your/file.txt";
string[] newLines = { "New Line 1", "New Line 2" };

// Append the new lines to the text file.
File.AppendAllLines(filePath, newLines);

Console.WriteLine("Lines appended successfully.");
```

Remember to handle exceptions and use appropriate error handling when working with File I/O operations to handle scenarios like file not found, access denied, or other issues that may arise during reading or writing operations.

## <a id="linq"></a> LINQ (Language Integrated Query)

LINQ (Language-Integrated Query) is a powerful feature in .NET that enables you to write queries against collections (such as arrays, lists, and dictionaries) and various data sources (such as databases and XML) using a unified and consistent syntax. LINQ was introduced in C# 3.0 and is available in both the .NET Framework and .NET Core.

The main goal of LINQ is to provide a standard, strongly-typed way to query and manipulate data, regardless of the data source. It allows you to express queries using a declarative syntax, making code more concise and easier to understand. LINQ queries are resolved at compile-time, providing type safety and improving performance.

LINQ supports various query operations, including filtering, sorting, grouping, joining, aggregating, and projecting data. The LINQ syntax is similar to SQL, making it familiar to developers with database query experience.

Here's a brief overview of LINQ and its key components:

1. **LINQ Query Expressions:**
   LINQ queries are written using query expressions, which are similar to SQL syntax. The main query operators are `from`, `where`, `select`, `group`, `join`, `orderby`, and `into`. You can chain these operators together to construct complex queries.

Example of a LINQ query expression:

```csharp
using System;
using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = from num in numbers
                  where num % 2 == 0
                  select num;

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}
```

2. **LINQ Extension Methods:**
   LINQ also provides a set of extension methods in the `System.Linq` namespace. These extension methods allow you to use LINQ query operations directly on collections by chaining them together.

Example of using LINQ extension methods:

```csharp
using System;
using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = numbers.Where(num => num % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}
```

3. **LINQ to Objects:**
   LINQ to Objects allows you to query in-memory collections, such as arrays and lists. It's the most common usage of LINQ and provides support for querying, filtering, and projecting data from these collections.

4. **LINQ to SQL (Entity Framework):**
   LINQ to SQL is used to query and manipulate data from relational databases. It allows you to write LINQ queries against the database, and it's commonly used with Entity Framework, an Object-Relational Mapping (ORM) tool.

5. **LINQ to XML:**
   LINQ to XML provides querying capabilities for XML data. It allows you to create, modify, and query XML documents using LINQ syntax.

LINQ is a versatile and powerful feature that makes data querying and manipulation more natural and expressive in .NET applications. It promotes more concise and readable code while maintaining strong type safety and improving developer productivity.

## <a id="fundamentals"></a> Fundamentals: Lambda Expressions, Try statements and Exceptions, Attributes: Attribute Classes, Named and Positional Attribute Parameters, Attribute Targets, Specifying Multiple Attributes


Certainly! Let's explore some fundamentals in .NET, including lambda expressions, try statements and exceptions, and attributes.

1. **Lambda Expressions:**
Lambda expressions are a concise way to represent anonymous functions in .NET. They enable you to write inline functions without the need to define a separate method. Lambda expressions are commonly used in LINQ queries, event handling, and other scenarios where a delegate or expression is required.

Example of a lambda expression in C#:

```csharp
Func<int, int, int> add = (x, y) => x + y;
int result = add(2, 3); // result will be 5
```

In this example, the lambda expression `(x, y) => x + y` represents an anonymous function that takes two integers as input and returns their sum.

2. **Try Statements and Exceptions:**
Exception handling is an essential aspect of .NET programming, and it allows you to gracefully handle unexpected errors or exceptional conditions in your code. The `try`, `catch`, and optionally `finally` blocks are used to handle exceptions.

Example of using try-catch in C#:

```csharp
try
{
    // Code that may throw an exception
    int result = 10 / 0; // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    // Handle the exception
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    // Code that will always run, regardless of whether an exception occurred
    Console.WriteLine("Finally block executed.");
}
```

3. **Attributes:**
Attributes are a way to add metadata or annotations to elements in your code, such as classes, methods, properties, and more. Attributes are mainly used for declarative programming, configuration, and reflection.

Example of defining a custom attribute in C#:

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class MyCustomAttribute : Attribute
{
    public string Name { get; }

    public MyCustomAttribute(string name)
    {
        Name = name;
    }
}
```

4. **Named and Positional Attribute Parameters:**
When defining custom attributes, you can have named and positional parameters. Named parameters allow you to assign values to attributes using their names, while positional parameters are assigned based on their order in the attribute constructor.

Example of using named and positional attribute parameters:

```csharp
[MyCustomAttribute("Example", Name = "John")]
public class MyClass
{
    // Class definition
}
```

5. **Attribute Targets:**
Attributes can be applied to various elements in .NET. You can specify which elements an attribute can be applied to using `AttributeTargets` enum values in the attribute class declaration.

Example of specifying attribute targets:

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class MyCustomAttribute : Attribute
{
    // Attribute definition
}
```

6. **Specifying Multiple Attributes:**
You can apply multiple attributes to the same code element, separated by commas.

Example of specifying multiple attributes:

```csharp
[MyAttribute1]
[MyAttribute2]
public class MyClass
{
    // Class definition
}
```

Attributes are widely used in .NET for various purposes, including serialization, validation, logging, and more. They provide a flexible and declarative way to add metadata to your code, making it more expressive and self-descriptive.


### <a id="asyn"></a> Asynchronous Programming: Principle of Asynchrony, Async/Await patterns in C#

Asynchronous programming is a crucial concept in modern software development, especially in scenarios where tasks can take significant time to complete, such as I/O operations or network requests. Asynchronous programming allows the program to continue executing other tasks while waiting for long-running operations to finish, thus improving overall system responsiveness and resource utilization.

In C#, asynchronous programming is achieved using the `async/await` pattern, which was introduced in C# 5.0 and is built on top of the Task Parallel Library (TPL). The `async` keyword is used to mark a method as asynchronous, and the `await` keyword is used within the asynchronous method to asynchronously wait for the completion of another asynchronous operation.

Here's a brief explanation of the principle of asynchrony and how the `async/await` pattern works:

1. **Principle of Asynchrony:**
In synchronous programming, a method blocks the execution until a long-running task completes. This can lead to inefficient resource utilization, especially in scenarios where the thread is waiting for I/O operations (e.g., reading from a file, making a web request). Asynchronous programming, on the other hand, allows a method to yield control back to the caller while waiting for the long-running operation to complete. This enables the thread to be used for other tasks, improving overall concurrency and responsiveness.

2. **Async/Await Pattern in C#:**
The `async/await` pattern in C# allows you to write asynchronous code in a way that looks similar to synchronous code, making it easier to read and understand.

- `async`: The `async` keyword is used to mark a method as asynchronous. An asynchronous method can contain one or more `await` expressions, which indicate that the method will asynchronously wait for the completion of a particular task or operation.

- `await`: The `await` keyword is used within an asynchronous method to asynchronously wait for the completion of a `Task` or `Task<T>` (representing an asynchronous operation). When the `await` keyword is encountered, the method yields control back to the caller, allowing the thread to do other work until the awaited task completes. Once the awaited task finishes, the method resumes execution from the point after the `await` statement.

Here's an example of using the `async/await` pattern to perform an asynchronous web request using `HttpClient` in C#:

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        await PerformWebRequestAsync();
    }

    public static async Task PerformWebRequestAsync()
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
```

In this example, the `Main` method is marked as asynchronous using the `async` keyword, and it awaits the completion of the `PerformWebRequestAsync` method. The `PerformWebRequestAsync` method, in turn, is asynchronous and awaits the results of asynchronous operations performed by `HttpClient`. While waiting for the web request to complete, the thread can be used to perform other tasks, improving the overall efficiency of the program.

The `async/await` pattern simplifies the code and makes it more maintainable, while still allowing developers to write efficient asynchronous programs. It is widely used in modern C# applications to handle asynchronous operations such as I/O, networking, and other time-consuming tasks.


