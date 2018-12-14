using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.WeatherAlerts
{
    public class WeatherAlertPayloadData
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("alertType"), JsonConverter(typeof(StringEnumConverter))]
        public WeatherAlertType Type { get; set; }
    }
}