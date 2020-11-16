using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{

    /// <summary>
    /// A general mapping of a request from the Voicify assistant API
    /// </summary>
    public class GeneralAssistantRequest
    {
        public string RequestType { get; set; }

        public string Assistant { get; set; }
        public string SessionId { get; set; }
        public string UserId { get; set; }
        public string ApplicationId { get; set; }
        public string RequestId { get; set; }
        public bool HasDisplay { get; set; }
        public bool SupportsVideo { get; set; }
        public bool HasAudio { get; set; }
        public object NativeRequest { get; set; }
        public ConversationTurnHistoryState ConversationState { get; set; }
        public string AccessToken { get; set; }
        public string Locale { get; set; }

        //Session data
        public Dictionary<string, object> SessionAttributes { get; set; }
        public List<string> SessionFlags { get; set; }

        //User profile
        public DateTime? UserFirstSeen { get; set; }
        public List<string> UserFlags { get; set; }
        public Dictionary<string, object> UserAttributes { get; set; }
    }
}
