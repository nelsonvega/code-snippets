namespace CQRS
{
    public class OrderCommandHandler:ICommandHandler<CreateOrderCommand>
    {
        public void Handle(CreateOrderCommand command)
        {
            // create the order
        }

       
    }
}
