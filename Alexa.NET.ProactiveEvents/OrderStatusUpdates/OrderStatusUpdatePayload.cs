using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class OrderStatusUpdatePayload
    {
        public class OrderDetail
        {
            public OrderDetail(LocaleAttributes sellerName)
            {
                Seller = new SellerName(sellerName);
            }

            [JsonProperty("seller")]
            public SellerName Seller { get; }
        }
        public OrderStatusUpdatePayload(LocaleAttributes sellerName, OrderState state)
        {
            State = state;
            Order = new OrderDetail(sellerName);
        }

        public OrderStatusUpdatePayload(LocaleAttributes sellerName, OrderStatus status) : this(sellerName, new OrderState(status))
        {

        }

        [JsonProperty("state")]
        public OrderState State { get; }

        [JsonProperty("order")]
        public OrderDetail Order { get; }
    }

    public class SellerName
    {
        public SellerName() { }

        public SellerName(LocaleAttributes name)
        {
            Name = name;
        }

        [JsonProperty("name"), JsonConverter(typeof(LocaleAttributeConverter), "sellerName")]
        public LocaleAttributes Name { get; set; }
    }
}
