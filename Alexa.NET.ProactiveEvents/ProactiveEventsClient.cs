using System;
using System.IO;
using System.Net;
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
        public const string DevelopmentEndpoint = "https://api.amazonalexa.com/v1/proactiveEvents/stages/development";
        public const string NorthAmericaEndpoint = "https://api.amazonalexa.com/v1/proactiveEvents";
        public const string EuropeEndpoint = "https://api.eu.amazonalexa.com/v1/proactiveEvents";
        public const string FarEastEndpoint = "https://api.fe.amazonalexa.com/v1/proactiveEvents";

        private static readonly JsonSerializer Serializer;

        public HttpClient Client { get; set; }

        static ProactiveEventsClient()
        {
            Serializer = JsonSerializer.CreateDefault();
            Serializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
        }

        public ProactiveEventsClient(string endpointBase, string accessToken) : this(endpointBase, accessToken,
            new HttpClient())
        {

        }

        public ProactiveEventsClient(string endpointBase, string accessToken, HttpClient client)
        {
            client = client ?? new HttpClient();
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri(endpointBase, UriKind.Absolute);
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

        //public async Task<NotificationInfo> Create(CreateUpdateRequest request)
        //{
        //    var content = JObject.FromObject(request).ToString(Formatting.None);
        //    Console.WriteLine(content);
        //    var response = await Client.PostAsync(Client.BaseAddress,
        //        new StringContent(content, Encoding.UTF8, "application/json"));

        //    using (var reader = new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())))
        //    {
        //        if (response.StatusCode == HttpStatusCode.Created)
        //        {
        //            return Serializer.Deserialize<NotificationInfo>(reader);
        //        }

        //        var info = Serializer.Deserialize<NotificationExceptionInfo>(reader);
        //        throw new SkillNotificationException(info);
        //    }
        //}
        public async Task Send<TAudienceType>(ProactiveEventRequest<TAudienceType> request) where TAudienceType : AudienceType
        {
            if (string.IsNullOrWhiteSpace(request.ReferenceId))
            {
                throw new ArgumentNullException(nameof(request.ReferenceId));
            }

            var content = JObject.FromObject(request).ToString(Formatting.None);
            await Client.PostAsync(Client.BaseAddress,
                    new StringContent(content, Encoding.UTF8, "application/json"));
        }
    }
}