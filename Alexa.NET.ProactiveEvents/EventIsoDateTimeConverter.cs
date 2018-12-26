using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents
{
    internal class EventIsoDateTimeConverter : IsoDateTimeConverter
    {
        public EventIsoDateTimeConverter()
        {
            //  DateTimeStyles = DateTimeStyles.AdjustToUniversal;
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ssK";
        }
    }
}