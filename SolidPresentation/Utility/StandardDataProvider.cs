using System;
using System.Xml.Linq;

namespace SolidPresentation.Utility
{
    public class StandardDataProvider
    {
        public XDocument Get(MessageCodeInfo messageCodeInfo, string recipientId) {
            XDocument standardData;
            switch (messageCodeInfo.RecipientType) {
                case "student":
                    standardData = GetStudentStandardData(recipientId);
                    break;
                case "prospect":
                    standardData = GetProspectStandardData(recipientId);
                    break;
                case "staff":
                    standardData = GetStaffStandardData(recipientId);
                    break;
                case "tutor":
                    standardData = GetTutorStandardData(recipientId);
                    break;
                case "selfRegistered":
                    standardData = GetSelfRegisteredStandardData(recipientId);
                    break;
                default:
                    throw new InvalidOperationException(string.Format("Unknown recipient type '{0}'", messageCodeInfo.RecipientType));
            }

            return standardData;
        }

        private XDocument GetStudentStandardData(string recipientId) {
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

        private XDocument GetProspectStandardData(string recipientId) {
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

        private XDocument GetStaffStandardData(string recipientId) {
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

        private XDocument GetTutorStandardData(string recipientId) {
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

        private XDocument GetSelfRegisteredStandardData(string recipientId) {
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