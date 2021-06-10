using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    public class EventWebhookRequest : EventWebhookRequest<EventWebhookEvent>
    {
    }
    public class EventWebhookRequest<T>
    {
        public string EventType { get; set; }
        public T Data { get; set; }
        public WebhookModel Webhook { get; set; }
    }
}
