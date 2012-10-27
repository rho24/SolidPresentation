using System;
using System.Xml.Linq;

namespace SolidPresentation
{
    public class MessageConstructor
    {
        public Message Construct(string messageCode, string recipientId, XDocument messageData) {
            //Validate inputs
            if (messageCode == null) throw new ArgumentNullException("messageCode");
            if (recipientId == null) throw new ArgumentNullException("recipientId");
            if (messageData == null) throw new ArgumentNullException("messageData");

            //Grab message code info
            var messageCodeInfo = GetMessageCodeInfo(messageCode);

            //Retrieve standard data
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

            var mergeData = CombineData(messageData, standardData);

            //Create image
            MessageImage image;
            switch (messageCodeInfo.MediumType) {
                case "email":
                    image = CreateEmailImage(messageCodeInfo, mergeData);
                    break;
                case "pdf":
                    image = CreatePdfImage(messageCodeInfo, mergeData);
                    break;
                case "sms":
                    image = CreateSmsImage(messageCodeInfo, mergeData);
                    break;
                default:
                    throw new InvalidOperationException(string.Format("Unknown medium type '{0}'", messageCodeInfo.MediumType));
            }

            return new Message {MessageCode = messageCode, RecipientId = recipientId, MessageData = mergeData, MessageImage = image};
        }

        private MessageCodeInfo GetMessageCodeInfo(string messageCode) {
            return new MessageCodeInfo {RecipientType = "student", MediumType = "email", TemplateName = "e-stud.xsl"};
        }

        private XDocument GetStudentStandardData(string recipientId) {
            throw new NotImplementedException();
        }

        private XDocument GetProspectStandardData(string recipientId) {
            throw new NotImplementedException();
        }

        private XDocument GetStaffStandardData(string recipientId) {
            throw new NotImplementedException();
        }

        private XDocument GetTutorStandardData(string recipientId) {
            throw new NotImplementedException();
        }

        private XDocument GetSelfRegisteredStandardData(string recipientId) {
            throw new NotImplementedException();
        }

        private XDocument CombineData(XDocument messageData, XDocument standardData) {
            throw new NotImplementedException();
        }

        private MessageImage CreateEmailImage(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
            throw new NotImplementedException();
        }

        private MessageImage CreatePdfImage(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
            throw new NotImplementedException();
        }

        private MessageImage CreateSmsImage(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
            throw new NotImplementedException();
        }
    }
}