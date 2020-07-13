using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Content
{
    /// <summary>
    /// Base fields that any conversation or content item implements
    /// </summary>
    public class GeneralContentItemModel : IContentItemModel
    {
        public string ApplicationId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public string Id { get; set; }
        public bool IsLive { get; set; }
        public int Hits { get; set; }
        public string Title { get; set; }
        public bool RequiresParent { get; set; }
        public bool IsComplete { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public IEnumerable<LanguageModel> Languages { get; set; }
    }
}
