using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class LocaleAttributeConverter : JsonConverter
    {
        public string AttributeName { get; set; }
        public LocaleAttributeConverter(string attributeName)
        {
            AttributeName = attributeName;
        }

        public override bool CanRead => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue("localizedattribute:" + AttributeName);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LocaleAttributes);
        }
    }
}
