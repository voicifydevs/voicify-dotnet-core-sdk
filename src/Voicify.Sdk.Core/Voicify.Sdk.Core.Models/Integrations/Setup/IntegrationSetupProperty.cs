using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Voicify.Sdk.Core.Models.Converters;

namespace Voicify.Sdk.Core.Models.Integrations.Setup
{

    public class IntegrationSetupProperty
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public bool Required { get; set; }
        [Required]
        public string Label { get; set; }
        public string Tooltip { get; set; }
        [Required]
        [JsonConverter(typeof(IntegrationSetupFieldConverter))]
        public IIntegrationSetupField Field { get; set; }
    }
}
