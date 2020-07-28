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
    /// GenericContentModel
    /// </summary>
    [DataContract]
    public partial class GenericContentModel :  IEquatable<GenericContentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericContentModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="hits">hits.</param>
        /// <param name="title">title.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="featureTypeId">featureTypeId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationFeatureId">applicationFeatureId.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="hasAudio">hasAudio.</param>
        /// <param name="hasVideo">hasVideo.</param>
        /// <param name="hasBackgroundImage">hasBackgroundImage.</param>
        /// <param name="hasForegroundImage">hasForegroundImage.</param>
        /// <param name="followUpId">followUpId.</param>
        /// <param name="languages">languages.</param>
        /// <param name="shouldNotSync">shouldNotSync.</param>
        /// <param name="createdFromId">createdFromId.</param>
        public GenericContentModel(string id = default(string), bool? isLive = default(bool?), int? hits = default(int?), string title = default(string), bool? requiresParent = default(bool?), bool? isComplete = default(bool?), string featureTypeId = default(string), string applicationId = default(string), string applicationFeatureId = default(string), DateTime? modifiedDate = default(DateTime?), DateTime? createdDate = default(DateTime?), bool? hasAudio = default(bool?), bool? hasVideo = default(bool?), bool? hasBackgroundImage = default(bool?), bool? hasForegroundImage = default(bool?), string followUpId = default(string), List<LanguageModel> languages = default(List<LanguageModel>), bool? shouldNotSync = default(bool?), string createdFromId = default(string))
        {
            this.Id = id;
            this.IsLive = isLive;
            this.Hits = hits;
            this.Title = title;
            this.RequiresParent = requiresParent;
            this.IsComplete = isComplete;
            this.FeatureTypeId = featureTypeId;
            this.ApplicationId = applicationId;
            this.ApplicationFeatureId = applicationFeatureId;
            this.ModifiedDate = modifiedDate;
            this.CreatedDate = createdDate;
            this.HasAudio = hasAudio;
            this.HasVideo = hasVideo;
            this.HasBackgroundImage = hasBackgroundImage;
            this.HasForegroundImage = hasForegroundImage;
            this.FollowUpId = followUpId;
            this.Languages = languages;
            this.ShouldNotSync = shouldNotSync;
            this.CreatedFromId = createdFromId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsLive
        /// </summary>
        [DataMember(Name="isLive", EmitDefaultValue=false)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name="hits", EmitDefaultValue=false)]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

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
        /// Gets or Sets FeatureTypeId
        /// </summary>
        [DataMember(Name="featureTypeId", EmitDefaultValue=false)]
        public string FeatureTypeId { get; set; }

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
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets HasAudio
        /// </summary>
        [DataMember(Name="hasAudio", EmitDefaultValue=false)]
        public bool? HasAudio { get; set; }

        /// <summary>
        /// Gets or Sets HasVideo
        /// </summary>
        [DataMember(Name="hasVideo", EmitDefaultValue=false)]
        public bool? HasVideo { get; set; }

        /// <summary>
        /// Gets or Sets HasBackgroundImage
        /// </summary>
        [DataMember(Name="hasBackgroundImage", EmitDefaultValue=false)]
        public bool? HasBackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets HasForegroundImage
        /// </summary>
        [DataMember(Name="hasForegroundImage", EmitDefaultValue=false)]
        public bool? HasForegroundImage { get; set; }

        /// <summary>
        /// Gets or Sets FollowUpId
        /// </summary>
        [DataMember(Name="followUpId", EmitDefaultValue=false)]
        public string FollowUpId { get; set; }

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
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericContentModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  FeatureTypeId: ").Append(FeatureTypeId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  HasAudio: ").Append(HasAudio).Append("\n");
            sb.Append("  HasVideo: ").Append(HasVideo).Append("\n");
            sb.Append("  HasBackgroundImage: ").Append(HasBackgroundImage).Append("\n");
            sb.Append("  HasForegroundImage: ").Append(HasForegroundImage).Append("\n");
            sb.Append("  FollowUpId: ").Append(FollowUpId).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  ShouldNotSync: ").Append(ShouldNotSync).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
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
            return this.Equals(input as GenericContentModel);
        }

        /// <summary>
        /// Returns true if GenericContentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericContentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericContentModel input)
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
                    this.IsLive == input.IsLive ||
                    (this.IsLive != null &&
                    this.IsLive.Equals(input.IsLive))
                ) && 
                (
                    this.Hits == input.Hits ||
                    (this.Hits != null &&
                    this.Hits.Equals(input.Hits))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                    this.FeatureTypeId == input.FeatureTypeId ||
                    (this.FeatureTypeId != null &&
                    this.FeatureTypeId.Equals(input.FeatureTypeId))
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
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.HasAudio == input.HasAudio ||
                    (this.HasAudio != null &&
                    this.HasAudio.Equals(input.HasAudio))
                ) && 
                (
                    this.HasVideo == input.HasVideo ||
                    (this.HasVideo != null &&
                    this.HasVideo.Equals(input.HasVideo))
                ) && 
                (
                    this.HasBackgroundImage == input.HasBackgroundImage ||
                    (this.HasBackgroundImage != null &&
                    this.HasBackgroundImage.Equals(input.HasBackgroundImage))
                ) && 
                (
                    this.HasForegroundImage == input.HasForegroundImage ||
                    (this.HasForegroundImage != null &&
                    this.HasForegroundImage.Equals(input.HasForegroundImage))
                ) && 
                (
                    this.FollowUpId == input.FollowUpId ||
                    (this.FollowUpId != null &&
                    this.FollowUpId.Equals(input.FollowUpId))
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
                ) && 
                (
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
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
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.FeatureTypeId != null)
                    hashCode = hashCode * 59 + this.FeatureTypeId.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationFeatureId != null)
                    hashCode = hashCode * 59 + this.ApplicationFeatureId.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.HasAudio != null)
                    hashCode = hashCode * 59 + this.HasAudio.GetHashCode();
                if (this.HasVideo != null)
                    hashCode = hashCode * 59 + this.HasVideo.GetHashCode();
                if (this.HasBackgroundImage != null)
                    hashCode = hashCode * 59 + this.HasBackgroundImage.GetHashCode();
                if (this.HasForegroundImage != null)
                    hashCode = hashCode * 59 + this.HasForegroundImage.GetHashCode();
                if (this.FollowUpId != null)
                    hashCode = hashCode * 59 + this.FollowUpId.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.ShouldNotSync != null)
                    hashCode = hashCode * 59 + this.ShouldNotSync.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}