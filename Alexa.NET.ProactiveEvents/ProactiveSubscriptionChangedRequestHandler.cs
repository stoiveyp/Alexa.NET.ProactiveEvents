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
                var index = RequestConverter.RequestConverters.FindIndex(converter => converter is SkillEventRequestTypeConverter);
                if (index == -1)
                {
                    RequestConverter.RequestConverters.Add(this);
                }
                else
                {
                    RequestConverter.RequestConverters.Insert(index,this);
                }
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
