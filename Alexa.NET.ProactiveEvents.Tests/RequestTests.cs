using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alexa.NET.ProactiveEvents.Tests
{
    public class RequestTests
    {
        [Fact]
        public void TestRequest()
        {
            new ProactiveSubscriptionChangedRequestHandler().AddToRequestHandler();
            var testRequest = Utility.ExampleFileContent<Request.Type.Request>("SubscriptionChangedRequest.json");
            var changedRequest = Assert.IsType<ProactiveSubscriptionChangedRequest>(testRequest);
            Assert.True(Utility.CompareJson(changedRequest,"SubscriptionChangedRequest.json", "requestId", "locale", "timestamp"));
        }
    }
}
