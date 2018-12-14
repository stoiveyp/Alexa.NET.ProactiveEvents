using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreTeamStatistics
    {
        public SoccerScoreTeamStatistics() { }

        public SoccerScoreTeamStatistics(string teamName, int score)
        {
            Name = new SoccerScoreTeamName(teamName);
            Score = score;
        }

        [JsonProperty("team")]
        public SoccerScoreTeamName Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }
}