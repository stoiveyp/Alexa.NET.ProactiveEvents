using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.WeatherAlerts
{
    public class WeatherAlertPayloadData
    {
        public WeatherAlertPayloadData(WeatherAlertType type, string source = null)
        {
            Type = type;
            Source = source;
        }

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; }

        [JsonProperty("alertType"), JsonConverter(typeof(StringEnumConverter))]
        public WeatherAlertType Type { get; }
    }
}