using Alexa.NET.ProactiveEvents.WeatherAlerts;

namespace Alexa.NET.ProactiveEvents
{
    public class WeatherAlert : ProactiveEvent<WeatherAlertPayload>
    {
        public WeatherAlert():base("AMAZON.WeatherAlert.Activated") { }

        public WeatherAlert(WeatherAlertType type, string source = null)
        :this(new WeatherAlertPayload(new WeatherAlertPayloadData(type, source)))
        {
            
        }

        public WeatherAlert(WeatherAlertPayload payload):this()
        {
            Payload = payload;
        }
    }
}
