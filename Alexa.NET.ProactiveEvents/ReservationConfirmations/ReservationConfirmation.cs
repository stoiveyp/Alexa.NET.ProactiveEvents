using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public class ReservationConfirmation : ProactiveEvent<ReservationConfirmationPayload>
    {
        public ReservationConfirmation() : base("AMAZON.Occasion.Updated")
        {
        }

        public ReservationConfirmation(ConfirmationStatus status, Occasion occasion):this()
        {
            Payload = new ReservationConfirmationPayload(status,occasion);
        }
    }
}