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
    /// TemplateFormFieldModel
    /// </summary>
    [DataContract]
        public partial class TemplateFormFieldModel :  IEquatable<TemplateFormFieldModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFormFieldModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="templateFormSectionId">templateFormSectionId.</param>
        /// <param name="label">label.</param>
        /// <param name="fieldType">fieldType (required).</param>
        /// <param name="placeholder">placeholder.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="tip">tip.</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="instructionsMarkdown">instructionsMarkdown.</param>
        /// <param name="title">title (required).</param>
        /// <param name="priority">priority.</param>
        /// <param name="associatedVariable">associatedVariable.</param>
        /// <param name="options">options.</param>
        public TemplateFormFieldModel(string id = default(string), string templateFormSectionId = default(string), string label = default(string), string fieldType = default(string), string placeholder = default(string), string defaultValue = default(string), string tip = default(string), bool? isRequired = default(bool?), string instructionsMarkdown = default(string), string title = default(string), int? priority = default(int?), string associatedVariable = default(string), List<TemplateFormFieldOptionModel> options = default(List<TemplateFormFieldOptionModel>))
        {
            // to ensure "fieldType" is required (not null)
            if (fieldType == null)
            {
                throw new InvalidDataException("fieldType is a required property for TemplateFormFieldModel and cannot be null");
            }
            else
            {
                this.FieldType = fieldType;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for TemplateFormFieldModel and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.Id = id;
            this.TemplateFormSectionId = templateFormSectionId;
            this.Label = label;
            this.Placeholder = placeholder;
            this.DefaultValue = defaultValue;
            this.Tip = tip;
            this.IsRequired = isRequired;
            this.InstructionsMarkdown = instructionsMarkdown;
            this.Priority = priority;
            this.AssociatedVariable = associatedVariable;
            this.Options = options;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormSectionId
        /// </summary>
        [DataMember(Name="templateFormSectionId", EmitDefaultValue=false)]
        public string TemplateFormSectionId { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// Gets or Sets Placeholder
        /// </summary>
        [DataMember(Name="placeholder", EmitDefaultValue=false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets Tip
        /// </summary>
        [DataMember(Name="tip", EmitDefaultValue=false)]
        public string Tip { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

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
        /// Gets or Sets AssociatedVariable
        /// </summary>
        [DataMember(Name="associatedVariable", EmitDefaultValue=false)]
        public string AssociatedVariable { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<TemplateFormFieldOptionModel> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateFormFieldModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateFormSectionId: ").Append(TemplateFormSectionId).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  InstructionsMarkdown: ").Append(InstructionsMarkdown).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  AssociatedVariable: ").Append(AssociatedVariable).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as TemplateFormFieldModel);
        }

        /// <summary>
        /// Returns true if TemplateFormFieldModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateFormFieldModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateFormFieldModel input)
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
                    this.TemplateFormSectionId == input.TemplateFormSectionId ||
                    (this.TemplateFormSectionId != null &&
                    this.TemplateFormSectionId.Equals(input.TemplateFormSectionId))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.Placeholder == input.Placeholder ||
                    (this.Placeholder != null &&
                    this.Placeholder.Equals(input.Placeholder))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Tip == input.Tip ||
                    (this.Tip != null &&
                    this.Tip.Equals(input.Tip))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
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
                    this.AssociatedVariable == input.AssociatedVariable ||
                    (this.AssociatedVariable != null &&
                    this.AssociatedVariable.Equals(input.AssociatedVariable))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.TemplateFormSectionId != null)
                    hashCode = hashCode * 59 + this.TemplateFormSectionId.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.Placeholder != null)
                    hashCode = hashCode * 59 + this.Placeholder.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Tip != null)
                    hashCode = hashCode * 59 + this.Tip.GetHashCode();
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.InstructionsMarkdown != null)
                    hashCode = hashCode * 59 + this.InstructionsMarkdown.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.AssociatedVariable != null)
                    hashCode = hashCode * 59 + this.AssociatedVariable.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }

    }
}
