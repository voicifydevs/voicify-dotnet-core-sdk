using Voicify.Sdk.Core.Models.Constants;
using Voicify.Sdk.Core.Models.Webhooks.Requests;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    /// <summary>
    /// Event data for when content is found from a request
    /// </summary>
    public class WebhookContentHitEvent : EventWebhookEvent
    {
        public BaseFeatureResponseModel Content {get;set;}
        public GeneralAssistantRequest OriginalRequest { get; set; }
        public string FeatureTypeId { get; set; }
        public string ApplicationModuleId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public override string EventType => EventWebhookEventTypes.ContentHit;
    }
}
