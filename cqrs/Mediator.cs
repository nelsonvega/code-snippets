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
}





