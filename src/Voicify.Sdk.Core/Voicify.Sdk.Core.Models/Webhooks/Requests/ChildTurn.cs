using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Represents a child turn allowed in a conversation
    /// </summary>
    public class ChildTurn
    {
        public string ContentId { get; set; }
        public string FeatureTypeId { get; set; }
        public ChildTurn()
        {
        }

        public ChildTurn(string contentId, string featureTypeId)
        {
            ContentId = contentId;
            FeatureTypeId = featureTypeId;
        }
    }
}
