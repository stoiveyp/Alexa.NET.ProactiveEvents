using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreTeamName
    {
        public SoccerScoreTeamName() { }

        public SoccerScoreTeamName(string name)
        {
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}