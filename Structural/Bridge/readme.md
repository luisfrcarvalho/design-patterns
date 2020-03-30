# The problem

- The bridge pattern solves situations where we try to extend classes in two or more independent dimensions As a result, this pattern attempts to solve this problem by switching from inheritance to the object composition. What this means is that you extract one of the dimensions into a separate class hierarchy, so that the original classes will reference an object of the new hierarchy, instead of having all of its state and behaviours within one class.

- The bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

- The bridge pattern connects two completely independent hierarchies. So, with this pattern, we can build flexible hierarchies that can grow independent of each other.

- It defines 2 concepts:
    - **Implementation**: Declares the interface that’s common for all concrete implementations. An abstraction can only communicate with an implementation object via methods that are declared here.
    - **Concrete Implementations**: Contains platform-specific code.
    - **Abstraction**: Provides high-level control logic. It relies on the implementation object to do the actual low-level work.

- More info: [Bridge](https://refactoring.guru/design-patterns/bridge)