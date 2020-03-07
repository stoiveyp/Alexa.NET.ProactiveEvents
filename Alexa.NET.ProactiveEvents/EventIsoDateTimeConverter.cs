using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents
{
    internal class EventIsoDateTimeConverter : IsoDateTimeConverter
    {
        public EventIsoDateTimeConverter()
        {
            Culture = System.Globalization.CultureInfo.InvariantCulture;
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ssK";
        }
    }
}