 ## Applicability
 * Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.
 * The Adapter pattern lets you create a middle-layer class that serves as a translator between your code and a legacy class, a 3rd-party class or any other class with a weird interface. 
 * Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.
 * You could extend each subclass and put the missing functionality into new child classes. However, you’ll need to duplicate the code across all of these new classes, which smells really bad!!
 * The much more elegant solution would be to put the missing functionality into an adapter class. Then you would wrap objects with missing features inside the adapter, gaining needed features dynamically. For this to work, the target classes must have a common interface, and the adapter’s field should follow that interface. This approach looks very similar to the ["Decorator pattern"](https://refactoring.guru/design-patterns/decorator).


 ## How to Implement?
1. Make sure that you have at least two classes with incompatible interfaces:
	* A useful service class, which you can’t change (often 3rd-party, legacy or with lots of existing dependencies).
	* One or several client classes that would benefit from using the service class.

2. Declare the client interface and describe how clients communicate with the service.
3. Create the adapter class and make it follow the client interface. Leave all the methods empty for now.
4. Add a field to the adapter class to store a reference to the service object. The common practice is to initialize this field via the constructor, but sometimes it’s more convenient to pass it to the adapter when calling its methods.
5. One by one, implement all methods of the client interface in the adapter class. The adapter should delegate most of the real work to the service object, handling only the interface or data format conversion.
6. Clients should use the adapter via the client interface. This will let you change or extend the adapters without affecting the client code.

