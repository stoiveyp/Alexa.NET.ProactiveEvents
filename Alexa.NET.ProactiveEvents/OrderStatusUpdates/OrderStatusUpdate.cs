using System.Collections.Generic;

namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class OrderStatusUpdate:ProactiveEvent<OrderStatusUpdatePayload>
    {
        public OrderStatusUpdate() : base("AMAZON.OrderStatus.Updated") { }

        public OrderStatusUpdate(LocaleAttributes sellerName, OrderState state):this()
        {
            Payload = new OrderStatusUpdatePayload(sellerName,state);
        }

        public OrderStatusUpdate(LocaleAttributes sellerName, OrderStatus status) : this(sellerName, new OrderState(status))
        {

        }

        public override IEnumerable<KeyValuePair<string, List<LocaleAttribute>>> GetLocales()
        {
            return new[]
            {
                new KeyValuePair<string, List<LocaleAttribute>>("sellerName", this.Payload.Order.Seller.Name),
            };
        }
    }
}
