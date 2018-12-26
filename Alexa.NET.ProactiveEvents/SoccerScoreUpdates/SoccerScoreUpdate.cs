using System.Collections.Generic;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreUpdate:ProactiveEvent<SoccerScoreUpdatePayload>
    {
        public SoccerScoreUpdate():base("AMAZON.SportsEvent.Updated") { }

        public SoccerScoreUpdate(SoccerScoreUpdatePayload payload):this()
        {
            Payload = payload;
        }

        public SoccerScoreUpdate(SoccerScoreSportsEvent eventInformation)
        :this(new SoccerScoreUpdatePayload(eventInformation))
        {
            
        }

        public SoccerScoreUpdate(SoccerScoreUpdateDetail update, SoccerScoreSportsEvent eventInformation)
        :this(new SoccerScoreUpdatePayload(eventInformation, update))
        {
            
        }

        public override IEnumerable<KeyValuePair<string, List<LocaleAttribute>>> GetLocales()
        {
            return new[]
            {
                new KeyValuePair<string, List<LocaleAttribute>>("eventLeagueName", this.Payload.Event.EventLeague.Name),
            };
        }
    }
}
