using System.Xml.Linq;

namespace SolidPresentation.Components
{
    public interface IStandardDataComponent
    {
        XDocument Get(MessageCodeInfo messageCodeInfo, string recipientId);
    }
}