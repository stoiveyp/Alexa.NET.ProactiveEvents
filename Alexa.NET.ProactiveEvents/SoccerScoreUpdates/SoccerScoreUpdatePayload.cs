using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreUpdatePayload
    {
        public SoccerScoreUpdatePayload() { }

        public SoccerScoreUpdatePayload(SoccerScoreSportsEvent eventInformation, SoccerScoreUpdateDetail update = null)
        {
            Update = update;
            Event = eventInformation;
        }

        [JsonProperty("sportsEvent")]
        public SoccerScoreSportsEvent Event { get; set; }

        [JsonProperty("update",NullValueHandling = NullValueHandling.Ignore)]
        public SoccerScoreUpdateDetail Update { get; set; }
    }
}
