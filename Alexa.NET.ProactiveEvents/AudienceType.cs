using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public abstract class AudienceType
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}