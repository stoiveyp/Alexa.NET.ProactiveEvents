using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public enum ConfirmationStatus
    {
        [EnumMember(Value = "CONFIRMED")] Confirmed,
        [EnumMember(Value = "CANCELED")] Canceled,
        [EnumMember(Value = "RESCHEDULED")] Rescheduled,
        [EnumMember(Value = "REQUESTED")] Requested,
        [EnumMember(Value = "CREATED")] Created,
        [EnumMember(Value = "UPDATED")] Updated
    }
}