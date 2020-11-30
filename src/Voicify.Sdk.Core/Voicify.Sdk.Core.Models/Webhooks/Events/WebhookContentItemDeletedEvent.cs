using Voicify.Sdk.Core.Models.Constants;
using Voicify.Sdk.Core.Models.Content;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    public class WebhookContentItemDeletedEvent : EventWebhookEvent
    {
        public override string EventType => EventWebhookEventTypes.ContentItemDeleted;
        public string ApplicationFeatureId { get; set; }
        public IContentItemModel Content { get; set; }

        public WebhookContentItemDeletedEvent(IContentItemModel content, string applicationFeatureId, string applicationId)
        {
            ApplicationId = applicationId;
            ApplicationFeatureId = applicationFeatureId;
            Content = content;
        }
        public WebhookContentItemDeletedEvent() { }
    }
}
