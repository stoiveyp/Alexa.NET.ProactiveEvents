using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public class ReservationConfirmation : ProactiveEvent<ReservationConfirmationPayload>
    {
        public ReservationConfirmation() : base("AMAZON.Occasion.Updated")
        {
        }

        public ReservationConfirmation(ReservationConfirmationStatus status, Occasion occasion):this()
        {
            Payload = new ReservationConfirmationPayload(status,occasion);
        }

        public override IEnumerable<KeyValuePair<string, List<LocaleAttribute>>> GetLocales()
        {
            var keyvalues = new Dictionary<string, List<LocaleAttribute>>();
            if (Payload.Occasion.Broker != null)
            {
                keyvalues.Add("brokerName",Payload.Occasion.Broker.Name);
            }
            keyvalues.Add("subject",Payload.Occasion.Subject);
            keyvalues.Add("providerName", Payload.Occasion.Provider.Name);

            return keyvalues;
        }
    }
}