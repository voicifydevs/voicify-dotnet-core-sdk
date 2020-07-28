/* 
 * Voicify Assistant API
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
    /// SimpleResponseItem
    /// </summary>
    [DataContract]
    public partial class SimpleResponseItem :  IEquatable<SimpleResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleResponseItem" /> class.
        /// </summary>
        /// <param name="textToSpeech">textToSpeech.</param>
        /// <param name="ssml">ssml.</param>
        /// <param name="displayText">displayText.</param>
        public SimpleResponseItem(string textToSpeech = default(string), string ssml = default(string), string displayText = default(string))
        {
            this.TextToSpeech = textToSpeech;
            this.Ssml = ssml;
            this.DisplayText = displayText;
        }
        
        /// <summary>
        /// Gets or Sets TextToSpeech
        /// </summary>
        [DataMember(Name="textToSpeech", EmitDefaultValue=false)]
        public string TextToSpeech { get; set; }

        /// <summary>
        /// Gets or Sets Ssml
        /// </summary>
        [DataMember(Name="ssml", EmitDefaultValue=false)]
        public string Ssml { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=false)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleResponseItem {\n");
            sb.Append("  TextToSpeech: ").Append(TextToSpeech).Append("\n");
            sb.Append("  Ssml: ").Append(Ssml).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
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
            return this.Equals(input as SimpleResponseItem);
        }

        /// <summary>
        /// Returns true if SimpleResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleResponseItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextToSpeech == input.TextToSpeech ||
                    (this.TextToSpeech != null &&
                    this.TextToSpeech.Equals(input.TextToSpeech))
                ) && 
                (
                    this.Ssml == input.Ssml ||
                    (this.Ssml != null &&
                    this.Ssml.Equals(input.Ssml))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
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
                if (this.TextToSpeech != null)
                    hashCode = hashCode * 59 + this.TextToSpeech.GetHashCode();
                if (this.Ssml != null)
                    hashCode = hashCode * 59 + this.Ssml.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
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
