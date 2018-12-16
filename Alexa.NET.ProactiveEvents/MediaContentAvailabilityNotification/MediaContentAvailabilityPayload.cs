using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.MediaContentAvailabilityNotification
{
    public class MediaContentAvailabilityPayload
    {
        public MediaContentAvailabilityPayload(MediaContentAvailabilityDetail detail, MediaContent content)
        {
            Detail = detail;
            Content = content;
        }

        [JsonProperty("availability")]
        public MediaContentAvailabilityDetail Detail { get; set; }

        [JsonProperty("content")]
        public MediaContent Content { get; set; }
    }
}