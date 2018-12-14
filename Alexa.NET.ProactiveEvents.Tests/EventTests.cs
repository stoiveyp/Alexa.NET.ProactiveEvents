using System;
using System.Linq;
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
            public override string Name => "test";
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
            var weatherAlert = new WeatherAlert(new WeatherAlertPayloadData
            {
                Source = "localizedattribute:source",
                Type = WeatherAlertType.Tornado
            });
            Assert.True(Utility.CompareJson(weatherAlert,"WeatherAlert.json"));
        }
    }
}
