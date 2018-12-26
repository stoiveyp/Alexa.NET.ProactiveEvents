using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Alexa.NET.ProactiveEvents
{
    public class LocaleAttributes:List<LocaleAttribute>
    {
        public LocaleAttributes() { }

        public LocaleAttributes(LocaleAttribute attribute)
        {
            this.Add(attribute);
        }

        public LocaleAttributes(string locale, string value)
        {
            this.Add(new LocaleAttribute(locale, value));
        }
    }

    public class LocaleAttribute
    {
        public LocaleAttribute(string locale, string value)
        {
            Locale = locale;
            Value = value;
        }

        public string Locale { get; set; }

        public string Value { get; set; }
    }
}
