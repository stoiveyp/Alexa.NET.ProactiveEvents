using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.TrashCollectionReminders
{
    internal class GarbageSwapEnumConverter : StringEnumConverter
    {
        private enum GarbageDayOfWeek
        {
            [EnumMember(Value = "SUNDAY")] Sunday,
            [EnumMember(Value = "MONDAY")] Monday,
            [EnumMember(Value = "TUESDAY")] Tuesday,
            [EnumMember(Value = "WEDNESDAY")] Wednesday,
            [EnumMember(Value = "THURSDAY")] Thursday,
            [EnumMember(Value = "FRIDAY")] Friday,
            [EnumMember(Value = "SATURDAY")] Saturday,
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var original = base.ReadJson(reader, objectType, existingValue, serializer);
            return (DayOfWeek)original;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            base.WriteJson(writer, (GarbageDayOfWeek)value, serializer);
        }
    }
}