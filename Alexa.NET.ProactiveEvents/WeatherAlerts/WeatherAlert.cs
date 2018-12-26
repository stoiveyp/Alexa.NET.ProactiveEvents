

using System.Collections.Generic;

namespace Alexa.NET.ProactiveEvents.WeatherAlerts
{
    public class WeatherAlert : ProactiveEvent<WeatherAlertPayload>
    {
        public WeatherAlert():base("AMAZON.WeatherAlert.Activated") { }

        public WeatherAlert(WeatherAlertType type, LocaleAttributes source = null)
        :this(new WeatherAlertPayload(new WeatherAlertPayloadData(type, source)))
        {
            
        }

        public WeatherAlert(WeatherAlertPayload payload):this()
        {
            Payload = payload;
        }

        public override IEnumerable<KeyValuePair<string, List<LocaleAttribute>>> GetLocales()
        {
            if (Payload.WeatherAlert.Source == null)
            {
                return new KeyValuePair<string, List<LocaleAttribute>>[]{};
            }

            return new[]
            {
                new KeyValuePair<string, List<LocaleAttribute>>("source", this.Payload.WeatherAlert.Source),
            };
        }
    }
}
