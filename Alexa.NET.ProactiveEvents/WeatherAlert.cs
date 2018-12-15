using Alexa.NET.ProactiveEvents.WeatherAlerts;

namespace Alexa.NET.ProactiveEvents
{
    public class WeatherAlert : ProactiveEvent<WeatherAlertPayload>
    {
        public WeatherAlert() { }

        public WeatherAlert(WeatherAlertType type, string source = null)
        {
            Payload = new WeatherAlertPayload(new WeatherAlertPayloadData(type, source));
        }

        public WeatherAlert(WeatherAlertPayload payload)
        {
            Payload = payload;
        }

        public override string Name => "AMAZON.WeatherAlert.Activated";
    }
}
