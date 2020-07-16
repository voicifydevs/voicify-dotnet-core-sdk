using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Constants
{
    /// <summary>
    /// Contains constant values for custom http headers used in requests to and from Voicify
    /// </summary>
    public sealed class VoicifyHeaders
    {
        public const string VoicifyInternalAccess = "VOICIFY-INTERNAL-ACCESS";
        public const string VoicifyExternalAccess = "VOICIFY-EXTERNAL-ACCESS";
        public const string VoicifyApplicationSecret = "VOICIFY-APPLICATION-SECRET";
        public const string VoicifyApplicationId = "VOICIFY-APPLICATION-ID";
    }
}
