using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Content;
using Voicify.Sdk.Core.Models.Webhooks.Requests;


namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// The top level webhook fulfillment request model
    /// containing the data sent to a webhook to get a content
    /// fulfillment response
    /// </summary>
    public class GeneralWebhookFulfillmentRequest : IWebhookFulfillmentRequest<GeneralResponseModel>
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public GeneralResponseModel Response { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }
    }
}
