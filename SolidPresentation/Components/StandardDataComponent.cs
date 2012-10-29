using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using SolidPresentation.Components.StandardData;

namespace SolidPresentation.Components
{
    public class StandardDataComponent : IStandardDataComponent
    {
        private readonly IEnumerable<IStandardDataRetrever> _retrievers;

        public StandardDataComponent(IEnumerable<IStandardDataRetrever> retrievers) {
            _retrievers = retrievers;
        }

        public StandardDataComponent()
            : this(new IStandardDataRetrever[] {
                new StudentDataRetriever(),
                new ProspectDataRetirever(),
                new StaffDataRetriever(),
                new TutorDataRetriever(),
                new SelfRegisteredDataRetriever()
            }) {}

        public XDocument Get(MessageCodeInfo messageCodeInfo, string recipientId) {
            var retriever = _retrievers.SingleOrDefault(r => r.CanRetrieveFor(messageCodeInfo));

            if (retriever == null)
                throw new Exception(string.Format("Cannot retrieve data for {0}", messageCodeInfo.MessageCode));

            return retriever.GetData(messageCodeInfo, recipientId);
        }
    }
}