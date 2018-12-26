using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.ProactiveEvents.AudienceTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.ProactiveEvents
{
    public class ProactiveEventsClient
    {
        public const string DevelopmentPathExtension = "/stages/development";
        public const string NorthAmericaEndpoint = "https://api.amazonalexa.com/v1/proactiveEvents";
        public const string EuropeEndpoint = "https://api.eu.amazonalexa.com/v1/proactiveEvents";
        public const string FarEastEndpoint = "https://api.fe.amazonalexa.com/v1/proactiveEvents";

        private static readonly JsonSerializer Serializer;

        public HttpClient Client { get; set; }

        static ProactiveEventsClient()
        {
            Serializer = JsonSerializer.CreateDefault();
        }

        public ProactiveEventsClient(string endpointBase, string accessToken,bool isDevelopment = true) : this(endpointBase, accessToken,
            new HttpClient(), isDevelopment)
        {

        }

        public ProactiveEventsClient(string endpointBase, string accessToken, HttpClient client,bool isDevelopment = true)
        {
            client = client ?? new HttpClient();
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri(endpointBase + (isDevelopment ? DevelopmentPathExtension : string.Empty), UriKind.Absolute);
            }

            if (client.DefaultRequestHeaders.Authorization == null)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }

            Client = client;
        }

        public ProactiveEventsClient(HttpClient client)
        {
            Client = client;
        }

        public Task<HttpResponseMessage> Send<TAudienceType>(ProactiveEventRequest<TAudienceType> request) where TAudienceType : AudienceType
        {
            if (string.IsNullOrWhiteSpace(request.ReferenceId))
            {
                throw new ArgumentNullException(nameof(request.ReferenceId));
            }

            var content = JObject.FromObject(request).ToString(Formatting.None);
            return Client.PostAsync(Client.BaseAddress,
                    new StringContent(content, Encoding.UTF8, "application/json"));
        }
    }
}