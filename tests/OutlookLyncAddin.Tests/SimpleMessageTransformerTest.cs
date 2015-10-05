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
        private const string Message1 =
            @"Привет! Как дела? У меня сменился номер телефона.
Мой новый номер телефона - +7(111)222-22-22.
С уважением, Сергей
Рабочий: 89-78";

        private const string TransformedMessage1 =
            @"<html><body>Привет! Как дела? У меня сменился номер телефона.
Мой новый номер телефона - <a href=""tel:+7(111)222-22-22"">+7(111)222-22-22</a>.
С уважением, Сергей
Рабочий: <a href=""tel:89-78"">89-78</a></body></html>";

        private readonly Regex[] _patterns = (new[]{"####", "##-##", "+# (###) ###-##-##"}).Select(RegexFromPatternBuilder.Build).ToArray();

        [Theory]
        [InlineData("Привет! Позвони мне по номеру - 12-34", "<html><body>Привет! Позвони мне по номеру - <a href=\"tel:12-34\">12-34</a></body></html>")]
        [InlineData("Привет! Позвони мне по номеру - 1234", "<html><body>Привет! Позвони мне по номеру - <a href=\"tel:1234\">1234</a></body></html>")]
        [InlineData("Рабочий телефон: 5678; Мобильный: +7(908)111-23-99", "<html><body>Рабочий телефон: <a href=\"tel:5678\">5678</a>; Мобильный: <a href=\"tel:+7(908)111-23-99\">+7(908)111-23-99</a></body></html>")]
        [InlineData(Message1, TransformedMessage1)]
        public void PositiveTest(string message, string result)
        {
            var transformer = new SimpleMessageTransformer(_patterns);
            var transformedMessage = transformer.Transform(message);
            Debug.WriteLine("Transform result: {0}",transformedMessage);
            Assert.Equal(transformedMessage,result);
        } 
    }
}