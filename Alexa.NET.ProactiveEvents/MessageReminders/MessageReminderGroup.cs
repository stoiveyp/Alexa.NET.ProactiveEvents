using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.MessageReminders
{
    public class MessageReminderGroup
    {
        public class MessageReminderCreatorName
        {
            public MessageReminderCreatorName(string name)
            {
                Name = name;
            }

            [JsonProperty("name")]
            public string Name { get; }
        }

        public MessageReminderGroup(string creatorName, int count, MessageReminderUrgency? urgency)
        {
            CreatorName = new MessageReminderCreatorName(creatorName);
            Count = count;
            Urgency = urgency;
        }

        [JsonProperty("creator")]
        public MessageReminderCreatorName CreatorName { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("urgency",NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(StringEnumConverter))]
        public MessageReminderUrgency? Urgency { get; set; }
    }
}