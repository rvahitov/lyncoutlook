using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using OutlookLyncAddin.Common;
using Xunit;

namespace OutlookLyncAddin.Tests
{
    public class SimpleMessageTransformerTest
    {

        private readonly Regex[] _patterns = (new[]{"####", "##-##", "+# (###) ###-##-##"}).Select(RegexFromPatternBuilder.Build).ToArray();

        [Theory]
        [InlineData("Привет! Позвони мне по номеру - 12-34", "<html><body>Привет! Позвони мне по номеру - <a href=\"tel:12-34\">12-34</a></body></html>")]
        [InlineData("Привет! Позвони мне по номеру - 1234", "<html><body>Привет! Позвони мне по номеру - <a href=\"tel:1234\">1234</a></body></html>")]
        [InlineData("Рабочий телефон: 5678; Мобильный: +7(908)111-23-99", "<html><body>Рабочий телефон: <a href=\"tel:5678\">5678</a>; Мобильный: <a href=\"tel:+7(908)111-23-99\">+7(908)111-23-99</a></body></html>")]
        public void PositiveTest(string message, string result)
        {
            var transformer = new SimpleMessageTransformer(_patterns);
            var transformedMessage = transformer.Transform(message);
            Debug.WriteLine("Transform result: {0}",transformedMessage);
            Assert.Equal(transformedMessage,result);
        } 
    }
}