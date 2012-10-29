using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SolidPresentation.Components
{
    public class UnsafeCachingStandardDataComponent : StandardDataComponent
    {
        private static readonly Dictionary<Tuple<MessageCodeInfo, string>, XDocument> Cache = new Dictionary<Tuple<MessageCodeInfo, string>, XDocument>();

        public override XDocument Get(MessageCodeInfo messageCodeInfo, string recipientId) {
            var key = Tuple.Create(messageCodeInfo, recipientId);
            if (!Cache.ContainsKey(key))
                Cache.Add(key, base.Get(messageCodeInfo, recipientId));

            return Cache[key];
        }
    }
}