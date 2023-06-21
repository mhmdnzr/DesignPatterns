Factory method provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

## When use factory method?
* Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
* Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.


### Features!!
* To add a new product type to the app, you’ll only need to create a new creator subclass and override the factory method in it.
* You often experience this need when dealing with large, resource-intensive objects such as database connections, file systems, and network resources.