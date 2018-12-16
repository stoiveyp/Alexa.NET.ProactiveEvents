using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public class ReservationState
    {
        public ReservationState(ReservationConfirmationStatus status)
        {
            ConfirmationStatus = status;
        }

        [JsonProperty("confirmationStatus"), JsonConverter(typeof(StringEnumConverter))]
        public ReservationConfirmationStatus ConfirmationStatus { get; set; }
    }
}