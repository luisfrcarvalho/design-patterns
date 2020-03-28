# The problem

- We should use the Decorator pattern when you need to be able to assign extra behaviours to objects at runtime without breaking the code that uses these objects.

- This pattern is kind of similar to implementing the adapter pattern. The difference between these two patterns is that with the adapter pattern, we change the interface of a class to a different form. In contrast, with the decorator pattern, we add additional behaviour to an object.

- It defines 2 concepts:
    - **Component**: The Component declares the common interface for both wrappers and wrapped objects.
    - **Decorator**:  The class has a field for referencing a wrapped object. The field’s type should be declared as the component interface so it can contain both concrete components and decorators. The decorator delegates all operations to the wrapped object.


- More info: [Decorator](https://refactoring.guru/design-patterns/decorator)