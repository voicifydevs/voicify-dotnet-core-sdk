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
    /// FinishTemplateFormSectionRequest
    /// </summary>
    [DataContract]
        public partial class FinishTemplateFormSectionRequest :  IEquatable<FinishTemplateFormSectionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinishTemplateFormSectionRequest" /> class.
        /// </summary>
        /// <param name="fieldValues">fieldValues.</param>
        public FinishTemplateFormSectionRequest(List<TemplateFormFieldValueModel> fieldValues = default(List<TemplateFormFieldValueModel>))
        {
            this.FieldValues = fieldValues;
        }
        
        /// <summary>
        /// Gets or Sets FieldValues
        /// </summary>
        [DataMember(Name="fieldValues", EmitDefaultValue=false)]
        public List<TemplateFormFieldValueModel> FieldValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinishTemplateFormSectionRequest {\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
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
            return this.Equals(input as FinishTemplateFormSectionRequest);
        }

        /// <summary>
        /// Returns true if FinishTemplateFormSectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FinishTemplateFormSectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinishTemplateFormSectionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldValues == input.FieldValues ||
                    this.FieldValues != null &&
                    input.FieldValues != null &&
                    this.FieldValues.SequenceEqual(input.FieldValues)
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
                if (this.FieldValues != null)
                    hashCode = hashCode * 59 + this.FieldValues.GetHashCode();
                return hashCode;
            }
        }

    }
}
