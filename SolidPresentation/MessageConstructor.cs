using System;
using System.Xml.Linq;
using SolidPresentation.Components;
using SolidPresentation.Utility;

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
            var messageCodeInfo = new MessageCodeInfoProvider().Get(messageCode);

            //Retrieve standard data
            var standardData = new StandardDataComponent().Get(messageCodeInfo, recipientId);
            
            //Combine user and system data
            var mergeData = new DataCombiner().Combine(messageData, standardData);

            //Create image
            var image = new ImageCreationComponent().Create(messageCodeInfo, mergeData);

            return new Message {MessageCode = messageCode, RecipientId = recipientId, MessageData = mergeData, MessageImage = image};
        }
    }
}