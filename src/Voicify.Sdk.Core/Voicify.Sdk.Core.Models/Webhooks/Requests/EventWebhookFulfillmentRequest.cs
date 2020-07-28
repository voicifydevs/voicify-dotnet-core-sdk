using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Request model for sending to a webhook to fulfill the response
    /// for the event item
    /// </summary>
    public class EventWebhookFulfillmentRequest : IWebhookFulfillmentRequest<EventResponseModel>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public string OwnerName { get; set; }
        public string Status { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public EventResponseModel Response { get; set; }
        public List<string> Categories { get; set; }
        public EventQueryType QueryType { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }
    }
}
