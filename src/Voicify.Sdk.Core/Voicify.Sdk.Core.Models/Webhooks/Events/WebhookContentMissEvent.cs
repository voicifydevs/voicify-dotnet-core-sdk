using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Voicify.Sdk.Core.Models.Constants;
using Voicify.Sdk.Core.Models.Webhooks.Requests;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    /// <summary>
    /// Event data for when a feature is hit but there is no content for the original request
    /// </summary>
    public class WebhookContentMissEvent : EventWebhookEvent
    {
        public string FeatureTypeId { get; set; }
        public string Reason { get; set; }
        public override string EventType => EventWebhookEventTypes.ContentMiss;
        public Dictionary<string,string> Slots { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }

    }
}
