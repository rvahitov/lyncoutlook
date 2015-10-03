using System.Text.RegularExpressions;

namespace OutlookLyncAddin
{
    static class RegexFromPatternBuilder
    {
        static readonly Regex _sharpReplace = new Regex("#+",RegexOptions.Compiled);
        static readonly Regex _whiteSpaceReplace = new Regex("\\s+", RegexOptions.Compiled);
        static readonly Regex _escapeRegex = new Regex("[+()?.]",RegexOptions.Compiled);
        internal static Regex Build(string pattern)
        {
            var escapedPattern = _escapeRegex.Replace(pattern,m => "\\" + m.Value);
            var whiteSpaceReplacedPattern = _whiteSpaceReplace.Replace(escapedPattern, "\\s+");
            var sharpReplacedPattern = _sharpReplace.Replace(whiteSpaceReplacedPattern, m =>
            {
                var len = m.Value.Length;
                return "\\d{" + len + "}";
            });
            return new Regex(sharpReplacedPattern,RegexOptions.Compiled);
        }
    }
}