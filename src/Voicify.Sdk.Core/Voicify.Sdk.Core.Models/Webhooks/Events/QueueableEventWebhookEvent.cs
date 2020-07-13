using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    public class QueueableEventWebhookEvent
    {
        public string EventType { get; set; }
        public EventWebhookEvent Data { get; set; }        
        public WebhookModel Webhook { get; set; }
    }
}
