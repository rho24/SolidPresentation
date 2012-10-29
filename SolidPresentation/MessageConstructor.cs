using System;
using System.Xml.Linq;
using SolidPresentation.Components;
using SolidPresentation.Utility;

namespace SolidPresentation
{
    public class MessageConstructor
    {
        private readonly IDataCombiner _dataCombiner;
        private readonly IImageCreationComponent _imageCreationComponent;
        private readonly IMessageCodeInfoProvider _messageCodeInfoProvider;
        private readonly IStandardDataComponent _standardDataComponent;

        public MessageConstructor(IMessageCodeInfoProvider messageCodeInfoProvider,
                                  IStandardDataComponent standardDataComponent,
                                  IDataCombiner dataCombiner,
                                  IImageCreationComponent imageCreationComponent) {
            _messageCodeInfoProvider = messageCodeInfoProvider;
            _standardDataComponent = standardDataComponent;
            _dataCombiner = dataCombiner;
            _imageCreationComponent = imageCreationComponent;
        }

        public Message Construct(string messageCode, string recipientId, XDocument messageData) {
            //Validate inputs
            if (messageCode == null) throw new ArgumentNullException("messageCode");
            if (recipientId == null) throw new ArgumentNullException("recipientId");
            if (messageData == null) throw new ArgumentNullException("messageData");

            //Grab message code info
            var messageCodeInfo = _messageCodeInfoProvider.Get(messageCode);

            //Retrieve standard data
            var standardData = _standardDataComponent.Get(messageCodeInfo, recipientId);

            //Combine user and system data
            var mergeData = _dataCombiner.Combine(messageData, standardData);

            //Create image
            var image = _imageCreationComponent.Create(messageCodeInfo, mergeData);

            return new Message {MessageCode = messageCode, RecipientId = recipientId, MessageData = mergeData, MessageImage = image};
        }
    }
}