using System;
using System.Globalization;
using System.Linq;
using Alexa.NET.ProactiveEvents.AudienceTypes;
using Alexa.NET.ProactiveEvents.SocialGameInvites;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        protected ProactiveEventRequest()
        {
            LocaleAttributes = new LocaleAttributeList(this);
        }

        [JsonProperty("timestamp"),JsonConverter(typeof(EventIsoDateTimeConverter))]
        public DateTimeOffset TimeStamp { get; set; }
        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
        [JsonProperty("expiryTime"), JsonConverter(typeof(EventIsoDateTimeConverter))]
        public DateTimeOffset ExpiryTime { get; set; }
        [JsonProperty("event")]
        public ProactiveEvent Event { get; set; }

        [JsonProperty("localizedAttributes"),JsonConverter(typeof(LocalAttributeListConverter))]
        public LocaleAttributeList LocaleAttributes { get; }
    }

    public class LocaleAttributeList
    {
        internal ProactiveEventRequest Request { get; }
        public LocaleAttributeList(ProactiveEventRequest proactiveEventRequest)
        {
            Request = proactiveEventRequest;
        }
    }
}
