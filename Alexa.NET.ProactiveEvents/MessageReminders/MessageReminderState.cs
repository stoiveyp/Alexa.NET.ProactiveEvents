using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.MessageReminders
{
    public class MessageReminderState
    {
        public MessageReminderState(MessageReminderStatus status, MessageReminderFreshness? freshness = null)
        {
            Status = status;
            Freshness = freshness;
        }

        [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))]
        public MessageReminderStatus Status { get; set; }

        [JsonProperty("freshness",NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringEnumConverter))]
        public MessageReminderFreshness? Freshness { get; set; }
    }
}