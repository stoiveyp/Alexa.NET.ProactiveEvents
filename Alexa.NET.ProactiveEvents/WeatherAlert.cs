using Alexa.NET.ProactiveEvents.WeatherAlerts;

namespace Alexa.NET.ProactiveEvents
{
    public class WeatherAlert:ProactiveEvent<WeatherAlertPayload>
    {
        public WeatherAlert() { }

        public WeatherAlert(WeatherAlertPayload payload)
        {
            Payload = payload;
        }

        public WeatherAlert(WeatherAlertPayloadData data)
        {
            Payload = new WeatherAlertPayload(data);
        }

        public override string Name => "AMAZON.WeatherAlert.Activated";
    }
}
