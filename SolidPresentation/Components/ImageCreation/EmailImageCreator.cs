using System;
using System.Xml.Linq;

namespace SolidPresentation.Components.ImageCreation
{
    public class EmailImageCreator : IImageCreator
    {
        public bool CanCreateFor(MessageCodeInfo messageCodeInfo) {
            return messageCodeInfo.MediumType == "email";
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