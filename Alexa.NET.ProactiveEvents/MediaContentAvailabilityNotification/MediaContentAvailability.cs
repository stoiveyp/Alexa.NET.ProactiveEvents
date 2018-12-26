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

        public override IEnumerable<KeyValuePair<string, List<LocaleAttribute>>> GetLocales()
        {
            return new[]
            {
                new KeyValuePair<string, List<LocaleAttribute>>("contentName", Payload.Content.Name),
                new KeyValuePair<string, List<LocaleAttribute>>("providerName", Payload.Detail.Provider.Name),
            };
        }
    }
}
