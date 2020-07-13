using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Voicify.Sdk.Core.Models.Content;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Core.Models.Webhooks.Responses
{
    /// <summary>
    /// Contains basic information shared amongst content fulfillment
    /// webhook responses that all must adhere to.
    /// 
    /// This model data is merged with the end result to send the response back down the the assistant
    /// </summary>
    public class ContentFulfillmentWebhookData
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public MediaItemModel SmallImage { get; set; }
        public MediaItemModel LargeImage { get; set; }
        public MediaItemModel BackgroundImage { get; set; }
        public MediaItemModel Audio { get; set; }
        public MediaItemModel Video { get; set; }
        public string DisplayTextOverride { get; set; }
        public string DisplayTitleOverride { get; set; }
        public FollowUpModel FollowUp { get; set; }
        public RepromptModel Reprompt { get; set; }
        public AccountLinkingModel AccountLinking { get; set; }
        public MediaResponseModel MediaResponse { get; set; }
        public PermissionModel Permissions { get; set; }

        /// <summary>
        /// Properties here are merged with the Voicify managed session attributes
        /// </summary>
        public Dictionary<string, object> AdditionalSessionAttributes { get; set; }

        /// <summary>
        /// Keys here are used to remove custom attributes that were previously added by the webhook or other hooks.
        /// This cannot be used to clear Voicify internal keys
        /// </summary>
        public string[] RemovedSessionAttributes { get; set; }

        /// <summary>
        /// Allows for overriding the entire response to the assistant by returning a native assistant response
        /// </summary>
        public object PayloadOverride { get; set; }

        public void Merge(IResponseModel model, FollowUpModel followUp, RepromptModel reprompt, MediaResponseModel mediaResponse)
        {
            Content = Content ?? model.Content;
            SmallImage = SmallImage ?? model.SmallImage;
            LargeImage = LargeImage ?? model.LargeImage;
            BackgroundImage = BackgroundImage ?? model.BackgroundImage;
            Audio = Audio ?? model.Audio;
            Video = Video ?? model.Video;
            DisplayTextOverride = DisplayTextOverride ?? model.DisplayTextOverride;
            DisplayTitleOverride = DisplayTitleOverride ?? model.DisplayTitleOverride;
            FollowUp = FollowUp ?? followUp;
            Reprompt = Reprompt ?? reprompt;
            MediaResponse = MediaResponse ?? mediaResponse;
        }
    }
}
