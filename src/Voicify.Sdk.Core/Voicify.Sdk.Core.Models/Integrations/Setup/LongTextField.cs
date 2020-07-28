﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{
    public class LongTextField : IIntegrationSetupField
    {
        public string Placeholder { get; set; }
        public string FieldType
        {
            get { return nameof(LongTextField); }
        }
    }
}
