using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.MediaContentAvailabilityNotification
{
    public enum MediaContentMethod
    {
        [EnumMember(Value = "STREAM")] Stream,
        [EnumMember(Value = "AIR")] Air,
        [EnumMember(Value = "RELEASE")] Release,
        [EnumMember(Value = "PREMIERE")] Premiere,
        [EnumMember(Value = "DROP")] Drop
    }
}