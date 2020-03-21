# The problem
- The behavioral pattern in which an object is used to encapsulate all information needed to perform an action or trigger an event latter time. 
- The aim of the Command pattern is decoupling the invoker from the receiver. With this structure, the invoker can talk to the receiver without being aware of it.
- This pattern makes our code extensible as we can add new commands without changing the existing code. However, increases in the number of classes for each individual command.

- It defines 3 concepts:
    - **Sender**: The Sender class (aka invoker) is responsible for initiating requests. This class must have a field for storing a reference to a command object. The sender triggers that command instead of sending the request directly to the receiver. Note that the sender isn’t responsible for creating the command object. Usually, it gets a pre-created command from the client via the constructor.
    - **Command**: The Command interface usually declares just a single method for executing the command.
    - **Receiver**: The Receiver class contains some business logic. Almost any object may act as a receiver. Most commands only handle the details of how a request is passed to the receiver, while the receiver itself does the actual work.

- **Composite Commands**: stores user actions and execute them later.
- **Undoable Commands**: every command knows how to undo itself and, we do not have to store multiple snapshots of an object.


- *You can use Command and Memento together when implementing “undo”. In this case, commands are responsible for performing various operations over a target object, while mementos save the state of that object just before a command gets executed.*

- More info: [Command](https://refactoring.guru/design-patterns/command)