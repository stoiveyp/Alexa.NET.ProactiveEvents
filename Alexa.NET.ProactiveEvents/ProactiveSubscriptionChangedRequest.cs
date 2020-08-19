using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class ProactiveSubscriptionChangedRequest : Request.Type.Request
    {
        [JsonProperty("body")]
        public SubscriptionChangedBody Body { get; set; }
    }
}