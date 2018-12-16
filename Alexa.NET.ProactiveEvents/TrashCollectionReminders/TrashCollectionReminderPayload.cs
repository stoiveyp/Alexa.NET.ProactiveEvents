using System;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.TrashCollectionReminders
{
    public class TrashCollectionReminderPayload
    {
        public TrashCollectionReminderPayload() { }

        public TrashCollectionReminderPayload(DayOfWeek collectionDay, GarbageType[] garbageTypes)
        {
            Alert = new TrashCollectionReminderAlert(collectionDay, garbageTypes);
        }

        [JsonProperty("alert")]
        public TrashCollectionReminderAlert Alert { get; set; }
    }
}