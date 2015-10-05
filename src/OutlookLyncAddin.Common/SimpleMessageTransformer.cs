using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OutlookLyncAddin.Common
{
    public class SimpleMessageTransformer: IMessageTransformer
    {
        private readonly Regex[] _patterns;

        public SimpleMessageTransformer(IEnumerable<Regex> patterns)
        {
            _patterns = patterns.ToArray();
        }

        public string Transform(string message)
        {
            var replacementCollection = new TextReplacementLocationCollection();
            foreach (var pattern in _patterns)
            {
                var matches = pattern.Matches(message);
                foreach (Match match in matches)
                {
                    var replacement = new TextReplacementLocation(match.Index, match.Length,
                        string.Format("<a href=\"tel:{0}\">{0}</a>", match.Value));
                    replacementCollection.CheckedAdd(replacement);
                }
            }

            var stringBuilder = new StringBuilder(message);
            foreach (var replacement in replacementCollection.OrderByDescending(r => r.Start))
            {
                stringBuilder.Remove(replacement.Start, replacement.Length);
                stringBuilder.Insert(replacement.Start, replacement.Replacement);
            }

            return string.Concat("<html><body>", stringBuilder.ToString(),"</body></html>");
        }
    }

}