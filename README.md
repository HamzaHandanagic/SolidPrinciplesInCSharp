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

