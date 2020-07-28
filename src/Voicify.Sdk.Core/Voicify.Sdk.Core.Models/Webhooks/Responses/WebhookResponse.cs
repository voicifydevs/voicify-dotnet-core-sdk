using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Responses
{
    /// <summary>
    /// Generic wrapper for a webhook response
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class WebhookResponse<TData>
    {
        public TData Data { get; set; }
    }
}
