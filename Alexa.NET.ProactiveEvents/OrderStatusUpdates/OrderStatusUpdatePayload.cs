﻿using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class OrderStatusUpdatePayload
    {
        public class OrderDetail
        {
            public OrderDetail(string sellerName)
            {
                Seller = new OrderDetailSeller(sellerName);
            }

            [JsonProperty("seller")]
            public OrderDetailSeller Seller { get; }
            public class OrderDetailSeller
            {
                public OrderDetailSeller(string name)
                {
                    Name = name;
                }
                [JsonProperty("name")]
                public string Name { get; }
            }
        }
        public OrderStatusUpdatePayload(string sellerName, OrderState state)
        {
            State = state;
            Order = new OrderDetail(sellerName);
        }

        public OrderStatusUpdatePayload(string sellerName, OrderStatus status) : this(sellerName, new OrderState(status))
        {

        }

        [JsonProperty("state")]
        public OrderState State { get; }

        [JsonProperty("order")]
        public OrderDetail Order { get; }
    }
}