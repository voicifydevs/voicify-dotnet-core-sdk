using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Content;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Webhook request to fulfill the response of a number range
    /// </summary>
    public class NumberRangeWebhookFulfillmentRequest : IWebhookFulfillmentRequest<NumberRangeSearchResponseModel>
    {
        public string Id { get; set; }
        public double? MinimumValue { get; set; }
        public double? MaximumValue { get; set; }
        public string Title { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public NumberRangeSearchResponseModel Response { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }
    }
}
