using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// enum values for the type of event search being made
    /// </summary>
    public enum EventQueryType
    {
        General,
        Location,
        StartDate,
        Status
    }
}
