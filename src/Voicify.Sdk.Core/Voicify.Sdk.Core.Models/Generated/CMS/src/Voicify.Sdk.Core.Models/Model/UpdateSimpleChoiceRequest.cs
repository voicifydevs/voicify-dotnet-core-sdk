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
    /// UpdateSimpleChoiceRequest
    /// </summary>
    [DataContract]
    public partial class UpdateSimpleChoiceRequest :  IEquatable<UpdateSimpleChoiceRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines ChoiceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChoiceTypeEnum
        {
            
            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 1,
            
            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 2,
            
            /// <summary>
            /// Enum Maybe for value: Maybe
            /// </summary>
            [EnumMember(Value = "Maybe")]
            Maybe = 3
        }

        /// <summary>
        /// Gets or Sets ChoiceType
        /// </summary>
        [DataMember(Name="choiceType", EmitDefaultValue=false)]
        public ChoiceTypeEnum? ChoiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSimpleChoiceRequest" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="choiceType">choiceType.</param>
        public UpdateSimpleChoiceRequest(string title = default(string), ChoiceTypeEnum? choiceType = default(ChoiceTypeEnum?))
        {
            this.Title = title;
            this.ChoiceType = choiceType;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSimpleChoiceRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ChoiceType: ").Append(ChoiceType).Append("\n");
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
            return this.Equals(input as UpdateSimpleChoiceRequest);
        }

        /// <summary>
        /// Returns true if UpdateSimpleChoiceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSimpleChoiceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSimpleChoiceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ChoiceType == input.ChoiceType ||
                    (this.ChoiceType != null &&
                    this.ChoiceType.Equals(input.ChoiceType))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ChoiceType != null)
                    hashCode = hashCode * 59 + this.ChoiceType.GetHashCode();
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
