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
    /// TemplateFormFieldValueModel
    /// </summary>
    [DataContract]
        public partial class TemplateFormFieldValueModel :  IEquatable<TemplateFormFieldValueModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFormFieldValueModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="templateFormFieldId">templateFormFieldId.</param>
        /// <param name="dynamicFormFieldId">dynamicFormFieldId.</param>
        /// <param name="dynamicFormFieldName">dynamicFormFieldName.</param>
        /// <param name="value">value.</param>
        public TemplateFormFieldValueModel(string id = default(string), string templateFormFieldId = default(string), string dynamicFormFieldId = default(string), string dynamicFormFieldName = default(string), string value = default(string))
        {
            this.Id = id;
            this.TemplateFormFieldId = templateFormFieldId;
            this.DynamicFormFieldId = dynamicFormFieldId;
            this.DynamicFormFieldName = dynamicFormFieldName;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormFieldId
        /// </summary>
        [DataMember(Name="templateFormFieldId", EmitDefaultValue=false)]
        public string TemplateFormFieldId { get; set; }

        /// <summary>
        /// Gets or Sets DynamicFormFieldId
        /// </summary>
        [DataMember(Name="dynamicFormFieldId", EmitDefaultValue=false)]
        public string DynamicFormFieldId { get; set; }

        /// <summary>
        /// Gets or Sets DynamicFormFieldName
        /// </summary>
        [DataMember(Name="dynamicFormFieldName", EmitDefaultValue=false)]
        public string DynamicFormFieldName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateFormFieldValueModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateFormFieldId: ").Append(TemplateFormFieldId).Append("\n");
            sb.Append("  DynamicFormFieldId: ").Append(DynamicFormFieldId).Append("\n");
            sb.Append("  DynamicFormFieldName: ").Append(DynamicFormFieldName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as TemplateFormFieldValueModel);
        }

        /// <summary>
        /// Returns true if TemplateFormFieldValueModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateFormFieldValueModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateFormFieldValueModel input)
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
                    this.TemplateFormFieldId == input.TemplateFormFieldId ||
                    (this.TemplateFormFieldId != null &&
                    this.TemplateFormFieldId.Equals(input.TemplateFormFieldId))
                ) && 
                (
                    this.DynamicFormFieldId == input.DynamicFormFieldId ||
                    (this.DynamicFormFieldId != null &&
                    this.DynamicFormFieldId.Equals(input.DynamicFormFieldId))
                ) && 
                (
                    this.DynamicFormFieldName == input.DynamicFormFieldName ||
                    (this.DynamicFormFieldName != null &&
                    this.DynamicFormFieldName.Equals(input.DynamicFormFieldName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.TemplateFormFieldId != null)
                    hashCode = hashCode * 59 + this.TemplateFormFieldId.GetHashCode();
                if (this.DynamicFormFieldId != null)
                    hashCode = hashCode * 59 + this.DynamicFormFieldId.GetHashCode();
                if (this.DynamicFormFieldName != null)
                    hashCode = hashCode * 59 + this.DynamicFormFieldName.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}
