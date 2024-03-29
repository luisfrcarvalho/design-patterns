# The problem

- Let's say we have an object called A that, when required, must trigger an action in a group of objects.

- Making each object of the group checking A's state would be very costly and, in the majority of the times, would be pointless.

- As a result, we should find a way to notify each object of the group when A's needs.


# The solution

- The Observer, also known as a publish/subscribe pattern, is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

- The object that has some interesting state is often called the subject, but since it’s also going to notify other objects about the changes to its state, we’ll call it a publisher. All other objects that want to track changes to the publisher’s state are called subscribers.

- It suggests that you add a subscription mechanism to the publisher class so individual objects can subscribe to or unsubscribe from a stream of events coming from that publisher.

# Structure

![](diagram.png)

- **Subject**
    - The Subject, also know as Publisher, issues events of interest to other objects. These events occur when the subject changes its state or executes some behaviors. Subjects contain a subscription infrastructure that lets new subscribers join and current subscribers leave the list.

- **Observer**
    - The Observer, also know as Subscriber, interface declares the notification interface. In most cases, it consists of a single update method. The method may have several parameters that let the publisher pass some event details along with the update.


# Notes

- **Communication Styles**
    - With the basic Observer Design, observers don't know what changed. So, in order to solve this problem, we could follow two approaches:
        - **Push Style** 
            - We add a parameter on the Update method declared on the Observer interface (Update(Value)). 
            - However, we must take into account, that if a new ConcreteObserver needs different proprieties on Value object, we could break the interface;
        - **Pull Style**:
            - Each ConcreteObserver stores a reference to a ConcretePublisher.
            - On each update action, the Observer retrieves the information required trough methods exposed by the ConcretePublisher.
            - Healthy coupling between ConcreteObserver -> ConcretePublisher. 

- *Open/Closed Principle*
    -  You can introduce new subscriber class- es without having to change the publisher’s code (and vice versa if there’s a publisher interface).