using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Webhooks.Responses
{
    public class PermissionModel
    {
        public string[] GooglePermissions { get; set; }
        public string GooglePermissionPrompt { get; set; }
        public string[] AlexaPermissions { get; set; }
        public string AlexaPermissionPrompt { get; set; }
    }
}
