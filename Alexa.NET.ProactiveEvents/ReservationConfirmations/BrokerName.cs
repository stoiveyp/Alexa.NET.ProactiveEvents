using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public class BrokerName
    {
        public BrokerName() { }

        public BrokerName(LocaleAttributes name)
        {
            Name = name;
        }

        [JsonProperty("name"), JsonConverter(typeof(LocaleAttributeConverter), "brokerName")]
        public LocaleAttributes Name { get; set; }
    }
}