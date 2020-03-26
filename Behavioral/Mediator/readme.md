# The problem
- Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.
- For example, having a dialog for creating and editing customer profiles. It consists of various form controls such as text fields, checkboxes, buttons, etc. By having the logic implemented directly inside the code of the form elements you make these elements’ classes much harder to reuse in other forms of the app. 
- The Mediator pattern suggests that you should cease all direct communication between the components which you want to make independent of each other. Instead, these components must collaborate indirectly, by calling a special mediator object that redirects the calls to appropriate components. As a result, the components depend only on a single mediator class instead of being coupled to dozens of their colleagues.

- It defines 2 concepts:
    - **Mediator**: encapsulate relations between various components. Concrete mediators often keep references to all components they manage and sometimes even manage their life cycle.
    - **Components**: Components are various classes that contain some business logic. Each component has a reference to a mediator, declared with the type of the mediator interface. The component isn’t aware of the actual class of the mediator, so you can reuse the component in other programs by linking it to a different mediator.

- We need to be aware that over time the Mediator can evolve to a [God Object](https://en.wikipedia.org/wiki/God_object). To solve this problem, we can use the Observer Pattern.

- We can use

- More info: [Mediator](https://refactoring.guru/design-patterns/mediator)