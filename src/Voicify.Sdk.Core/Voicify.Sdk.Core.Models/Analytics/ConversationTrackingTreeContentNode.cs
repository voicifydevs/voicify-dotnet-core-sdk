using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Model
{
    public class ConversationTrackingTreeContentNode : ConversationTrackingTreeBaseNode
    {
        public override string ConversationTrackingNodeType => "Content";
        /// <summary>
        /// The id of the content item
        /// </summary>
        public string ContentId { get; set; }
        /// <summary>
        /// The feature type represented by the node
        /// </summary>
        public string FeatureTypeId { get; set; }
        /// <summary>
        /// The slots collected from the event
        /// </summary>
        public List<Dictionary<string, string>> Slots { get; set; }

        public ConversationTrackingTreeContentNode() : base()
        {
            Slots = new List<Dictionary<string, string>>();
        }
    }
}
