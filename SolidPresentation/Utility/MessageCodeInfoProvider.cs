namespace SolidPresentation.Utility
{
    public class MessageCodeInfoProvider
    {
        public MessageCodeInfo Get(string messageCode) {
            return new MessageCodeInfo {RecipientType = "student", MediumType = "email", TemplateName = "e-stud.xsl"};
        }
    }
}