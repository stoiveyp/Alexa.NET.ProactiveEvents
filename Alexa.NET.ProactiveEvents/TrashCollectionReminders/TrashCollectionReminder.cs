using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.ProactiveEvents.TrashCollectionReminders
{
    public class TrashCollectionReminder : ProactiveEvent<TrashCollectionReminderPayload>
    {
        public TrashCollectionReminder() : base("AMAZON.TrashCollectionAlert.Activated")
        {
        }

        public TrashCollectionReminder(DayOfWeek collectionDay, params GarbageType[] garbageTypes) : this()
        {
            Payload = new TrashCollectionReminderPayload(collectionDay, garbageTypes);
        }
    }
}
