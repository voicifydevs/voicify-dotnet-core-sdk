using System;
using System.Collections.Generic;
using System.Text;
using Voicify.Sdk.Core.Models.Content;
using Voicify.Sdk.Core.Models.Model;
using Voicify.Sdk.Core.Models.Webhooks.Responses;

namespace Voicify.Sdk.Core.Models.Webhooks.Requests
{
    /// <summary>
    /// Contains properties that all feature server response models
    /// should have to send back to the voice experience platform
    /// </summary>
    public abstract class BaseFeatureResponseModel
    {
        public string Id { get; set; }
        public string ApplicationId { get; set; }
        public string UserId { get; set; }
        public string Assistant { get; set; }
        public DateTime ResponseDate { get; set; } = DateTime.UtcNow;
        public FollowUpModel FollowUp { get; set; }
        public MediaResponseModel MediaResponse { get; set; }
        public AccountLinkingModel AccountLinking { get; set; }
        public PermissionModel Permissions { get; set; }
        public GeneralFeatureResponseData Data { get; set; }
        public IEnumerable<string> FollowUpQuestionVariations { get; set; }
        /// <summary>
        /// Properties here are merged with the Voicify managed session attributes
        /// </summary>
        public Dictionary<string, object> AdditionalSessionAttributes { get; set; }
        public string[] RemovedSessionAttributes { get; set; }
        /// <summary>
        /// Allows for overriding the entire response to the assistant by returning a native assistant response
        /// </summary>
        public object PayloadOverride { get; set; }
    }
}
