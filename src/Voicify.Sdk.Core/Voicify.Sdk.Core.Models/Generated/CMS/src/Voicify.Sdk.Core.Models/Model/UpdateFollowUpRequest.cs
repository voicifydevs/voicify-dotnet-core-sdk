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
    /// UpdateFollowUpRequest
    /// </summary>
    [DataContract]
        public partial class UpdateFollowUpRequest :  IEquatable<UpdateFollowUpRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFollowUpRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="content">content.</param>
        /// <param name="name">name.</param>
        /// <param name="followUpHints">followUpHints.</param>
        /// <param name="childContentContainer">childContentContainer.</param>
        /// <param name="fallbackMessageId">fallbackMessageId.</param>
        /// <param name="helpMessageId">helpMessageId.</param>
        public UpdateFollowUpRequest(string id = default(string), string content = default(string), string name = default(string), List<UpdateFollowUpHintRequest> followUpHints = default(List<UpdateFollowUpHintRequest>), UpdateChildContentContainerRequest childContentContainer = default(UpdateChildContentContainerRequest), string fallbackMessageId = default(string), string helpMessageId = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UpdateFollowUpRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.Content = content;
            this.Name = name;
            this.FollowUpHints = followUpHints;
            this.ChildContentContainer = childContentContainer;
            this.FallbackMessageId = fallbackMessageId;
            this.HelpMessageId = helpMessageId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
        public List<UpdateFollowUpHintRequest> FollowUpHints { get; set; }

        /// <summary>
        /// Gets or Sets ChildContentContainer
        /// </summary>
        [DataMember(Name="childContentContainer", EmitDefaultValue=false)]
        public UpdateChildContentContainerRequest ChildContentContainer { get; set; }

        /// <summary>
        /// Gets or Sets FallbackMessageId
        /// </summary>
        [DataMember(Name="fallbackMessageId", EmitDefaultValue=false)]
        public string FallbackMessageId { get; set; }

        /// <summary>
        /// Gets or Sets HelpMessageId
        /// </summary>
        [DataMember(Name="helpMessageId", EmitDefaultValue=false)]
        public string HelpMessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFollowUpRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FollowUpHints: ").Append(FollowUpHints).Append("\n");
            sb.Append("  ChildContentContainer: ").Append(ChildContentContainer).Append("\n");
            sb.Append("  FallbackMessageId: ").Append(FallbackMessageId).Append("\n");
            sb.Append("  HelpMessageId: ").Append(HelpMessageId).Append("\n");
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
            return this.Equals(input as UpdateFollowUpRequest);
        }

        /// <summary>
        /// Returns true if UpdateFollowUpRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFollowUpRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFollowUpRequest input)
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
                    this.ChildContentContainer == input.ChildContentContainer ||
                    (this.ChildContentContainer != null &&
                    this.ChildContentContainer.Equals(input.ChildContentContainer))
                ) && 
                (
                    this.FallbackMessageId == input.FallbackMessageId ||
                    (this.FallbackMessageId != null &&
                    this.FallbackMessageId.Equals(input.FallbackMessageId))
                ) && 
                (
                    this.HelpMessageId == input.HelpMessageId ||
                    (this.HelpMessageId != null &&
                    this.HelpMessageId.Equals(input.HelpMessageId))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FollowUpHints != null)
                    hashCode = hashCode * 59 + this.FollowUpHints.GetHashCode();
                if (this.ChildContentContainer != null)
                    hashCode = hashCode * 59 + this.ChildContentContainer.GetHashCode();
                if (this.FallbackMessageId != null)
                    hashCode = hashCode * 59 + this.FallbackMessageId.GetHashCode();
                if (this.HelpMessageId != null)
                    hashCode = hashCode * 59 + this.HelpMessageId.GetHashCode();
                return hashCode;
            }
        }

    }
}
