using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreTeamStatistics
    {
        public SoccerScoreTeamStatistics() { }

        public SoccerScoreTeamStatistics(string teamName, int score)
        {
            Name = new EntityName(teamName);
            Score = score;
        }

        [JsonProperty("team")]
        public EntityName Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }
}