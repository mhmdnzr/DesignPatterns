Good software design is often based on the principle of separation of concerns, which usually results in breaking an app into layers.

Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

In the code it might look like this: a GUI object calls a method of a business logic object, passing it some arguments. This process is usually described as one object sending another a request.

The Command pattern suggests that GUI objects shouldn’t send these requests directly. Instead, you should extract all of the request details, such as the object being called, the name of the method and the list of arguments into a separate command class with a single method that triggers this request.

Command objects serve as links between various GUI and business logic objects. From now on, the GUI object doesn’t need to know what business logic object will receive the request and how it’ll be processed. The GUI object just triggers the command, which handles all the details.

The next step is to make your commands implement the same interface. Usually it has just a single execution method that takes no parameters. This interface lets you use various commands with the same request sender, without coupling it to concrete classes of commands. As a bonus, now you can switch command objects linked to the sender, effectively changing the sender’s behavior at runtime.

As a result, commands become a convenient middle layer that reduces coupling between the GUI and business logic layers.

# Applicability
* Use the Command pattern when you want to parametrize objects with operations.
* Use the Command pattern when you want to queue operations, schedule their execution, or execute them remotely.
* Use the Command pattern when you want to implement reversible operations.

# Pros and Cons
* Single Responsibility Principle. You can decouple classes that invoke operations from classes that perform these operations.
* Open/Closed Principle. You can introduce new commands into the app without breaking existing client code.
* You can implement undo/redo. (like memento)
* You can implement deferred execution of operations.
* You can assemble a set of simple commands into a complex one.

