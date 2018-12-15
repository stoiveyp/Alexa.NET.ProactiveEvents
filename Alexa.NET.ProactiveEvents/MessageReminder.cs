using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.ProactiveEvents.MessageReminders;

namespace Alexa.NET.ProactiveEvents
{
    public class MessageReminder:ProactiveEvent<MessageReminderPayload>
    {
        public MessageReminder() { }

        public MessageReminder(MessageReminderState state, MessageReminderGroup group):this(new MessageReminderPayload(state,group))
        {
            
        }

        public MessageReminder(MessageReminderPayload payload)
        {
            Payload = payload;
        }

        public override string Name => "AMAZON.MessageAlert.Activated";
    }
}
