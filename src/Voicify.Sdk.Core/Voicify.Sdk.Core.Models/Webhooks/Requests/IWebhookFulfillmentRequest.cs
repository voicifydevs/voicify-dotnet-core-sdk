using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Content;
using Voicify.Sdk.Core.Models.Webhooks.Requests;


namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Webhook request to fulfill the response of a latest message
    /// </summary>
    public interface IWebhookFulfillmentRequest<TResponse> where TResponse : IResponseModel
    {
        string Id { get; set; }
        string Title { get; set; }
        string ApplicationId { get; set; }
        string ApplicationFeatureId { get; set; }
        Dictionary<string,string> Parameters { get; set; }
        GeneralAssistantRequest OriginalRequest { get; set; }
        TResponse Response { get; set; }
    }
}
