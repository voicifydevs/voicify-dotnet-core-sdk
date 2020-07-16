using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Content
{
    public class GeneralResponseModel : IResponseModel
    {
        public string Id { get; set; }
        public MediaItemModel SmallImage { get; set; }
        public MediaItemModel LargeImage { get; set; }
        public MediaItemModel BackgroundImage { get; set; }
        public MediaItemModel Audio { get; set; }
        public MediaItemModel Video { get; set; }
        public string Content { get; set; }
        public RepromptModel Reprompt { get; set; }
        public FollowUpModel FollowUp { get; set; }
        public MediaResponseContainerModel MediaResponseContainer { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string MediaResponseContainerId { get; set; }
        public string DisplayTextOverride { get; set; }
        public string DisplayTitleOverride { get; set; }
        public string FollowUpId { get; set; }
        public string RepromptId { get; set; }
    }
}
