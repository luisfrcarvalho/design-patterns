# The problem

- We use this pattern to convert the interface of a class to a different form, just like how we use adapters in everyday life.

- The adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate. For example, when we import behaviour from 3rd-party-library.

- An adapter wraps one of the objects to hide the complexity of conversion happening behind the scenes. The wrapped object isn’t even aware of the adapter. For example, you can wrap an object that operates in meters and kilometres with an adapter that converts all of the data to imperial units such as feet and miles.

- Adapters can not only convert data into various formats but can also help objects with different interfaces collaborate.

- We can use **Inheritance** or **Composition** to create the Adapter.

- **Adpater**: is a class that’s able to work with both the client and the service: it implements the client interface while wrapping the service object. The adapter receives calls from the client via the adapter interface and translates them into calls to the wrapped service object in a format it can understand.

- More info: [Adapter](https://refactoring.guru/design-patterns/adapter)