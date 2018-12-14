using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.WeatherAlerts
{
    public class WeatherAlertPayload: IProactiveEventPayload
    {
        public WeatherAlertPayload(WeatherAlertPayloadData data)
        {
            WeatherAlert = data;
        }

        [JsonProperty("weatherAlert")]
        public WeatherAlertPayloadData WeatherAlert { get; }
    }
}