using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OutlookLyncAddin.Common.Configuration
{
    [Serializable,XmlRoot("outlookLyncAddin")]
    public class OutlookLyncAddinConfig
    {
        public OutlookLyncAddinConfig()
        {
            Patterns = new PhonePatternCollectionConfig();
        }

        [XmlArray("patterrns"),XmlArrayItem("pattern")]
        public PhonePatternCollectionConfig Patterns { get; set; }

        public static OutlookLyncAddinConfig FromXml(string xmlPath)
        {
            using (var xmlReader = XmlReader.Create(xmlPath))
            {
                var xmlSerializer = new XmlSerializer(typeof(OutlookLyncAddinConfig));
                return (OutlookLyncAddinConfig) xmlSerializer.Deserialize(xmlReader);
            }
        }

        public static void ToXml(OutlookLyncAddinConfig config, string xmlPath)
        {
            using (var xmlWriter = XmlWriter.Create(xmlPath,new XmlWriterSettings{Encoding = Encoding.UTF8}))
            {
                var xmlSerializer = new XmlSerializer(typeof(OutlookLyncAddinConfig));
                xmlSerializer.Serialize(xmlWriter,config);
                xmlWriter.Flush();
            }
        }
    }
}