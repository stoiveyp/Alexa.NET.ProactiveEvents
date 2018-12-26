using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.MediaContentAvailabilityNotification
{
    public class MediaContent
    {
        public MediaContent() { }

        public MediaContent(LocaleAttributes name, MediaContentType contentType)
        {
            Name = name;
            ContentType = contentType;
        }

        [JsonProperty("name"), JsonConverter(typeof(LocaleAttributeConverter), "contentName")]
        public LocaleAttributes Name { get; set; }

        [JsonProperty("contentType"), JsonConverter(typeof(StringEnumConverter))]
        public MediaContentType ContentType { get; set; }
    }
}