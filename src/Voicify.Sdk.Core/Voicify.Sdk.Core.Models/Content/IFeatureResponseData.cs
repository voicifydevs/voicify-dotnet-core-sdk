using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Content
{
    /// <summary>
    /// Represents a feature response data set that is both the media response and the content of the parent or self
    /// </summary>
    public interface IFeatureResponseData : IResponseModel
    {
        string ApplicationId { get; set; }
        string ApplicationFeatureId { get; set; }
        string Id { get; set; }
        bool IsLive { get; set; }
        int Hits { get; set; }
        string Title { get; set; }
        bool RequiresParent { get; set; }
        bool IsComplete { get; set; }
    }
}
