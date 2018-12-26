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
            LocaleAttributes providerName,
            LocaleAttributes subject)
        {
            Type = type;
            BookingTime = bookingTime;
            Provider = new ProviderName(providerName);
            Subject = subject;
        }

        public Occasion(OccasionType type,
            DateTimeOffset bookingTime,
            LocaleAttributes providerName,
            LocaleAttributes subject,
            LocaleAttributes brokerName) : this(type, bookingTime, providerName, subject)
        {
            Broker = new BrokerName(brokerName);
        }

        [JsonProperty("occasionType"), JsonConverter(typeof(StringEnumConverter))]
        public OccasionType Type { get; set; }

        [JsonProperty("subject"), JsonConverter(typeof(LocaleAttributeConverter), "subject")]
        public LocaleAttributes Subject { get; set; }

        [JsonProperty("provider")]
        public ProviderName Provider { get; set; }

        [JsonProperty("broker", NullValueHandling = NullValueHandling.Ignore)]
        public BrokerName Broker { get; set; }

        [JsonProperty("bookingTime")]
        [JsonConverter(typeof(EventIsoDateTimeConverter))]
        public DateTimeOffset BookingTime { get; set; }
    }
}