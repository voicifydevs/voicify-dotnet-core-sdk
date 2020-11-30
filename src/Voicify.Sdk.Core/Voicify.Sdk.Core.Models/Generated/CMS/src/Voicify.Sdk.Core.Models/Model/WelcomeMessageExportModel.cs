/* 
 * Voicify CMS API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: V1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace Voicify.Sdk.Core.Models.Model
{
    /// <summary>
    /// WelcomeMessageExportModel
    /// </summary>
    [DataContract]
    public partial class WelcomeMessageExportModel :  IEquatable<WelcomeMessageExportModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeMessageExportModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationFeatureId">applicationFeatureId.</param>
        /// <param name="title">title.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="content">content.</param>
        /// <param name="smallImage">smallImage.</param>
        /// <param name="largeImage">largeImage.</param>
        /// <param name="backgroundImage">backgroundImage.</param>
        /// <param name="audio">audio.</param>
        /// <param name="video">video.</param>
        /// <param name="welcomeMessageWebhooks">welcomeMessageWebhooks.</param>
        /// <param name="mediaResponseContainer">mediaResponseContainer.</param>
        /// <param name="followUp">followUp.</param>
        /// <param name="hits">hits.</param>
        /// <param name="reprompt">reprompt.</param>
        /// <param name="repromptId">repromptId.</param>
        /// <param name="followUpId">followUpId.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="mediaResponseContainerId">mediaResponseContainerId.</param>
        /// <param name="displayTextOverride">displayTextOverride.</param>
        /// <param name="displayTitleOverride">displayTitleOverride.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="createdFromId">createdFromId.</param>
        /// <param name="languages">languages.</param>
        /// <param name="shouldNotSync">shouldNotSync.</param>
        public WelcomeMessageExportModel(string id = default(string), string applicationId = default(string), string applicationFeatureId = default(string), string title = default(string), bool? isLive = default(bool?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string content = default(string), MediaItemModel smallImage = default(MediaItemModel), MediaItemModel largeImage = default(MediaItemModel), MediaItemModel backgroundImage = default(MediaItemModel), MediaItemModel audio = default(MediaItemModel), MediaItemModel video = default(MediaItemModel), List<WelcomeMessageWebhookModel> welcomeMessageWebhooks = default(List<WelcomeMessageWebhookModel>), MediaResponseContainerModel mediaResponseContainer = default(MediaResponseContainerModel), FollowUpModel followUp = default(FollowUpModel), int? hits = default(int?), RepromptModel reprompt = default(RepromptModel), string repromptId = default(string), string followUpId = default(string), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), string mediaResponseContainerId = default(string), string displayTextOverride = default(string), string displayTitleOverride = default(string), bool? requiresParent = default(bool?), bool? isComplete = default(bool?), string createdFromId = default(string), List<LanguageModel> languages = default(List<LanguageModel>), bool? shouldNotSync = default(bool?))
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.ApplicationFeatureId = applicationFeatureId;
            this.Title = title;
            this.IsLive = isLive;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Content = content;
            this.SmallImage = smallImage;
            this.LargeImage = largeImage;
            this.BackgroundImage = backgroundImage;
            this.Audio = audio;
            this.Video = video;
            this.WelcomeMessageWebhooks = welcomeMessageWebhooks;
            this.MediaResponseContainer = mediaResponseContainer;
            this.FollowUp = followUp;
            this.Hits = hits;
            this.Reprompt = reprompt;
            this.RepromptId = repromptId;
            this.FollowUpId = followUpId;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.MediaResponseContainerId = mediaResponseContainerId;
            this.DisplayTextOverride = displayTextOverride;
            this.DisplayTitleOverride = displayTitleOverride;
            this.RequiresParent = requiresParent;
            this.IsComplete = isComplete;
            this.CreatedFromId = createdFromId;
            this.Languages = languages;
            this.ShouldNotSync = shouldNotSync;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationFeatureId
        /// </summary>
        [DataMember(Name="applicationFeatureId", EmitDefaultValue=false)]
        public string ApplicationFeatureId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets IsLive
        /// </summary>
        [DataMember(Name="isLive", EmitDefaultValue=false)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets SmallImage
        /// </summary>
        [DataMember(Name="smallImage", EmitDefaultValue=false)]
        public MediaItemModel SmallImage { get; set; }

        /// <summary>
        /// Gets or Sets LargeImage
        /// </summary>
        [DataMember(Name="largeImage", EmitDefaultValue=false)]
        public MediaItemModel LargeImage { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name="backgroundImage", EmitDefaultValue=false)]
        public MediaItemModel BackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name="audio", EmitDefaultValue=false)]
        public MediaItemModel Audio { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public MediaItemModel Video { get; set; }

        /// <summary>
        /// Gets or Sets WelcomeMessageWebhooks
        /// </summary>
        [DataMember(Name="welcomeMessageWebhooks", EmitDefaultValue=false)]
        public List<WelcomeMessageWebhookModel> WelcomeMessageWebhooks { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponseContainer
        /// </summary>
        [DataMember(Name="mediaResponseContainer", EmitDefaultValue=false)]
        public MediaResponseContainerModel MediaResponseContainer { get; set; }

        /// <summary>
        /// Gets or Sets FollowUp
        /// </summary>
        [DataMember(Name="followUp", EmitDefaultValue=false)]
        public FollowUpModel FollowUp { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name="hits", EmitDefaultValue=false)]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets Reprompt
        /// </summary>
        [DataMember(Name="reprompt", EmitDefaultValue=false)]
        public RepromptModel Reprompt { get; set; }

        /// <summary>
        /// Gets or Sets RepromptId
        /// </summary>
        [DataMember(Name="repromptId", EmitDefaultValue=false)]
        public string RepromptId { get; set; }

        /// <summary>
        /// Gets or Sets FollowUpId
        /// </summary>
        [DataMember(Name="followUpId", EmitDefaultValue=false)]
        public string FollowUpId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponseContainerId
        /// </summary>
        [DataMember(Name="mediaResponseContainerId", EmitDefaultValue=false)]
        public string MediaResponseContainerId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTextOverride
        /// </summary>
        [DataMember(Name="displayTextOverride", EmitDefaultValue=false)]
        public string DisplayTextOverride { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTitleOverride
        /// </summary>
        [DataMember(Name="displayTitleOverride", EmitDefaultValue=false)]
        public string DisplayTitleOverride { get; set; }

        /// <summary>
        /// Gets or Sets RequiresParent
        /// </summary>
        [DataMember(Name="requiresParent", EmitDefaultValue=false)]
        public bool? RequiresParent { get; set; }

        /// <summary>
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name="isComplete", EmitDefaultValue=false)]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguageModel> Languages { get; set; }

        /// <summary>
        /// Gets or Sets ShouldNotSync
        /// </summary>
        [DataMember(Name="shouldNotSync", EmitDefaultValue=false)]
        public bool? ShouldNotSync { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WelcomeMessageExportModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  SmallImage: ").Append(SmallImage).Append("\n");
            sb.Append("  LargeImage: ").Append(LargeImage).Append("\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  WelcomeMessageWebhooks: ").Append(WelcomeMessageWebhooks).Append("\n");
            sb.Append("  MediaResponseContainer: ").Append(MediaResponseContainer).Append("\n");
            sb.Append("  FollowUp: ").Append(FollowUp).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Reprompt: ").Append(Reprompt).Append("\n");
            sb.Append("  RepromptId: ").Append(RepromptId).Append("\n");
            sb.Append("  FollowUpId: ").Append(FollowUpId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  MediaResponseContainerId: ").Append(MediaResponseContainerId).Append("\n");
            sb.Append("  DisplayTextOverride: ").Append(DisplayTextOverride).Append("\n");
            sb.Append("  DisplayTitleOverride: ").Append(DisplayTitleOverride).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  ShouldNotSync: ").Append(ShouldNotSync).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WelcomeMessageExportModel);
        }

        /// <summary>
        /// Returns true if WelcomeMessageExportModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WelcomeMessageExportModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WelcomeMessageExportModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationFeatureId == input.ApplicationFeatureId ||
                    (this.ApplicationFeatureId != null &&
                    this.ApplicationFeatureId.Equals(input.ApplicationFeatureId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.IsLive == input.IsLive ||
                    (this.IsLive != null &&
                    this.IsLive.Equals(input.IsLive))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.SmallImage == input.SmallImage ||
                    (this.SmallImage != null &&
                    this.SmallImage.Equals(input.SmallImage))
                ) && 
                (
                    this.LargeImage == input.LargeImage ||
                    (this.LargeImage != null &&
                    this.LargeImage.Equals(input.LargeImage))
                ) && 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.WelcomeMessageWebhooks == input.WelcomeMessageWebhooks ||
                    this.WelcomeMessageWebhooks != null &&
                    this.WelcomeMessageWebhooks.SequenceEqual(input.WelcomeMessageWebhooks)
                ) && 
                (
                    this.MediaResponseContainer == input.MediaResponseContainer ||
                    (this.MediaResponseContainer != null &&
                    this.MediaResponseContainer.Equals(input.MediaResponseContainer))
                ) && 
                (
                    this.FollowUp == input.FollowUp ||
                    (this.FollowUp != null &&
                    this.FollowUp.Equals(input.FollowUp))
                ) && 
                (
                    this.Hits == input.Hits ||
                    (this.Hits != null &&
                    this.Hits.Equals(input.Hits))
                ) && 
                (
                    this.Reprompt == input.Reprompt ||
                    (this.Reprompt != null &&
                    this.Reprompt.Equals(input.Reprompt))
                ) && 
                (
                    this.RepromptId == input.RepromptId ||
                    (this.RepromptId != null &&
                    this.RepromptId.Equals(input.RepromptId))
                ) && 
                (
                    this.FollowUpId == input.FollowUpId ||
                    (this.FollowUpId != null &&
                    this.FollowUpId.Equals(input.FollowUpId))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.MediaResponseContainerId == input.MediaResponseContainerId ||
                    (this.MediaResponseContainerId != null &&
                    this.MediaResponseContainerId.Equals(input.MediaResponseContainerId))
                ) && 
                (
                    this.DisplayTextOverride == input.DisplayTextOverride ||
                    (this.DisplayTextOverride != null &&
                    this.DisplayTextOverride.Equals(input.DisplayTextOverride))
                ) && 
                (
                    this.DisplayTitleOverride == input.DisplayTitleOverride ||
                    (this.DisplayTitleOverride != null &&
                    this.DisplayTitleOverride.Equals(input.DisplayTitleOverride))
                ) && 
                (
                    this.RequiresParent == input.RequiresParent ||
                    (this.RequiresParent != null &&
                    this.RequiresParent.Equals(input.RequiresParent))
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    (this.IsComplete != null &&
                    this.IsComplete.Equals(input.IsComplete))
                ) && 
                (
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.ShouldNotSync == input.ShouldNotSync ||
                    (this.ShouldNotSync != null &&
                    this.ShouldNotSync.Equals(input.ShouldNotSync))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationFeatureId != null)
                    hashCode = hashCode * 59 + this.ApplicationFeatureId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.SmallImage != null)
                    hashCode = hashCode * 59 + this.SmallImage.GetHashCode();
                if (this.LargeImage != null)
                    hashCode = hashCode * 59 + this.LargeImage.GetHashCode();
                if (this.BackgroundImage != null)
                    hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.WelcomeMessageWebhooks != null)
                    hashCode = hashCode * 59 + this.WelcomeMessageWebhooks.GetHashCode();
                if (this.MediaResponseContainer != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainer.GetHashCode();
                if (this.FollowUp != null)
                    hashCode = hashCode * 59 + this.FollowUp.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.Reprompt != null)
                    hashCode = hashCode * 59 + this.Reprompt.GetHashCode();
                if (this.RepromptId != null)
                    hashCode = hashCode * 59 + this.RepromptId.GetHashCode();
                if (this.FollowUpId != null)
                    hashCode = hashCode * 59 + this.FollowUpId.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.MediaResponseContainerId != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainerId.GetHashCode();
                if (this.DisplayTextOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTextOverride.GetHashCode();
                if (this.DisplayTitleOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTitleOverride.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.ShouldNotSync != null)
                    hashCode = hashCode * 59 + this.ShouldNotSync.GetHashCode();
                return hashCode;
            }
        }

    }

}
