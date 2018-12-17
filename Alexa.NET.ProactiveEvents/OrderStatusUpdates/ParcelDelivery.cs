using System;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.OrderStatusUpdates
{
    public class ParcelDelivery
    {
        [JsonProperty("expectedArrival",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(EventIsoDateTimeConverter))]
        public DateTimeOffset? ExpectedArrival { get; set; }
        [JsonProperty("enterTimestamp",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(EventIsoDateTimeConverter))]
        public DateTimeOffset? EnterTimestamp { get; set; }
    }
}