* Use the Memento pattern when you want to produce snapshots of the object’s state to be able to restore a previous state of the object.
* The Memento pattern lets you make full copies of an object’s state, including private fields, and store them separately from the object. 

### Important
=> Use the pattern when direct access to the object’s fields/getters/setters violates its encapsulation.
=> You can use Command and Memento together when implementing “undo”. In this case, commands are responsible for performing various operations over a target object, while mementos save the state of that object just before a command gets executed.
=> You can use Memento along with Iterator to capture the current iteration state and roll it back if necessary.


