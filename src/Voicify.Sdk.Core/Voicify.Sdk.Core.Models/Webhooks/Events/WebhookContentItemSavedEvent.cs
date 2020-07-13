using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Constants;
using Voicify.Sdk.Core.Models.Content;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    public class WebhookContentItemSavedEvent : EventWebhookEvent
    {
        public override string EventType => EventWebhookEventTypes.ContentItemSaved;
        public string ApplicationFeatureId { get; set; }
        public GeneralContentItemModel Content { get; set; }
    }
}
