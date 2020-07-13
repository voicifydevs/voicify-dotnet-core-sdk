using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Content
{
    /// <summary>
    /// Represents a piece of content with media urls
    /// </summary>
    public interface IResponseModel
    {
        string Id { get; set; }
        MediaItemModel SmallImage { get; set; }
        MediaItemModel LargeImage { get; set; }
        MediaItemModel BackgroundImage { get; set; }
        MediaItemModel Audio { get; set; }
        MediaItemModel Video { get; set; }
        string Content { get; set; }
        RepromptModel Reprompt { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        string MediaResponseContainerId { get; set; }
        string DisplayTextOverride { get; set; }
        string DisplayTitleOverride { get; set; }
        string FollowUpId { get; set; }
        string RepromptId { get; set; }
    }
}
