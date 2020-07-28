using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Constants
{
    public class EventWebhookEventTypes
    {
        public const string ContentHit = nameof(ContentHit);
        public const string ContentMiss = nameof(ContentMiss);
        public const string FeatureHit = nameof(FeatureHit);
        public const string FeatureMiss = nameof(FeatureMiss);
        public const string RequestReceived = nameof(RequestReceived);
        public const string ContentItemSaved = nameof(ContentItemSaved);
        public const string ContentItemDeleted = nameof(ContentItemDeleted);
    }
}
