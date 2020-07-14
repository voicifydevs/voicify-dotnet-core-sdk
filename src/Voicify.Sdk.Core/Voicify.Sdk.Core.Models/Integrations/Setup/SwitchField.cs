using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class SwitchField : IIntegrationSetupField
    {
        public string LeftOption { get; set; }
        public string RightOption { get; set; }
        public string FieldType
        {
            get { return nameof(SwitchField); }
        }
    }
}
