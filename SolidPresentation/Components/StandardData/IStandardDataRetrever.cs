using System.Xml.Linq;

namespace SolidPresentation.Components.StandardData
{
    public interface IStandardDataRetrever
    {
        bool CanRetrieveFor(MessageCodeInfo messageCodeInfo);
        XDocument GetData(MessageCodeInfo messageCodeInfo, string recipientId);
    }
}