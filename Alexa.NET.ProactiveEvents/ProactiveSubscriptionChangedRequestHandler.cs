using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;

namespace Alexa.NET.ProactiveEvents
{
    public class ProactiveSubscriptionChangedRequestHandler:Alexa.NET.Request.Type.IRequestTypeConverter
    {
        public void AddToRequestHandler()
        {
            if (!RequestConverter.RequestConverters.OfType<ProactiveSubscriptionChangedRequestHandler>().Any())
            {
                RequestConverter.RequestConverters.Add(this);
            }
        }

        public bool CanConvert(string requestType)
        {
            return requestType == "AlexaSkillEvent.ProactiveSubscriptionChanged";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new ProactiveSubscriptionChangedRequest();
        }
    }
}
