# The problem

- Let's say we have a Class A which holds a list of items, that must be sorted following different strategies.

- Each time you added a new sorting algorithm, A doubled in size. At some point, the beast became too hard to maintain.

- Any change to one of the algorithms, whether it was a simple bug fix or a slight adjustment, affected the whole class, increasing the chance of creating an error in already-working code.

# The solution

- The Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

- It suggests that you take a class that does something specific in a lot of different ways and extract all of these algorithms into separate classes called strategies.

- The original class, called context, must have a field for storing a reference to one of the strategies. The context delegates the work to a linked strategy object instead of executing it on its own.

- The context isn’t responsible for selecting an appropriate algorithm for the job. Instead, the client passes the desired strategy to the context. In fact, the context doesn’t know much about strategies. It works with all strategies through the same generic interface, which only exposes a single method for triggering the algorithm encapsulated within the selected strategy.

- This way the context becomes independent of concrete strategies, so you can add new algorithms or modify existing ones without changing the code of the context or other strategies.

# Structure

![](diagram.png)

- **Context**
    - The Context maintains a reference to one of the concrete strategies and communicates with this object only via the strategy interface.

- **Strategy**
    - The Strategy interface is common to all concrete strategies. It declares a method the context uses to execute a strategy.


# Notes

- State pattern can be considered as an extension of Strategy. Both patterns are based on composition: they change the behavior of the context by delegating some work to helper objects. The strategy makes these objects completely independent and unaware of each other. However, the State doesn’t restrict dependencies between concrete states, letting them alter the state of the context at will.