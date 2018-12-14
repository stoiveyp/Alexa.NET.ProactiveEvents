using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public abstract class ProactiveEvent
    {
        [JsonProperty("name")]
        public abstract string Name { get; }
    }

    public abstract class ProactiveEvent<T> : ProactiveEvent where T:IProactiveEventPayload
    {
        [JsonProperty("payload")]
        public T Payload { get; set; }
    }
}