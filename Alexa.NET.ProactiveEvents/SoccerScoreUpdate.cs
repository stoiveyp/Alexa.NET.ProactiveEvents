using Alexa.NET.ProactiveEvents.SoccerScoreUpdates;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
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
    }
}
