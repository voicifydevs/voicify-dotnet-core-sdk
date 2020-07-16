using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class CheckboxField : IIntegrationSetupField
    {
        public string FieldType {
            get { return nameof(CheckboxField); }
        }
    }
}
