public class Mediator
{
    private readonly Dictionary<Type, object> handlers = new Dictionary<Type, object>();

    public void RegisterHandler<THandler, TMessage>()
        where THandler : IHandler<TMessage>, new()
        where TMessage : class
    {
        handlers.Add(typeof(TMessage), new THandler());
    }

    public void Send<TMessage>(TMessage message) where TMessage : class
    {
        var handler = handlers[typeof(TMessage)] as IHandler<TMessage>;
        handler.Handle(message);
    }
}

public interface IHandler<T>
{
    void Handle(T message);
}

public class OrderCommandHandler : IHandler<CreateOrderCommand>
{
    public void Handle(CreateOrderCommand message)
    {
        // create the order
    }
}

public class OrderQueryHandler : IHandler<GetOrderQuery, Order>
{
    public Order Handle(GetOrderQuery message)
    {
        // retrieve the order
        return new Order();
    }
}
Finally, we can use the mediator to dispatch commands and queries:

csharp
Copy code
var mediator = new Mediator();
mediator.RegisterHandler<OrderCommandHandler, CreateOrderCommand>();
mediator.RegisterHandler<OrderQueryHandler, GetOrderQuery, Order>();

mediator.Send(new CreateOrderCommand { CustomerName = "John Doe", ProductName = "Product A", Quantity = 10 });

var order = mediator.Send(new GetOrderQuery { OrderId = 1 });
This is a simple example, but it should give you an idea of how to implement CQRS pattern in C#. Of course, in a real-world application, you would typically have more complex commands and queries, as well as more complex handlers and a more sophisticated mediator.




