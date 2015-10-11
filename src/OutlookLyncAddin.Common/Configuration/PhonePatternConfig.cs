using System;
using System.Xml.Serialization;

namespace OutlookLyncAddin.Common.Configuration
{
    [Serializable]
    public class PhonePatternConfig
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("regex")]
        public bool IsRegex { get; set; }
    }
}