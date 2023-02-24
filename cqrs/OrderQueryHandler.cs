namespace CQRS
{
    public class OrderQueryHandler:IQueryHandler<GetOrderQuery,Order>
    {
        public Order Handle(GetOrderQuery query)
        {
            // retrieve the order
            return new Order();
        }
    }
}