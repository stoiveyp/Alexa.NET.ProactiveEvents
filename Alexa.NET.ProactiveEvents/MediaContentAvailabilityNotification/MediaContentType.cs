using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.MediaContentAvailabilityNotification
{
    public enum MediaContentType
    {
        [EnumMember(Value = "BOOK")] Book,
        [EnumMember(Value = "EPISODE")] Episode,
        [EnumMember(Value = "ALBUM")] Album,
        [EnumMember(Value = "SINGLE")] Single,
        [EnumMember(Value = "MOVIE")] Movie,
        [EnumMember(Value = "GAME")] Game
    }
}