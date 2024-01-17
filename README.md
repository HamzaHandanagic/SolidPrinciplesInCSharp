# Solid Principles in C#

Design principles helps us to maintain the value of code. The SOLID principles are a set of design principles for writing maintainable and scalable software. These principles were introduced by Robert C. Martin and are widely used in object-oriented programming. SOLID is a mnemonic acronym and each of the letters in it stands for:

- S – Single Responsibility Principle (SRP)
- O – Open/Closed Principle (OCP)
- L – Liskov Substitution Principle (LSP)
- I – Interface Segregation Principle (ISP)
- D – Dependency Inversion Principle (DIP)

 We should not apply SOLID Principles upfront but at the end we should strive to refactor towards them to make our code cleaner, more maintenable, testable etc.

## Single Responsibility Principle (SRP)

Definition: Each software module should have one and only one reason to change. 

In context of C#: individual classes define what the application does. A class should have only one reason to change, meaning it should have only one responsibility. Reasons to change: persistance, logging, validation rules, business logic.

The first thing we need to do is to separate the part of our code that is unlike others. We are trying to accomplish only one task in our class, they have become free of clutter and simple to read.
Single Responsibility Principle is closely related to the idea of coupling. Tight coupling should be avoided. Tight coupling means that something is binded together in a way that's difficult to change. SRP should move our code closer to loose coupling and separation of concerns.
Loose coupling - modular way to combine different modules.
Separation of Concerns - programs should be separated into distinct sections each addressing a spearate concern.



With SRP we get less complex logic, free of clutter, simple to read. Our classes are less dependent on each other which will also make it more testable. Improved flexibility, more modular, reusable.

Not inherent to SRP but possible downsides of SRP: increased number of classes, more dependencies, can lead to code duplication.

## Open/Closed Principle (OCP)

Definition: Software entities should be open for extension but closed for modification.

The Open/Closed Principle (OCP), defined by Bertrand Meyer in 1988, states that software entities (such as classes, modules, methods) should be open for extension but closed for modification. You should be able to extend the behavior of a module without altering its source code. This principle promotes the use of abstraction and polymorphism to achieve flexibility and avoid modifying existing, working code.

We should strive to write a code that doesn’t require modification every time a customer changes its request. It's OK to modify the functions/classes to do that, especially for simpler functions but as complexity grows Open/Closed Principle applied is useful. Less we need to change source of our code there is less chance to introduce new bugs to our code. If you want to add new functionality to your existing code and you have to modify it before you add the new functionality, then you are not following the open-closed principle. Code that is open for extension is usually abstract. There should be fine balance between concreteness and abstraction.

So, we should strive for our code to be:
1. Open for extension
2. Closed for modification

Different approaches to apply OCP:
1. Apply parameters - mostly this is already applied in our code. We are passing generic parameter, e.g.: string message to method and then method can display that message.
2. Use inheritance - extend method. Mark method as virtual and then override it in child class to use different message.
3. Composition and injection - don't place logic inside of a class but store it in another class that classes references (dependency injection). Logic for generating messages can be extracted in separate class called MessageService and then we inject that class into our main class.


Tips: start concrete and then introduce abstraction. Implement new features in new classes because nothing in the current system depends on newly created class. Use abstraction and inheritance to create extensible designs. Leverage interfaces to define flexible contracts. Encapsulate varying behavior using design patterns, such as the Strategy Pattern.

Benefits: more maintainable, testable, flexible etc.

Possible downsides: abstraction adds complexity, use of polymorphism and interfaces can introduce a slight runtime performance overhead compared to direct method calls...

## Liskov Substitution Principle (LSP)

Definition: Let q(x) be a property provable about objects x of type T. Then q(y) should be true for objects y of type S where S is a subtype of T.

Simply put, the Liskov Substitution Principle (LSP) states that objects of a superclass should be replaceable with objects of its subclasses without breaking the application. We want is to have the objects of our subclasses behaving the same way as the objects of our superclass. 

Inheritance is "IS-A" relationship e.g.: Eagle IS-a bird. Properties exhibits "HAS-A" relationships e.g: Address has a city. LSP states that the IS-A relationship is insufficient for Object Oriented Design and should be replaced with "IS-SUBSTITUTABLE-FOR" relationship. Example that is often being used is example with Rectangle and Square problem. Rectangle by definition has four sides and four right angles. Similary, square has four equal sides and four right angles. In geometry, a square is a rectangle but it can not replace rectangle because square has all four sides the same.

LSP is a subset of Polymorphism. LSP says that you can not return new exceptions.  

Covariance, Contravariance concepts: Covariance - if you have a return type that return type should not change. In C# this is already default behaviour. Contravariance is about input type, same as covariance.
Preconditions, Postconditions concepts: Preconditions - you can not strenghten them. A subclass should not require more or stricter conditions for the method to work properly than its base class.  The postconditions of a base class method must not be weakened in a subclass. A subclass should meet at least the same postconditions as its base class, and it may strengthen them if necessary.

## Interface Segregation Principle (ISP)

Definition: Clients should not be forced to depend on methods they do not use.

Client can be defined as the code that is interacting with an instance of the interface. It's a calling code. Interfaces should be small, cohesive. In C#, interfaces are contracts that define the properties, methods, and events that classes or structs must implement. They provide a way to achieve abstraction and define a blueprint for a group of related capabilities.

When developing a new feature, we create an interface based on the initial code. If a similar feature is requested later, implemented through the same interface but with fewer required methods, Interface Segregation Principle (ISP) ensures we only implement the necessary methods, addressing the problem of unnecessary method implementation. Basically, the ISP states that we should reduce code objects down to the smallest required implementation thus creating interfaces with only required declarations. 

As a result, an interface that has a lot of different declarations should be split up into smaller interfaces. To break up large interfaces we can use interface inheritance or Adapter design pattern. The Adapter Pattern is a structural design pattern that allows incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces by wrapping the interface of a class into another interface that a client expects. There is Adapter class and Adaptee class. Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type. 

ISP benefits: maintability, reduced code complexity, easier testing, flexibility, following ISP helps with SRP and LSP.

Signs that you are violating ISP in your code: 
- Large Interfaces,
- If there are NotImplementedExceptions that is telling you that interface is bigger than some of your clients needed.
- Difficulty in Extending Functionality - if adding a new feature requires changes to multiple classes due to the shared nature of interfaces.
- Classes Implementing Placeholder Methods.
- Interfaces with Unrelated Methods.

## Dependency Inversion Principle (DIP)

Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions. Also, abstractions should not depend on details but details should depend on abstractions.

The basic idea behind the Dependency Inversion Principle is that we should create the higher-level modules with its complex logic in such a way to be reusable and unaffected by any change from the lower-level modules in our application. Abstractions describe "what": e.g.: send a message, store a customer record. Details specify "how": Send an SMTP email over port 25, serialize Customer to JSON and store in a text file etc. Changing already implemented modules is risky. By depending on abstraction and not on a concrete implementation, we can reduce that risk by not having to change high-level modules in our project.

How to tell if something depends on something else? There are 2 types of dependencies in C#: 
1. Compile time
2. Runtime

Without abstraction compile time and runtime control flow will be the same. With abstractions, dependencies at compile time are inverted. Classes depend on new interfaces. Dependency Inversion Principle goes hand in hand with one way of implementing DIP and that is Dependency Injection. With DI you don't create your own dependecies, request dependencies from client, inject dependecies in form of: constructor arguments, properties, method arguments. Constructor injection is preffered because it follows explicit dependencies principle, classes are never in uninitialized state, can leverage an IOC container to construct types and their dependencies. Dependency Injection can be viewed as implementation of Strategy Pattern.

Dependency Inversion principle mostly has to do with compile time dependencies. It's important to set up properly solution to follow DIP. There are low level dependencies like: database, file system, email, configuration etc. These dependecies are harder to isolate in testing and usually they can be problematic. There are some rules that can be followed to eliminate problems like: classes should explicitly expose dependencies through constructor. In this case we don't surprise class clients with it. The high-level modules describe those operations in our application that have more abstract nature and contain more complex logic. These modules orchestrate low-level modules in our application. 

Tips: most classes should depenend on abstractions not implementation details. Abstractions should not leak details. Clients should inject dependencies when they create other classes. Our solution should be structured in a way to leverage dependency inversion.

Benefits: decoupling, testability, reusability, stability at the level of architecture of our application. Modularity and reusability of the application modules.

