using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Content
{
    /// <summary>
    /// Base fields that any conversation or content item implements
    /// </summary>
    public interface IContentItemModel
    {
        string ApplicationId { get; set; }
        string ApplicationFeatureId { get; set; }
        string Id { get; set; }
        bool IsLive { get; set; }
        int Hits { get; set; }
        string Title { get; set; }
        bool RequiresParent { get; set; }
        bool IsComplete { get; set; }
        DateTime ModifiedDate { get; set; }
        DateTime CreatedDate { get; set; }
        IEnumerable<LanguageModel> Languages { get; set; }
    }
}
