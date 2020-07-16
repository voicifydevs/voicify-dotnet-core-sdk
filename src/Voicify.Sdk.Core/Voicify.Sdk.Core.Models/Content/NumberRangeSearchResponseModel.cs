﻿using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Content
{
    /// <summary>
    /// For a number range variation
    /// </summary>
    public class NumberRangeSearchResponseModel : NumberRangeResponseModel, IFeatureResponseData
    {
        public string ApplicationFeatureId { get; set; }
        public string ApplicationId { get; set; }
        public bool IsLive { get; set; }
        public int Hits { get; set; }
        public string Title { get; set; }
        public bool RequiresParent { get; set; }
        public bool IsComplete { get; set; }
    }
}
