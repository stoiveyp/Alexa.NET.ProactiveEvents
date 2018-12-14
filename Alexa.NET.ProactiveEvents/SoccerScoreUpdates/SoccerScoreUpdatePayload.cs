using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreUpdatePayload
    {
        public SoccerScoreUpdatePayload() { }

        public SoccerScoreUpdatePayload(SoccerScoreUpdateDetail update, SoccerScoreSportsEvent eventInformation)
        {
            Update = update;
            Event = eventInformation;
        }

        [JsonProperty("update")]
        public SoccerScoreUpdateDetail Update { get; set; }

        [JsonProperty("sportsEvent")]
        public SoccerScoreSportsEvent Event { get; set; }
    }
}
