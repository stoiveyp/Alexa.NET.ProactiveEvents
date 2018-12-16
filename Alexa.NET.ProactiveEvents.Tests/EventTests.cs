using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Alexa.NET.ProactiveEvents.MessageReminders;
using Alexa.NET.ProactiveEvents.OrderStatusUpdates;
using Alexa.NET.ProactiveEvents.ReservationConfirmations;
using Alexa.NET.ProactiveEvents.SoccerScoreUpdates;
using Alexa.NET.ProactiveEvents.WeatherAlerts;
using Xunit;

namespace Alexa.NET.ProactiveEvents.Tests
{
    public class EventTests
    {
        [Fact]
        public void UserEventGeneratesCorrectJson()
        {
            var userEvent = new UserEventRequest("userId")
            {
                TimeStamp = DateTimeOffset.Parse("2018-06-18T22:10:01.00Z"),
                ReferenceId = "unique-id-of-this-instance",
                ExpiryTime = DateTimeOffset.Parse("2018-06-19T22:10:01.00Z"),
                Event = new DummyEvent(),
                LocaleAttributes = new[]
                {
                    new LocaleAttributes("en-GB") {Properties = {{"testy", "thing"}}}
                }.ToList()
            };
            Assert.Equal("userId", userEvent.Audience.Payload.User);
            Assert.True(Utility.CompareJson(userEvent, "Individual.json"));
        }

        private class DummyEvent : ProactiveEvent
        {
            public DummyEvent() : base("test") { }
        }

        [Fact]
        public void BroadcastEventGeneratesCorrectJson()
        {
            var userEvent = new BroadcastEventRequest
            {
                TimeStamp = DateTimeOffset.Parse("2018-06-18T22:10:01.00Z"),
                ReferenceId = "unique-id-of-this-instance",
                ExpiryTime = DateTimeOffset.Parse("2018-06-19T22:10:01.00Z"),
                Event = new DummyEvent(),
                LocaleAttributes = new[]
                {
                    new LocaleAttributes("en-GB") {Properties = {{"testy", "thing"}}}
                }.ToList()
            };

            Assert.True(Utility.CompareJson(userEvent, "Broadcast.json"));
        }

        [Fact]
        public void WeatherAlert()
        {
            var weatherAlert = new WeatherAlert(WeatherAlertType.Tornado, "localizedattribute:source");
            Assert.True(Utility.CompareJson(weatherAlert, "WeatherAlert.json"));
        }

        [Fact]
        public void SoccerScoreUpdate()
        {
            var soccerScore = new SoccerScoreUpdate
            (
                new SoccerScoreUpdateDetail("Arsenal", 1),
                new SoccerScoreSportsEvent(
                    "localizedattribute:eventLeagueName",
                    new SoccerScoreTeamStatistics("Oranges", 1),
                    new SoccerScoreTeamStatistics("Apples", 2))
            );
            Assert.True(Utility.CompareJson(soccerScore, "SoccerScore.json"));
        }

        [Fact]
        public void MessageReminder()
        {

            var state = new MessageReminderState(MessageReminderStatus.Unread, MessageReminderFreshness.New);
            var group = new MessageReminderGroup("Andy", 5, MessageReminderUrgency.Urgent);
            var messageReminder = new MessageReminder(state, group);
            Assert.True(Utility.CompareJson(messageReminder, "MessageReminder.json"));
        }

        [Fact]
        public void OrderUpdate()
        {
            var orderStatusUpdate = new OrderStatusUpdate("localizedattribute:sellerName", OrderStatus.Shipped);
            orderStatusUpdate.Payload.State.DeliveryDetails = new ParcelDelivery
            {
                ExpectedArrival = DateTimeOffset.Parse("2018-12-14T23:32:00.463Z")
            };
            Assert.True(Utility.CompareJson(orderStatusUpdate, "OrderStatus.json"));
        }

        [Fact]
        public void ReservationConfirmation()
        {
            OccasionType type = OccasionType.Appointment;
            DateTimeOffset bookingTime = DateTimeOffset.Parse("2018-11-20T19:16:31+00:00");
            string providerName= "localizedattribute:providerName";
            string subject= "localizedattribute:subject";
            string brokerName= "localizedattribute:brokerName";
            var occasionUpdate = new ReservationConfirmation(ConfirmationStatus.Confirmed,
                new Occasion(type,bookingTime,providerName,subject,brokerName));

            Assert.True(Utility.CompareJson(occasionUpdate,"ReservationConfirmation.json"));
        }
    }
}
