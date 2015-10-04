using System.IO;
using System.Xml.Serialization;
using OutlookLyncAddin.Common.Configuration;
using Xunit;

namespace OutlookLyncAddin.Tests
{
    public class OutlookLyncAddinConfigTest
    {
        [Fact]
        public void Serialization()
        {
            var config = new OutlookLyncAddinConfig();
            config.Patterns.Add(new PhonePatternConfig{Value = "####"});
            config.Patterns.Add(new PhonePatternConfig{Value = "##-##"});
            config.Patterns.Add(new PhonePatternConfig { Value = "+# (###) ###-##-##" });
            var xmlSerializer = new XmlSerializer(typeof(OutlookLyncAddinConfig));
            string serString = null;
            using (var stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter,config);
                serString = stringWriter.ToString();
            }

            Assert.NotNull(serString);
        }
    }
}