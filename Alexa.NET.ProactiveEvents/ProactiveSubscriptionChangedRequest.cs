using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class ProactiveSubscriptionChangedRequest : Request.Type.Request
    {
        [JsonProperty("subscriptions")]
        public SubscribedEvent[] Subscriptions { get; set; }
    }
}