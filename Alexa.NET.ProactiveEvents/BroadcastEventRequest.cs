using Alexa.NET.ProactiveEvents.AudienceTypes;

namespace Alexa.NET.ProactiveEvents
{
    public class BroadcastEventRequest : ProactiveEventRequest<MulticastAudienceType>
    {
        public BroadcastEventRequest()
        {
            Audience = new MulticastAudienceType();
        }
    }
}