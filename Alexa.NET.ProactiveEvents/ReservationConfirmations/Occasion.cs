using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public class Occasion
    {
        public Occasion() { }

        public Occasion(OccasionType type,
            DateTimeOffset bookingTime,
            string providerName,
            string subject)
        {
            Type = type;
            BookingTime = bookingTime;
            Provider = new EntityName(providerName);
            Subject = subject;
        }

        public Occasion(OccasionType type,
            DateTimeOffset bookingTime,
            string providerName,
            string subject,
            string brokerName) : this(type, bookingTime, providerName, subject)
        {
            Broker = new EntityName(brokerName);
        }

        [JsonProperty("occasionType"), JsonConverter(typeof(StringEnumConverter))]
        public OccasionType Type { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("provider")]
        public EntityName Provider { get; set; }

        [JsonProperty("broker", NullValueHandling = NullValueHandling.Ignore)]
        public EntityName Broker { get; set; }

        [JsonProperty("bookingTime")]
        public DateTimeOffset BookingTime { get; set; }
    }
}