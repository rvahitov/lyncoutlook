using System.Collections.Generic;
using System.Linq;

namespace OutlookLyncAddin.Common
{
    public class TextReplacementLocationCollection : List<TextReplacementLocation>
    {
        public bool CheckedAdd(TextReplacementLocation replacementLocation)
        {
            if (this.Any(trl => trl.Contains(replacementLocation))) return false;
            var toRemove = this.Where(replacementLocation.Contains).ToArray();
            foreach (var trl in toRemove)
            {
                Remove(trl);
            }
            Add(replacementLocation);
            return true;
        }
    }
}