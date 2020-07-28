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
    /// CompleteTemplateFormModel
    /// </summary>
    [DataContract]
    public partial class CompleteTemplateFormModel :  IEquatable<CompleteTemplateFormModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteTemplateFormModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompleteTemplateFormModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteTemplateFormModel" /> class.
        /// </summary>
        /// <param name="templateConfigurationId">templateConfigurationId (required).</param>
        /// <param name="templateFormFieldValues">templateFormFieldValues.</param>
        public CompleteTemplateFormModel(string templateConfigurationId = default(string), List<TemplateFormFieldValueModel> templateFormFieldValues = default(List<TemplateFormFieldValueModel>))
        {
            // to ensure "templateConfigurationId" is required (not null)
            if (templateConfigurationId == null)
            {
                throw new InvalidDataException("templateConfigurationId is a required property for CompleteTemplateFormModel and cannot be null");
            }
            else
            {
                this.TemplateConfigurationId = templateConfigurationId;
            }
            this.TemplateFormFieldValues = templateFormFieldValues;
        }
        
        /// <summary>
        /// Gets or Sets TemplateConfigurationId
        /// </summary>
        [DataMember(Name="templateConfigurationId", EmitDefaultValue=false)]
        public string TemplateConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormFieldValues
        /// </summary>
        [DataMember(Name="templateFormFieldValues", EmitDefaultValue=false)]
        public List<TemplateFormFieldValueModel> TemplateFormFieldValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteTemplateFormModel {\n");
            sb.Append("  TemplateConfigurationId: ").Append(TemplateConfigurationId).Append("\n");
            sb.Append("  TemplateFormFieldValues: ").Append(TemplateFormFieldValues).Append("\n");
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
            return this.Equals(input as CompleteTemplateFormModel);
        }

        /// <summary>
        /// Returns true if CompleteTemplateFormModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CompleteTemplateFormModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompleteTemplateFormModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateConfigurationId == input.TemplateConfigurationId ||
                    (this.TemplateConfigurationId != null &&
                    this.TemplateConfigurationId.Equals(input.TemplateConfigurationId))
                ) && 
                (
                    this.TemplateFormFieldValues == input.TemplateFormFieldValues ||
                    this.TemplateFormFieldValues != null &&
                    this.TemplateFormFieldValues.SequenceEqual(input.TemplateFormFieldValues)
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
                if (this.TemplateConfigurationId != null)
                    hashCode = hashCode * 59 + this.TemplateConfigurationId.GetHashCode();
                if (this.TemplateFormFieldValues != null)
                    hashCode = hashCode * 59 + this.TemplateFormFieldValues.GetHashCode();
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