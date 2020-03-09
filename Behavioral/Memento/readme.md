# The problem
- The Memento pattern lets you make full copies of an object’s state, including private fields, and store them separately from the object. While most people remember this pattern thanks to the “undo” use case, it’s also indispensable when dealing with transactions;
- Using a stack directly on the **Originator** would violate the single responsibility principle;
- It defines 3 concepts:
    - **Originator**: The Originator class can produce snapshots of its own state, as well as restore its state from snapshots when needed.
    - **Memento**: The Memento is a value object that acts as a snapshot of the originator’s state. It’s a common practice to make the memento immutable and pass it the data only once, via the constructor.
    - **CareTaker**: The Caretaker knows not only “when” and “why” to capture the originator’s state, but also when the state should be restored.

- More info: [Memento](https://refactoring.guru/design-patterns/memento)