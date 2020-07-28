using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Responses
{
    public class AccountLinkingModel
    {
        public string GoogleAccountLinkingPrompt { get; set; }
        public string AlexaAccountLinkingPrompt { get; set; }
    }
}
