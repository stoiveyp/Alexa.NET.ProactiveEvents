using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.TrashCollectionReminders
{
    public class TrashCollectionReminderAlert
    {
        public TrashCollectionReminderAlert(DayOfWeek collectionDay, GarbageType[] garbageTypes)
        {
            CollectionDay = collectionDay;
            GarbageTypes = garbageTypes;
        }

        [JsonProperty("garbageTypes", ItemConverterType = typeof(StringEnumConverter))]
        public GarbageType[] GarbageTypes { get; set; }

        [JsonProperty("collectionDayOfWeek"),JsonConverter(typeof(GarbageSwapEnumConverter))]
        public DayOfWeek CollectionDay { get; set; }
    }
}