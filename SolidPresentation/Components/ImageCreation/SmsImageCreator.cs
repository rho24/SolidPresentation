using System;
using System.Xml.Linq;

namespace SolidPresentation.Components.ImageCreation
{
    public class SmsImageCreator : IImageCreator
    {
        public bool CanCreateFor(MessageCodeInfo messageCodeInfo) {
            return messageCodeInfo.MediumType == "sms";
        }

        public MessageImage CreateImage(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
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