using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.ProactiveEvents.AudienceTypes
{
    public class MulticastAudienceType : AudienceType
    {
        internal MulticastAudienceType() { }
        public override string Type => "Multicast";

        [JsonProperty("payload")]
        public EmptyAudiencePayload Payload { get; } = new EmptyAudiencePayload();
    }
}