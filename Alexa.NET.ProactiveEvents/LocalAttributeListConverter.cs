using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class LocalAttributeListConverter:JsonConverter
    {
        public override bool CanRead => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var list = (LocaleAttributeList) value;
            var keys = list.Request.Event.GetLocales();
            var locales = new Dictionary<string,LocaleAttributeCollection>();
            
            foreach (var keylist in keys)
            {
                foreach (var localeInfo in keylist.Value.Where(k => !string.IsNullOrWhiteSpace(k.Locale)))
                {
                    if (!locales.ContainsKey(localeInfo.Locale))
                    {
                        locales.Add(localeInfo.Locale,new LocaleAttributeCollection(localeInfo.Locale));
                    }

                    locales[localeInfo.Locale].Properties.Add(keylist.Key,localeInfo.Value);
                }
            }

            serializer.Serialize(writer,locales.Values);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LocaleAttributeList);
        }
    }
}