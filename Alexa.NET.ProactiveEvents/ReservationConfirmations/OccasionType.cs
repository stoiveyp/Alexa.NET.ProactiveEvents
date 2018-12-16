using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.ReservationConfirmations
{
    public enum OccasionType
    {
        [EnumMember(Value = "RESERVATION_REQUEST")]
        ReservationRequest,
        [EnumMember(Value = "RESERVATION")]
        Reservation,
        [EnumMember(Value = "APPOINTMENT_REQUEST")]
        AppointmentRequest,
        [EnumMember(Value = "APPOINTMENT")]
        Appointment
    }
}