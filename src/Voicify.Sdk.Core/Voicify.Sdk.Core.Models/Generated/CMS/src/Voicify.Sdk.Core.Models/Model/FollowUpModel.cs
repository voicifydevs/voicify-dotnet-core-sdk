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
    /// FollowUpModel
    /// </summary>
    [DataContract]
        public partial class FollowUpModel :  IEquatable<FollowUpModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FollowUpModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="content">content.</param>
        /// <param name="name">name.</param>
        /// <param name="followUpHints">followUpHints.</param>
        /// <param name="childContentContainerId">childContentContainerId.</param>
        /// <param name="childContentContainer">childContentContainer.</param>
        /// <param name="helpMessageId">helpMessageId.</param>
        /// <param name="helpMessage">helpMessage.</param>
        /// <param name="fallbackMessageId">fallbackMessageId.</param>
        /// <param name="fallbackMessage">fallbackMessage.</param>
        /// <param name="createdFromId">createdFromId.</param>
        /// <param name="appliedApplicationTemplateFormId">appliedApplicationTemplateFormId.</param>
        public FollowUpModel(string id = default(string), string applicationId = default(string), string content = default(string), string name = default(string), List<FollowUpHintModel> followUpHints = default(List<FollowUpHintModel>), string childContentContainerId = default(string), ChildContentContainerModel childContentContainer = default(ChildContentContainerModel), string helpMessageId = default(string), HelpMessageModel helpMessage = default(HelpMessageModel), string fallbackMessageId = default(string), FallbackMessageModel fallbackMessage = default(FallbackMessageModel), string createdFromId = default(string), string appliedApplicationTemplateFormId = default(string))
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.Content = content;
            this.Name = name;
            this.FollowUpHints = followUpHints;
            this.ChildContentContainerId = childContentContainerId;
            this.ChildContentContainer = childContentContainer;
            this.HelpMessageId = helpMessageId;
            this.HelpMessage = helpMessage;
            this.FallbackMessageId = fallbackMessageId;
            this.FallbackMessage = fallbackMessage;
            this.CreatedFromId = createdFromId;
            this.AppliedApplicationTemplateFormId = appliedApplicationTemplateFormId;
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
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FollowUpHints
        /// </summary>
        [DataMember(Name="followUpHints", EmitDefaultValue=false)]
        public List<FollowUpHintModel> FollowUpHints { get; set; }

        /// <summary>
        /// Gets or Sets ChildContentContainerId
        /// </summary>
        [DataMember(Name="childContentContainerId", EmitDefaultValue=false)]
        public string ChildContentContainerId { get; set; }

        /// <summary>
        /// Gets or Sets ChildContentContainer
        /// </summary>
        [DataMember(Name="childContentContainer", EmitDefaultValue=false)]
        public ChildContentContainerModel ChildContentContainer { get; set; }

        /// <summary>
        /// Gets or Sets HelpMessageId
        /// </summary>
        [DataMember(Name="helpMessageId", EmitDefaultValue=false)]
        public string HelpMessageId { get; set; }

        /// <summary>
        /// Gets or Sets HelpMessage
        /// </summary>
        [DataMember(Name="helpMessage", EmitDefaultValue=false)]
        public HelpMessageModel HelpMessage { get; set; }

        /// <summary>
        /// Gets or Sets FallbackMessageId
        /// </summary>
        [DataMember(Name="fallbackMessageId", EmitDefaultValue=false)]
        public string FallbackMessageId { get; set; }

        /// <summary>
        /// Gets or Sets FallbackMessage
        /// </summary>
        [DataMember(Name="fallbackMessage", EmitDefaultValue=false)]
        public FallbackMessageModel FallbackMessage { get; set; }

        /// <summary>
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Gets or Sets AppliedApplicationTemplateFormId
        /// </summary>
        [DataMember(Name="appliedApplicationTemplateFormId", EmitDefaultValue=false)]
        public string AppliedApplicationTemplateFormId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FollowUpModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FollowUpHints: ").Append(FollowUpHints).Append("\n");
            sb.Append("  ChildContentContainerId: ").Append(ChildContentContainerId).Append("\n");
            sb.Append("  ChildContentContainer: ").Append(ChildContentContainer).Append("\n");
            sb.Append("  HelpMessageId: ").Append(HelpMessageId).Append("\n");
            sb.Append("  HelpMessage: ").Append(HelpMessage).Append("\n");
            sb.Append("  FallbackMessageId: ").Append(FallbackMessageId).Append("\n");
            sb.Append("  FallbackMessage: ").Append(FallbackMessage).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
            sb.Append("  AppliedApplicationTemplateFormId: ").Append(AppliedApplicationTemplateFormId).Append("\n");
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
            return this.Equals(input as FollowUpModel);
        }

        /// <summary>
        /// Returns true if FollowUpModel instances are equal
        /// </summary>
        /// <param name="input">Instance of FollowUpModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FollowUpModel input)
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
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FollowUpHints == input.FollowUpHints ||
                    this.FollowUpHints != null &&
                    input.FollowUpHints != null &&
                    this.FollowUpHints.SequenceEqual(input.FollowUpHints)
                ) && 
                (
                    this.ChildContentContainerId == input.ChildContentContainerId ||
                    (this.ChildContentContainerId != null &&
                    this.ChildContentContainerId.Equals(input.ChildContentContainerId))
                ) && 
                (
                    this.ChildContentContainer == input.ChildContentContainer ||
                    (this.ChildContentContainer != null &&
                    this.ChildContentContainer.Equals(input.ChildContentContainer))
                ) && 
                (
                    this.HelpMessageId == input.HelpMessageId ||
                    (this.HelpMessageId != null &&
                    this.HelpMessageId.Equals(input.HelpMessageId))
                ) && 
                (
                    this.HelpMessage == input.HelpMessage ||
                    (this.HelpMessage != null &&
                    this.HelpMessage.Equals(input.HelpMessage))
                ) && 
                (
                    this.FallbackMessageId == input.FallbackMessageId ||
                    (this.FallbackMessageId != null &&
                    this.FallbackMessageId.Equals(input.FallbackMessageId))
                ) && 
                (
                    this.FallbackMessage == input.FallbackMessage ||
                    (this.FallbackMessage != null &&
                    this.FallbackMessage.Equals(input.FallbackMessage))
                ) && 
                (
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
                ) && 
                (
                    this.AppliedApplicationTemplateFormId == input.AppliedApplicationTemplateFormId ||
                    (this.AppliedApplicationTemplateFormId != null &&
                    this.AppliedApplicationTemplateFormId.Equals(input.AppliedApplicationTemplateFormId))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FollowUpHints != null)
                    hashCode = hashCode * 59 + this.FollowUpHints.GetHashCode();
                if (this.ChildContentContainerId != null)
                    hashCode = hashCode * 59 + this.ChildContentContainerId.GetHashCode();
                if (this.ChildContentContainer != null)
                    hashCode = hashCode * 59 + this.ChildContentContainer.GetHashCode();
                if (this.HelpMessageId != null)
                    hashCode = hashCode * 59 + this.HelpMessageId.GetHashCode();
                if (this.HelpMessage != null)
                    hashCode = hashCode * 59 + this.HelpMessage.GetHashCode();
                if (this.FallbackMessageId != null)
                    hashCode = hashCode * 59 + this.FallbackMessageId.GetHashCode();
                if (this.FallbackMessage != null)
                    hashCode = hashCode * 59 + this.FallbackMessage.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
                if (this.AppliedApplicationTemplateFormId != null)
                    hashCode = hashCode * 59 + this.AppliedApplicationTemplateFormId.GetHashCode();
                return hashCode;
            }
        }

    }
}
