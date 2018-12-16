using System;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class ParcelDelivery
    {
        [JsonProperty("expectedArrival",NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpectedArrival { get; set; }
        [JsonProperty("enterTimestamp",NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EnterTimestamp { get; set; }
    }
}