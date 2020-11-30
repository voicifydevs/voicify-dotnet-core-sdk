using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Model
{
    public class ConversationTrackingTreeEndNode : ConversationTrackingTreeBaseNode
    {
        public override string ConversationTrackingNodeType => "SessionEnd";
        public override List<ConversationTrackingTreeBaseNode> ChildNodes { get => null as List<ConversationTrackingTreeBaseNode>; set => _ = value; }

        public ConversationTrackingTreeEndNode() : base() { }
    }
}
