using System.Xml.Linq;

namespace SolidPresentation.Components.ImageCreation
{
    public interface IImageCreator
    {
        bool CanCreateFor(MessageCodeInfo messageCodeInfo);
        MessageImage CreateImage(MessageCodeInfo messageCodeInfo, XDocument mergeData);
    }
}