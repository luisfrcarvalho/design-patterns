# The problem

- The Template pattern comes to solve situations where we have code replicated in different classes;
- It suggests that you break down an algorithm into a series of steps, turn these steps into methods, and put a series of calls to these methods inside a single “template method.” The steps may either be abstract, or have some default implementation. To use the algorithm, the client is supposed to provide its own subclass, implement all abstract steps, and override some of the optional ones if needed (but not the template method itself).
- In other words, is a behavioral design pattern that defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.

- It defines 2 concepts:
    - **AbstractClass**: declares methods that act as steps of an algorithm, as well as the actual template method which calls these methods in a specific order. The steps may either be declared abstract or have some default implementation.
    - **ConcreteClass**: can override all of the steps, but not the template method itself.

- More info: [Template](https://refactoring.guru/design-patterns/template-method)