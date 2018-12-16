using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.ProactiveEvents.MediaContentAvailabilityNotification
{
    public class MediaContentAvailability : ProactiveEvent<MediaContentAvailabilityPayload>
    {
        public MediaContentAvailability() : base("AMAZON.MediaContent.Available")
        {
        }

        public MediaContentAvailability(MediaContentAvailabilityDetail availability, MediaContent content):this()
        {
            Payload = new MediaContentAvailabilityPayload(availability, content);
        }


    }
}
