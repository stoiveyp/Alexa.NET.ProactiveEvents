using System.Runtime.Serialization;

namespace Alexa.NET.ProactiveEvents.MessageReminders
{
    public enum MessageReminderStatus
    {
        [EnumMember(Value = "UNREAD")] Unread,
        [EnumMember(Value = "FLAGGED")] Flagged
    }
}