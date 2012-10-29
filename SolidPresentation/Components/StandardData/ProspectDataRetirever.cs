using System;
using System.Xml.Linq;

namespace SolidPresentation.Components.StandardData
{
    public class ProspectDataRetirever : IStandardDataRetrever
    {
        public bool CanRetrieveFor(MessageCodeInfo messageCodeInfo) {
            return messageCodeInfo.RecipientType == "prospect";
        }

        public XDocument GetData(MessageCodeInfo messageCodeInfo, string recipientId) {
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            //Doing stuff
            throw new NotImplementedException();
        }
    }
}