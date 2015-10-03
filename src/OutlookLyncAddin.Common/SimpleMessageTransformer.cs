using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OutlookLyncAddin.Common
{
    public class SimpleMessageTransformer: IMessageTransformer
    {
        private readonly Regex[] _patterns;

        public SimpleMessageTransformer(IEnumerable<string> patterns)
        {
            _patterns = patterns.Select(RegexFromPatternBuilder.Build).ToArray();
        }

        public string Transform(string message)
        {
            MatchEvaluator replacement = m => string.Format("<a href=\"tel:{0}\">{0}</a>", m.Value);
            return _patterns.Aggregate(message, (current, pattern) => pattern.Replace(current, replacement));
        }
    }

}