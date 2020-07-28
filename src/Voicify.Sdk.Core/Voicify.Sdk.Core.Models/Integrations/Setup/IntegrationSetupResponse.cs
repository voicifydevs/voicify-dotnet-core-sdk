using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class IntegrationSetupResponse
    {
        /// <summary>
        /// A oauth url to redirect the client
        /// </summary>
        public string OAuthUrl { get; set; }
        /// <summary>
        /// A dictionary of key: additionalPropertyName, value: additionalPropertyType
        /// </summary>
        public Dictionary<string, string> AdditionalPropertiesConfiguration { get; set; }
        /// <summary>
        /// A list of the setup sections to be rendered in the client.
        /// </summary>
        public List<IntegrationSetupSection> SetupSections { get; set; }
    }
}
