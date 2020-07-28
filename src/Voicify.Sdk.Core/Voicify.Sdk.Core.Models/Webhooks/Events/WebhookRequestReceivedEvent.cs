using Voicify.Sdk.Core.Models.Constants;
using Voicify.Sdk.Core.Models.Webhooks.Requests;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    /// <summary>
    /// Event for an assistant request received
    /// </summary>
    public class WebhookRequestReceivedEvent : EventWebhookEvent
    {
        public string IntentName { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }

        public override string EventType => EventWebhookEventTypes.RequestReceived;
    }
}
