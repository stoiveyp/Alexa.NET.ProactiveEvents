using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreEventLeague
    {
        public SoccerScoreEventLeague(LocaleAttributes name)
        {
            Name = name;
        }

        public SoccerScoreEventLeague(LocaleAttribute name)
        {
            Name = new LocaleAttributes(name);
        }

        [JsonProperty("name"),JsonConverter(typeof(LocaleAttributeConverter), "eventLeagueName")]
        public LocaleAttributes Name { get; set; }
    }
}