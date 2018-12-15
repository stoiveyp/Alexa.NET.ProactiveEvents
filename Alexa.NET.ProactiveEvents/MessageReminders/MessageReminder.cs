namespace Alexa.NET.ProactiveEvents.MessageReminders
{
    public class MessageReminder:ProactiveEvent<MessageReminderPayload>
    {
        public MessageReminder():base("AMAZON.MessageAlert.Activated") { }

        public MessageReminder(MessageReminderState state, MessageReminderGroup group):this(new MessageReminderPayload(state,group))
        {
            
        }

        public MessageReminder(MessageReminderPayload payload):this()
        {
            Payload = payload;
        }
    }
}
