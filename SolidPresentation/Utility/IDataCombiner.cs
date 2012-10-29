using System.Xml.Linq;

namespace SolidPresentation.Utility
{
    public interface IDataCombiner
    {
        XDocument Combine(XDocument data1, XDocument data2);
    }
}