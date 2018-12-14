using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public abstract class ProactiveEvent
    {
        [JsonProperty("name")]
        public abstract string Name { get; }
    }

    public abstract class ProtactiveEvent<T> : ProactiveEvent where T:IProactiveEventPayload
    {
        [JsonProperty("payload")]
        public abstract T Payload { get; set; }
    }
}