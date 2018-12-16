using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.MessageReminders
{
    public class MessageReminderGroup
    {
        public MessageReminderGroup(string creatorName, int count, MessageReminderUrgency? urgency)
        {
            CreatorName = new EntityName(creatorName);
            Count = count;
            Urgency = urgency;
        }

        [JsonProperty("creator")]
        public EntityName CreatorName { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("urgency",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(StringEnumConverter))]
        public MessageReminderUrgency? Urgency { get; set; }
    }
}