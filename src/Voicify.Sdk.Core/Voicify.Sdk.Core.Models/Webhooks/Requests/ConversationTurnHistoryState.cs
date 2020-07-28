using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{

    /// <summary>
    /// Represents the state of a give conversation
    /// </summary>
    public class ConversationTurnHistoryState
    {
        public string Id { get; set; } // same as the user id of the native user
        public List<ConversationTurn> TurnHistory { get; set; }
    }
}
