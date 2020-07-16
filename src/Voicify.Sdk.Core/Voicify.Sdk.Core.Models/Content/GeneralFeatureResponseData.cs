using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Content
{

    /// <summary>
    /// Represents a feature response data set that is both the media response and the content of the parent or self
    /// </summary>
    public class GeneralFeatureResponseData : GeneralResponseModel, IFeatureResponseData
    {
        public string ApplicationId { get; set; }
        public string ApplicationFeatureId { get; set; }
        public bool IsLive { get; set; }
        public int Hits { get; set; }
        public string Title { get; set; }
        public bool RequiresParent { get; set; }
        public bool IsComplete { get; set; }
    }
}
