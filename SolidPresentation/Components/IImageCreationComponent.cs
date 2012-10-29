using System.Xml.Linq;

namespace SolidPresentation.Components
{
    public interface IImageCreationComponent
    {
        MessageImage Create(MessageCodeInfo messageCodeInfo, XDocument mergeData);
    }
}