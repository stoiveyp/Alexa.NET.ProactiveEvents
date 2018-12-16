using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.MediaContentAvailabilityNotification
{
    public class MediaContentAvailabilityDetail
    {
        public MediaContentAvailabilityDetail() { }
        public MediaContentAvailabilityDetail(DateTimeOffset startTime, MediaContentMethod method)
        {
            StartTime = startTime;
            Method = method;
        }

        public MediaContentAvailabilityDetail(DateTimeOffset startTime, MediaContentMethod method, string providerName)
            : this(startTime, method)
        {
            if (!string.IsNullOrWhiteSpace(providerName))
            {
                Provider = new EntityName(providerName);
            }
        }

        [JsonProperty("method"), JsonConverter(typeof(StringEnumConverter))]
        public MediaContentMethod Method { get; set; }

        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public EntityName Provider { get; set; }
    }
}