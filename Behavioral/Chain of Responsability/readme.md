# The problem

- Let's say we want to perform authentication, logging, and compression on an HttpRequest. Doing these tasks inside of one class would violate the Single Responsibility Principle. So, we should implement each task inside a separate class. Also, the order of the actions will be hardcoded. If in the future we want to disable logging for certain scenarios, we cannot do it without changing the current implementation.

- Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

- This pattern allows our systems to be open for an extension and closed for modification, because adding/removing more steps do not need modifications on the WebServer (**Code Example**) class.

- It defines 3 concepts:
    - **Base Handler**: The Base Handler is an optional class where you can put the boilerplate code that’s common to all handler classes. Usually, this class defines a field for storing a reference to the next handler. The clients can build a chain by passing a handler to the constructor or setter of the previous handler. The class may also implement the default handling behavior: it can pass execution to the next handler after checking for its existence.
    - **Concrete Handler**: Concrete Handlers contain the actual code for processing requests. Upon receiving a request, each handler must decide whether to process it and, additionally, whether to pass it along the chain. Handlers are usually self-contained and immutable, accepting all necessary data just once via the constructor.
    - **Client**: The Client may compose chains just once or compose them dynamically, depending on the application’s logic. 

- More info: [Chain of Responsibility](https://refactoring.guru/design-patterns/chain-of-responsibility)