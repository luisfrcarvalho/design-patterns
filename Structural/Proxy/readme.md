# The problem

- The proxy pattern, as the name implies, allows us to create a proxy or an agent for a real object. So if you want to talk to an object, you'll talk to it trough it's proxy or agent, this agent takes our message and forwards it to the target object.

- Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

- Very usefull to implement lazy loading.

- This pattern allows to change our apllication behaviour by adding a new class, without modifying any exsiting code.

- It defines 3 concepts:
    - **Service Interface**: declares the interface of the Service. The proxy must follow this interface to be able to disguise itself as a service object.
    - **Service**: is a class that provides some useful business logic.
    - **Proxy**: has a reference field that points to a service object. After the proxy finishes its processing (e.g., lazy initialization, logging, access control, caching, etc.), it passes the request to the service object. Usually, proxies manage the full lifecycle of their service objects.


- More info: [Proxy](https://refactoring.guru/design-patterns/proxy)