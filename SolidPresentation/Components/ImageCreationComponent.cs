using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using SolidPresentation.Components.ImageCreation;

namespace SolidPresentation.Components
{
    public class ImageCreationComponent : IImageCreationComponent
    {
        private readonly IEnumerable<IImageCreator> _creators;

        public ImageCreationComponent(IEnumerable<IImageCreator> creators) {
            _creators = creators;
        }

        public ImageCreationComponent()
            : this(new IImageCreator[] {
                new EmailImageCreator(),
                new PdfImageCreator(),
                new SmsImageCreator()
            }) {}

        public MessageImage Create(MessageCodeInfo messageCodeInfo, XDocument mergeData) {
            var retriever = _creators.SingleOrDefault(r => r.CanCreateFor(messageCodeInfo));

            if (retriever == null)
                throw new Exception(string.Format("Cannot retrieve data for {0}", messageCodeInfo.MessageCode));

            return retriever.CreateImage(messageCodeInfo, mergeData);
        }
    }
}