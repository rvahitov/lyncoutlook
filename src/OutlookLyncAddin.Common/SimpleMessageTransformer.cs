using System.Collections.Generic;

namespace OutlookLyncAddin.Common
{
    public class SimpleMessageTransformer: IMessageTransformer
    {
        public SimpleMessageTransformer(IEnumerable<string> patterns)
        {

        }

        public string Transform(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}