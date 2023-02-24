using System.Buffers;

namespace CQRS
{
    public class Mediator
    {
        private readonly Dictionary<Type, object> handlers = new Dictionary<Type, object>();

        public void RegisterHandler<ICommandHandler, TMessage>()
            where ICommandHandler : ICommandHandler<TMessage>, new()
            where TMessage : class
        {
            handlers.Add(typeof(TMessage), new ICommandHandler());
        }
        public void RegisterHandler<IQueryHandler, TMessage,TData>()
            where IQueryHandler : IQueryHandler<TMessage,TData>, new()
            where TMessage : class
        {
            handlers.Add(typeof(TMessage), new IQueryHandler());
        }

        public void Send<TMessage>(TMessage message) where TMessage : class
        {
            var handler = handlers[typeof(TMessage)] as ICommandHandler<TMessage>;
            handler?.Handle(message);
        }
        public TData? Send<TMessage,TData>(TMessage message) where TMessage : class where  TData:class
        {
            var handler = handlers[typeof(TMessage)] as IQueryHandler<TMessage,TData> ;
            return handler?.Handle(message);
        }

      

       

        public class OrderCommandHandler : ICommandHandler<CreateOrderCommand>
        {
            public void Handle(CreateOrderCommand message)
            {
                // create the order
            }
        }

        public class OrderQueryHandler : IQueryHandler<GetOrderQuery, Order>
        {
            public Order Handle(GetOrderQuery message)
            {
                // retrieve the order
                return new Order();
            }

        }
    }
}





