using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class SubscriptionChangedBody
    {
        [JsonProperty("subscriptions")]
        public SubscribedEvent[] Subscriptions { get; set; }
    }
}