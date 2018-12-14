using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class UnicastAudiencePayload
    {
        public UnicastAudiencePayload() { }
        public UnicastAudiencePayload(string user)
        {
            User = user;
        }
        [JsonProperty("user")]
        public string User { get; set; }
    }
}