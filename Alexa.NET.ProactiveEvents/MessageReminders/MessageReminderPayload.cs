using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents.MessageReminders
{
    public class MessageReminderPayload
    {
        public MessageReminderPayload()
        {
        }

        public MessageReminderPayload(MessageReminderState state, MessageReminderGroup group)
        {
            State = state;
            MessageGroup = group;
        }

        [JsonProperty("state")] public MessageReminderState State { get; set; }

        [JsonProperty("messageGroup")] public MessageReminderGroup MessageGroup { get; set; }

    }
}
