using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreUpdateDetail
    {
        public SoccerScoreUpdateDetail() { }

        public SoccerScoreUpdateDetail(string teamName, int scoreEarned)
        {

            TeamName = teamName;
            ScoreEarned = scoreEarned;
        }

        [JsonProperty("scoreEarned")]
        public int ScoreEarned { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }
    }
}
