using System.Xml.Linq;

namespace SolidPresentation
{
    public class Message
    {
        public string MessageCode { get; set; }

        public string RecipientId { get; set; }

        public XDocument MessageData { get; set; }

        public MessageImage MessageImage { get; set; }
    }
}