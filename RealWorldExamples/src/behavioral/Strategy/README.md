Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.
<br/>
The original object, called context, holds a reference to a strategy object. The context delegates executing the behavior to the linked strategy object. In order to change the way the context performs its work, other objects may replace the currently linked strategy object with another one.


# Applicability
* Use the Strategy pattern when you want to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime.
* Use the Strategy when you have a lot of similar classes that only differ in the way they execute some behavior.
*  Use the pattern to isolate the business logic of a class from the implementation details of algorithms that may not be as important in the context of that logic.
* Use the pattern when your class has a massive conditional statement that switches between different variants of the same algorithm.

# Pros and Cons
* You can replace inheritance with composition.
* You can isolate the implementation details of an algorithm from the code that uses it.
* You can swap algorithms used inside an object at runtime.
