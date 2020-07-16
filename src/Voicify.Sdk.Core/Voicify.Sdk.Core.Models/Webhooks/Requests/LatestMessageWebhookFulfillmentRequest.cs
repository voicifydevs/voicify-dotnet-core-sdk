using System.Collections.Generic;
using Voicify.Sdk.Core.Models.Content;
using Voicify.Sdk.Core.Models.Webhooks.Requests;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Webhook request to fulfill the response of a latest message
    /// </summary>
    public class LatestMessageWebhookFulfillmentRequest : IWebhookFulfillmentRequest<LatestMessageSearchResponseModel>
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public LatestMessageSearchResponseModel Response { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }
    }
}
