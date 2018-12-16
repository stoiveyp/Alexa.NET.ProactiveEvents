using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.MessageReminders
{
    public enum MessageReminderFreshness
    {
        [EnumMember(Value = "NEW")] New,
        [EnumMember(Value = "OVERDUE")] Overdue
    }
}