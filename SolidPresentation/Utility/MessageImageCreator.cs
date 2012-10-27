using System;
using System.Xml.Linq;

namespace SolidPresentation.Utility
{
    public class MessageImageCreator
    {
        public MessageImage Create(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
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

            return image;
        }

        private MessageImage CreateEmailImage(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
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

        private MessageImage CreatePdfImage(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
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

        private MessageImage CreateSmsImage(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
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