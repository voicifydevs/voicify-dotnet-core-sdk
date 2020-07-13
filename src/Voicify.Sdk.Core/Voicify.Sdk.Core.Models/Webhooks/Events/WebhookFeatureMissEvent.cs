using Voicify.Sdk.Core.Models.Constants;
using Voicify.Sdk.Core.Models.Webhooks.Requests;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    /// <summary>
    /// Event for when a feature is not found for the given intent
    /// </summary>
    public class WebhookFeatureMissEvent : EventWebhookEvent
    {
        public string IntentName { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }
        public override string EventType => EventWebhookEventTypes.FeatureMiss;
    }
}
