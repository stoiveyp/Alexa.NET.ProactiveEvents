namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class OrderStatusUpdate:ProactiveEvent<OrderStatusUpdatePayload>
    {
        public OrderStatusUpdate() : base("AMAZON.OrderStatus.Updated") { }

        public OrderStatusUpdate(string sellerName, OrderState state):this()
        {
            Payload = new OrderStatusUpdatePayload(sellerName,state);
        }

        public OrderStatusUpdate(string sellerName, OrderStatus status) : this(sellerName, new OrderState(status))
        {

        }
    }
}
