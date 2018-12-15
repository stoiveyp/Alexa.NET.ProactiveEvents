using Alexa.NET.ProactiveEvents.SoccerScoreUpdates;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class SoccerScoreUpdate:ProactiveEvent<SoccerScoreUpdatePayload>
    {
        public SoccerScoreUpdate() { }

        public SoccerScoreUpdate(SoccerScoreUpdatePayload payload)
        {
            Payload = payload;
        }

        public SoccerScoreUpdate(SoccerScoreSportsEvent eventInformation)
        {
            Payload = new SoccerScoreUpdatePayload(eventInformation);
        }

        public SoccerScoreUpdate(SoccerScoreUpdateDetail update, SoccerScoreSportsEvent eventInformation)
        {
            Payload = new SoccerScoreUpdatePayload(eventInformation,update);
        }

        [JsonProperty("name")]
        public override string Name => "AMAZON.SportsEvent.Updated";
    }
}
