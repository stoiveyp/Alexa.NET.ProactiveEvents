using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreEventLeague
    {
        public SoccerScoreEventLeague(string name)
        {
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}