using System.Collections.Generic;
using Voicify.Sdk.Core.Models.Content;
using Voicify.Sdk.Core.Models.Webhooks.Requests;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Webhook request to fulfill the response of a custom request message
    /// </summary>
    public class CustomRequestWebhookFulfillmentRequest : IWebhookFulfillmentRequest<CustomRequestSearchResponseModel>
    {
        public string Id { get; set; }

        public string RequestTypes { get; set; }
        public string RequestNames { get; set; }
        public string PlatformFilter { get; set; }
        public string Title { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public CustomRequestSearchResponseModel Response { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }
    }
}
