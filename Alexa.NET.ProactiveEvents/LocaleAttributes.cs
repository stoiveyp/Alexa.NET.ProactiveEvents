using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class LocaleAttributes
    {
        public LocaleAttributes(string locale)
        {
            Locale = locale;
        }

        [JsonProperty("locale")]
        public string Locale { get; }

        [JsonExtensionData]
        public Dictionary<string,object> Properties { get; set; } = new Dictionary<string, object>();
    }
}