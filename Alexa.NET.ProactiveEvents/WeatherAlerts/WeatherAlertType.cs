using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.WeatherAlerts
{
    public enum WeatherAlertType
    {
        [EnumMember(Value = "TORNADO")]
        Tornado,
        [EnumMember(Value = "HURRICANE")]
        Hurricane,
        [EnumMember(Value = "SNOW_STORM")]
        Snowstorm,
        [EnumMember(Value = "THUNDER_STORM")]
        Thunderstorm
    }
}