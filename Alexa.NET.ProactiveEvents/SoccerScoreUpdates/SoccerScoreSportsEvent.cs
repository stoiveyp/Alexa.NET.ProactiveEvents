using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.SoccerScoreUpdates
{
    public class SoccerScoreSportsEvent
    {
        public SoccerScoreSportsEvent(LocaleAttributes leagueName, SoccerScoreTeamStatistics homeTeam, SoccerScoreTeamStatistics awayTeam)
        {
            EventLeague = new SoccerScoreEventLeague(leagueName);
            HomeTeamStatistic = homeTeam;
            AwayTeamStatistic = awayTeam;
        }

        [JsonProperty("homeTeamStatistic")]
        public SoccerScoreTeamStatistics HomeTeamStatistic { get; set; }

        [JsonProperty("awayTeamStatistic")]
        public SoccerScoreTeamStatistics AwayTeamStatistic { get; set; }

        [JsonProperty("eventLeague")]
        public SoccerScoreEventLeague EventLeague { get; set; }
    }
}
