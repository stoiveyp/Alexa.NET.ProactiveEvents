using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public class ReservationState
    {
        public ReservationState(ConfirmationStatus status)
        {
            ConfirmationStatus = status;
        }

        [JsonProperty("confirmationStatus"), JsonConverter(typeof(StringEnumConverter))]
        public ConfirmationStatus ConfirmationStatus { get; set; }
    }
}