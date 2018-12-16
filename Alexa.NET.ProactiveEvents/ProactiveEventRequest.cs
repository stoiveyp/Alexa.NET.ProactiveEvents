using System;
using System.Collections.Generic;
using System.Linq;
using Alexa.NET.ProactiveEvents.AudienceTypes;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    public abstract class ProactiveEventRequest<TAudienceType> : ProactiveEventRequest where TAudienceType : AudienceType
    {
        [JsonProperty("relevantAudience")]
        public TAudienceType Audience { get; protected set; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    public abstract class ProactiveEventRequest
    {
        [JsonProperty("timestamp")]
        public DateTimeOffset TimeStamp { get; set; }
        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
        [JsonProperty("expiryTime")]
        public DateTimeOffset ExpiryTime { get; set; }
        [JsonProperty("event")]
        public ProactiveEvent Event { get; set; }
        [JsonProperty("localizedAttributes",NullValueHandling = NullValueHandling.Ignore)]
        public List<LocaleAttributes> LocaleAttributes { get; set; }

        public bool ShouldSerializeLocalizedAttributes()
        {
            return LocaleAttributes?.Any() ?? false;
        }
    }
}
