using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class SsmlField : IIntegrationSetupField
    {
        public string Placeholder { get; set; }
        public string FieldType
        {
            get { return nameof(SsmlField); }
        }

        //TODO: add audio stuff?
    }
}
