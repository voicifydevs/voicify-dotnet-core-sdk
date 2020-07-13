using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    public class QuestionAnswerWebhookFulfillmentRequest : IWebhookFulfillmentRequest<AnswerModel>
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationModuleId { get; set; }
        public string QuestionAnswerId { get; set; }
        public string Title { get; set; }
        public string ApplicationFeatureId { get; set; }
        public bool IsLive { get; set; }
        public AnswerModel Response { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public GeneralAssistantRequest OriginalRequest { get; set; }
    }
}
