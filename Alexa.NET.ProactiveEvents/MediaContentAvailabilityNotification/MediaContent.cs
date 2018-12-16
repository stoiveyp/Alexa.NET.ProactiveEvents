using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.MediaContentAvailabilityNotification
{
    public class MediaContent : EntityName
    {
        public MediaContent() { }

        public MediaContent(string name, MediaContentType contentType)
        {
            Name = name;
            ContentType = contentType;
        }

        [JsonProperty("contentType"), JsonConverter(typeof(StringEnumConverter))]
        public MediaContentType ContentType { get; set; }
    }
}