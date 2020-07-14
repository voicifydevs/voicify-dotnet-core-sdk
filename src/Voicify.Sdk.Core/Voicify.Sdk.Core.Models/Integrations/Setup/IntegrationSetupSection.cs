using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class IntegrationSetupSection
    {
        public string InstructionsMarkdown { get; set; }
        public List<IntegrationSetupProperty> Properties { get; set; }
    }
}
