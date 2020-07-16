using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class SelectField : IIntegrationSetupField
    {
        public List<SelectFieldOption> Options { get; set; }
        public string FieldType
        {
            get { return nameof(SelectField); }
            set { }
        }
    }
}
