using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class OrderState
    {
        public OrderState() { }

        public OrderState(OrderStatus status, ParcelDelivery deliveryDetails = null)
        {
            DeliveryDetails = deliveryDetails;
            Status = status;
        }

        [JsonProperty("deliveryDetails",NullValueHandling = NullValueHandling.Ignore)]
        public ParcelDelivery DeliveryDetails { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStatus Status { get; set; }
    }
}