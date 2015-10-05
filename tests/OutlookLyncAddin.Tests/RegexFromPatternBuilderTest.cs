using OutlookLyncAddin.Common;
using Xunit;

namespace OutlookLyncAddin.Tests
{
    public class RegexFromPatternBuilderTest
    {
        [Theory]
        [InlineData("#","\\b\\d{1}\\b")]
        [InlineData("###","\\b\\d{3}\\b")]
        [InlineData("###-##","\\b\\d{3}-\\d{2}\\b")]
        [InlineData("+# (###) ###-##-##","\\+\\d{1}\\s*\\(\\d{3}\\)\\s*\\d{3}-\\d{2}-\\d{2}")]
        public void BuildPositive(string pattern,string result)
        {
            var regex = RegexFromPatternBuilder.Build(pattern);
            Assert.Equal(result,regex.ToString());
        }

        [Theory]
        [InlineData("#", "#")]
        [InlineData("###", "###")]
        [InlineData("###-##", "###-##")]
        [InlineData("+# (###) ###-##-##", "+# (###) ###-##-##")]
        public void BuildNegative(string pattern, string result)
        {
            var regex = RegexFromPatternBuilder.Build(pattern);
            Assert.NotEqual(result, regex.ToString());
        }

        [Theory]
        [InlineData("#", "9")]
        [InlineData("#5", "25")]
        [InlineData("###", "123")]
        [InlineData("###-##", "123-45")]
        [InlineData("+# (###) ###-##-##", "+7(985)123-45-67")]
        [InlineData("+# (###) ###-##-##", "+7  (985)  123-45-67")]
        public void ParsePositive(string pattern, string input)
        {
            var regex = RegexFromPatternBuilder.Build(pattern);
            Assert.True(regex.IsMatch(input));
        }

        [Theory]
        [InlineData("#", "A")]
        [InlineData("#5", "30")]
        [InlineData("###", "1235")]
        [InlineData("###-##", "1233-aa")]
        [InlineData("+# (###) ###-##-##", "++9(98s)123-45-67")]
        public void ParseNegative(string pattern, string input)
        {
            var regex = RegexFromPatternBuilder.Build(pattern);
            Assert.False(regex.IsMatch(input));
        }
    }
}