using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public abstract class ProactiveEventRequest<T> where T:AudienceType
    {
        [JsonProperty("timestamp")]
        public DateTimeOffset TimeStamp { get; set; }
        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
        [JsonProperty("expiryTime")]
        public DateTimeOffset ExpiryTime { get; set; }
        [JsonProperty("event")]
        public ProactiveEvent Event { get; set; }
        [JsonProperty("localizedAttributes")]
        public List<LocaleAttributes> LocaleAttributes { get; set; }
        [JsonProperty("relevantAudience")]
        public T Audience { get; protected set; }
    }
}
