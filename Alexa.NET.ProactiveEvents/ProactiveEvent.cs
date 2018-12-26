using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace Alexa.NET.ProactiveEvents
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    public abstract class ProactiveEvent
    {
        protected ProactiveEvent(string name)
        {
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; }

        public virtual IEnumerable<KeyValuePair<string,List<LocaleAttribute>>> GetLocales()
        {
            return new KeyValuePair<string, List<LocaleAttribute>>[]{};
        }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    public abstract class ProactiveEvent<T>:ProactiveEvent
    {
        protected ProactiveEvent(string name) : base(name)
        {
        }

        [JsonProperty("payload")]
        public T Payload { get; set; }
    }
}