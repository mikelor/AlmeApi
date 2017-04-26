using System.Collections.Generic;


namespace AlmeApiSdk.Models.Conversation.Converse
{
    public class ConverseResponseSource
    {
        public string Origin { get; set; }
        public string UID { get; set; }
    }

    public class ConverseResponseMetadata
    {
        public string DisplayStyle { get; set; }
        public string NavigationType { get; set; }
        public ConverseResponseSource Source { get; set; }
        public string UrlAddress { get; set; }
        public string UrlUID { get; set; }
        public string UnitSourceType { get; set; }
        public string UnitUID { get; set; }
    }

    public class ConverseResponseDisplayLink
    {
        public string DisplayText { get; set; }
        public string TargetType { get; set; }
        public int SectionID { get; set; }
        public ConverseResponseMetadata Metadata { get; set; }
    }

    public class ConverseResponseFold
    {
        public string LinkText { get; set; }
        public string Location { get; set; }
    }

    public class ConverseResponseSection
    {
        public ConverseResponseFold Fold { get; set; }
        public string HeaderText { get; set; }
    }

    public class ConverseResponseDisplayLinkMetadata
    {
        public List<ConverseResponseSection> Section { get; set; }
    }

    public class ConverseResponseNavUrl
    {
        public string AutoNavigationType { get; set; }
        public string DisplayText { get; set; }
        public string LinkNavigationType { get; set; }
        public string UrlAddress { get; set; }
        public object UrlUID { get; set; }
    }

    public class ConverseResponseMetadata2
    {
        public string TTSMediaHandlerInstanceID { get; set; }
        public string TTSFileID { get; set; }
        public List<string> TTSMimeTypes { get; set; }
    }

    public class ConverseResponseResponseAction
    {
        public string Name { get; set; }
        public string ResponseText { get; set; }
        public string Show { get; set; }
        public string Value { get; set; }
        public string Position { get; set; }
        public ConverseResponseMetadata2 Metadata { get; set; }
    }

    public class ConverseResponse
    {
        public string text { get; set; }
        public string responseId { get; set; }
        public int responseRevision { get; set; }
        public string unitId { get; set; }
        public object displayLinkSections { get; set; }
        public int fold { get; set; }
        public string headerText { get; set; }
        public List<ConverseResponseDisplayLink> displayLinks { get; set; }
        public ConverseResponseDisplayLinkMetadata displayLinkMetadata { get; set; }
        public ConverseResponseNavUrl navUrl { get; set; }
        public List<ConverseResponseResponseAction> responseActions { get; set; }
        public object deferredAppCall { get; set; }
        public string userDisplayName { get; set; }
        public string agentDisplayName { get; set; }
        public string maskedInput { get; set; }
        public bool maintainUiLock { get; set; }
        public string userId { get; set; }
        public string messageId { get; set; }
        public object channel { get; set; }
    }
}
