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

        public MediaContentAvailabilityDetail(DateTimeOffset startTime, MediaContentMethod method, LocaleAttributes providerName)
            : this(startTime, method)
        {
            Provider = new ProviderName(providerName);
        }

        [JsonProperty("method"), JsonConverter(typeof(StringEnumConverter))]
        public MediaContentMethod Method { get; set; }

        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderName Provider { get; set; }
    }
}