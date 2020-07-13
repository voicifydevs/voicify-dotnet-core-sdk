using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Events
{
    /// <summary>
    /// Model used for tracking a basic analytics event
    /// for end-user usage of the application
    /// </summary>
    public class EventWebhookEvent
    {
        public string Id { get; set; }
        public string ApplicationId { get; set; }
        public DateTime EventDate { get; set; } = DateTime.UtcNow;
        public virtual string EventType { get; set; } // overridden by inheritted implementation
        public string Assistant { get; set; }
        public string RequestId { get; set; }
        public string SessionId { get; set; }
        public string DeviceTargetId { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
    }
}
