using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
    }
}
