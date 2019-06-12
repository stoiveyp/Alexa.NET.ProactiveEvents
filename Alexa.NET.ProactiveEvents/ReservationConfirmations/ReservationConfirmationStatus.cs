using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public enum ReservationConfirmationStatus
    {
        [EnumMember(Value = "CONFIRMED")] Confirmed,
        [EnumMember(Value = "CANCELED")] Canceled,
        [EnumMember(Value = "RESCHEDULED")] Rescheduled,
        [EnumMember(Value = "RECEIVED")] Received,
        [EnumMember(Value = "CREATED")] Created,
        [EnumMember(Value = "UPDATED")] Updated
    }
}