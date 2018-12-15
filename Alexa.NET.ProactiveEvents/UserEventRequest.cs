using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.ProactiveEvents.AudienceTypes;

namespace Alexa.NET.ProactiveEvents
{
    public class UserEventRequest : ProactiveEventRequest<UnicastAudienceType>
    {
        public UserEventRequest(string userId)
        {
            Audience = new UnicastAudienceType(userId);
        }

        public UserEventRequest(string userId, ProactiveEvent proactiveEvent) : this(userId)
        {
            Event = proactiveEvent;
        }
    }
}
