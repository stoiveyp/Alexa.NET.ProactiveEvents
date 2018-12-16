using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    public class EntityName
    {
        public EntityName() { }
        public EntityName(string name)
        {
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
