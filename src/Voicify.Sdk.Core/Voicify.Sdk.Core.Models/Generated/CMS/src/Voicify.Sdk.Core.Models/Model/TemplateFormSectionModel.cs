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
    /// TemplateFormSectionModel
    /// </summary>
    [DataContract]
    public partial class TemplateFormSectionModel :  IEquatable<TemplateFormSectionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFormSectionModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateFormSectionModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFormSectionModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="templateFormId">templateFormId.</param>
        /// <param name="instructionsMarkdown">instructionsMarkdown.</param>
        /// <param name="title">title (required).</param>
        /// <param name="priority">priority.</param>
        /// <param name="templateFormFields">templateFormFields.</param>
        public TemplateFormSectionModel(string id = default(string), string templateFormId = default(string), string instructionsMarkdown = default(string), string title = default(string), int? priority = default(int?), List<TemplateFormFieldModel> templateFormFields = default(List<TemplateFormFieldModel>))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for TemplateFormSectionModel and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.Id = id;
            this.TemplateFormId = templateFormId;
            this.InstructionsMarkdown = instructionsMarkdown;
            this.Priority = priority;
            this.TemplateFormFields = templateFormFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormId
        /// </summary>
        [DataMember(Name="templateFormId", EmitDefaultValue=false)]
        public string TemplateFormId { get; set; }

        /// <summary>
        /// Gets or Sets InstructionsMarkdown
        /// </summary>
        [DataMember(Name="instructionsMarkdown", EmitDefaultValue=false)]
        public string InstructionsMarkdown { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormFields
        /// </summary>
        [DataMember(Name="templateFormFields", EmitDefaultValue=false)]
        public List<TemplateFormFieldModel> TemplateFormFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateFormSectionModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateFormId: ").Append(TemplateFormId).Append("\n");
            sb.Append("  InstructionsMarkdown: ").Append(InstructionsMarkdown).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  TemplateFormFields: ").Append(TemplateFormFields).Append("\n");
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
            return this.Equals(input as TemplateFormSectionModel);
        }

        /// <summary>
        /// Returns true if TemplateFormSectionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateFormSectionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateFormSectionModel input)
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
                    this.TemplateFormId == input.TemplateFormId ||
                    (this.TemplateFormId != null &&
                    this.TemplateFormId.Equals(input.TemplateFormId))
                ) && 
                (
                    this.InstructionsMarkdown == input.InstructionsMarkdown ||
                    (this.InstructionsMarkdown != null &&
                    this.InstructionsMarkdown.Equals(input.InstructionsMarkdown))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.TemplateFormFields == input.TemplateFormFields ||
                    this.TemplateFormFields != null &&
                    this.TemplateFormFields.SequenceEqual(input.TemplateFormFields)
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
                if (this.TemplateFormId != null)
                    hashCode = hashCode * 59 + this.TemplateFormId.GetHashCode();
                if (this.InstructionsMarkdown != null)
                    hashCode = hashCode * 59 + this.InstructionsMarkdown.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.TemplateFormFields != null)
                    hashCode = hashCode * 59 + this.TemplateFormFields.GetHashCode();
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
