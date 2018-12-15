using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Alexa.NET.ProactiveEvents.MessageReminders;

namespace Alexa.NET.ProactiveEvents
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
