## CQRS 

### which stands for Command Query Responsibility Segregation, is an architectural pattern that separates the read and write operations of an application into two separate models. Here are 10 steps to understanding CQRS:

* The traditional architecture of a software application involves a single model that handles both read and write operations.

* With CQRS, the read and write operations are separated into two models - the Command Model and the Query Model.

* The Command Model is responsible for handling all the write operations. It receives commands from the application and updates the data store.

* The Query Model is responsible for handling all the read operations. It receives queries from the application and returns data from the data store.

* The Command Model and the Query Model can use different data stores. For example, the Command Model can use a relational database, while the Query Model can use a NoSQL database.

* The Command Model and the Query Model can also have different data structures. For example, the Command Model can use normalized data structures, while the Query Model can use denormalized data structures optimized for fast queries.

* The Command Model can validate and enforce business rules before updating the data store.

* The Query Model can use caching to improve performance and reduce the load on the data store.

* The Command Model and the Query Model can be scaled independently. For example, the Query Model can be replicated to handle read-heavy workloads, while the Command Model can be replicated to handle write-heavy workloads.

* CQRS is not a silver bullet and should be used only when the benefits outweigh the costs. It adds complexity to the application and requires careful design and implementation. It is most useful in applications with complex business logic and high read and write loads.
