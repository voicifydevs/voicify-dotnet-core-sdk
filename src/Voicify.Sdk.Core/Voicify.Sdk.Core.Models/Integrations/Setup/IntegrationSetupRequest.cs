using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class IntegrationSetupRequest
    {

        [Required]
        public string AccessToken { get; set; }
        [Required]
        public string OrganizationId { get; set; }
        public Dictionary<string, string> AdditionalProperties { get; set; }
    }
}
