# The problem
- It allows an object to behave differently, when its state changes. (Based on polymorphism)
- We can support new functionalities, without changing the existing code, just by adding new classes.
- The State pattern suggests that you create new classes for all possible states of an object and extract all state-specific behaviors into these classes.
- Instead of implementing all behaviors on its own, the original object, called context, stores a reference to one of the state objects that represents its current state, and delegates all the state-related work to that object.
- It defines 3 concepts:
    - **Context**: Context stores a reference to one of the concrete state objects and delegates to it all state-specific work. The context communicates with the state object via the state interface. The context exposes a setter for passing it a new state object.
    - **State**: The State interface declares the state-specific methods. These methods should make sense for all concrete states because you don’t want some of your states to have useless methods that will never be called.
    - **ConcreteSate**: Provide their own implementations for the state-specific methods. To avoid duplication of similar code across multiple states, you may provide intermediate abstract classes that encapsulate some common behavior.

- More info: [State](https://refactoring.guru/design-patterns/state)