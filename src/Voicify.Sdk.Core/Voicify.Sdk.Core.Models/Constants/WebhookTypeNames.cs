using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Constants
{
    /// <summary>
    /// Names of the different webhook types supported in Voicify
    /// </summary>
    public static class WebhookTypeNames
    {
        public static string CONTENT_ITEM_RESPONSE_RESOLVER = "Content Item Response Resolver";
        public static string APPLICATION_RESPONSE_RESOLVER = "Application Content Response Resolver";
        public static string APPLICATION_FEATURE_RESPONSE_RESOLVER = "Application Feature Content Response Resolver";
        public static string CONTENT_ITEM_SAVED_EVENT = "Content Item Saved Event";
        public static string FEATURE_MISS_EVENT = "Feature Miss Event";
        public static string CONTENT_MISS_EVENT = "Content Miss Event";
        public static string CONTENT_HIT_EVENT = "Content Hit Event";
        public static string REQUEST_RECEIVED_EVENT = "Request Received Event";
        public static string CONTENT_ITEM_DELETED = "Content Item Deleted";
    }
}
