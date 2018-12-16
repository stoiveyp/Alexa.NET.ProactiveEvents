using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class SubscribedEvent
    {
        [JsonProperty("eventName")]
        public string EventName { get; set; }
    }
}