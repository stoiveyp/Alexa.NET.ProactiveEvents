using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.AudienceTypes
{
    public class UnicastAudienceType : AudienceType
    {
        internal UnicastAudienceType(string userId)
        {
            Payload = new UnicastAudiencePayload(userId);
        }

        [JsonProperty("type")]
        public override string Type => "Unicast";
        [JsonProperty("payload")]
        public UnicastAudiencePayload Payload { get; }
    }
}