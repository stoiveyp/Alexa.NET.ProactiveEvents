using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public class ReservationConfirmationPayload
    {
        ReservationConfirmationPayload() { }

        public ReservationConfirmationPayload(ConfirmationStatus status, Occasion occasion)
        {
            State = new ReservationState(status);
            Occasion = occasion;
        }

        [JsonProperty("state")] public ReservationState State { get; set; }

        [JsonProperty("occasion")] public Occasion Occasion { get; set; }
    }
}