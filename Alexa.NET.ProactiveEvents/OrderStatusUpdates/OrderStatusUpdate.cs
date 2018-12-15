namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class OrderStatusUpdate:ProactiveEvent<OrderStatusUpdatePayload>
    {
        public OrderStatusUpdate() : base("AMAZON.OrderStatus.Updated") { }
    }
}
