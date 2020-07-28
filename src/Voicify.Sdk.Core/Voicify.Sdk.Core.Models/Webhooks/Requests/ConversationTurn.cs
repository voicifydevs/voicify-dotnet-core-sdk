using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Represents the state of a single turn in conversation
    /// </summary>
    public class ConversationTurn
    {
        public string ContentId { get; set; }
        public string FeatureTypeId { get; set; }
        public string ApplicationId { get; set; }
        public string FollowUpId { get; set; }
        public string HelpMessageId { get; set; }
        public string FallbackMessageId { get; set; }
        public List<ChildTurn> ChildTurns { get; set; }
        public bool IsLimitedToChildren { get; set; }
        public DateTime RequestDate { get; set; }

        public ConversationTurn() { }

    }
}
