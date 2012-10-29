using System;
using System.Xml.Linq;

namespace SolidPresentation.Components.StandardData
{
    public class StudentDataRetriever : IStandardDataRetrever
    {
        public bool CanRetrieveFor(MessageCodeInfo messageCodeInfo) {
            return messageCodeInfo.RecipientType == "student";
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