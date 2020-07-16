using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Constants;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    /// <summary>
    /// Webhook event for a feature hit
    /// </summary>
    public class WebhookFeatureHitEvent : EventWebhookEvent
    {
        public string FeatureTypeId { get; set; }
        public bool IsCustomFeatureServer { get; set; }
        public string IntentName { get; set; }

        public override string EventType => EventWebhookEventTypes.FeatureHit;
    }
}
