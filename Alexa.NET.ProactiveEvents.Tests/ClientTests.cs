using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.ProactiveEvents.WeatherAlerts;
using Xunit;

namespace Alexa.NET.ProactiveEvents.Tests
{
    public class ClientTests
    {
        [Fact]
        public void ClientConstructor()
        {
            var http = new HttpClient();
            var client = new ProactiveEventsClient(http);
            Assert.Equal(http,client.Client);
        }

        [Fact]
        public void TokenConstructor()
        {
            var client = new ProactiveEventsClient(ProactiveEventsClient.DevelopmentEndpoint,"token");
            Assert.Equal(ProactiveEventsClient.DevelopmentEndpoint,client.Client.BaseAddress.ToString());
            Assert.Equal("token",client.Client.DefaultRequestHeaders.Authorization.Parameter);
        }

        [Fact]
        public async Task ThrowsExceptionWithoutReference()
        {
            var client = new ProactiveEventsClient(ProactiveEventsClient.DevelopmentEndpoint, "token");

            var alert = new WeatherAlert(WeatherAlertType.Tornado);
            var request = new BroadcastEventRequest(alert)
            {
                ExpiryTime = DateTimeOffset.Now.AddMinutes(5),
                TimeStamp = DateTimeOffset.Now
            };

            await Assert.ThrowsAsync<ArgumentNullException>(() => client.Send(request));
        }

        [Fact]
        public async Task SendsExpectedRequest()
        {
            var http = new HttpClient(new ActionHandler(req =>
            {
                Assert.Equal(HttpMethod.Post,req.Method);
                Assert.Equal("application/json",req.Content.Headers.ContentType.MediaType);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            }));
            var client = new ProactiveEventsClient(ProactiveEventsClient.DevelopmentEndpoint, "token",http);

            var alert = new WeatherAlert(WeatherAlertType.Tornado);
            var request = new BroadcastEventRequest(alert)
            {
                ReferenceId = "broadcastTest",
                ExpiryTime = DateTimeOffset.Now.AddMinutes(5),
                TimeStamp = DateTimeOffset.Now
            };

            await client.Send(request);
        }
    }
}
