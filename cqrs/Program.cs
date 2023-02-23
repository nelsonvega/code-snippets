 internal class Program
    {
        static void Main(string[] args)
        {
           var mediator = new Mediator();
            mediator.RegisterHandler<OrderCommandHandler, CreateOrderCommand>();
            mediator.RegisterHandler<OrderQueryHandler, GetOrderQuery, Order>();

            mediator.Send(new CreateOrderCommand { CustomerName = "John Doe", ProductName = "Product A", Quantity = 10 });

            var order = mediator.Send(new GetOrderQuery { OrderId = 1 });
        }
    }
}





