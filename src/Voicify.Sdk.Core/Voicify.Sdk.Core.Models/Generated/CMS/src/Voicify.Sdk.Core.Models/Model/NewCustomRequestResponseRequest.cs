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
    /// NewCustomRequestResponseRequest
    /// </summary>
    [DataContract]
    public partial class NewCustomRequestResponseRequest :  IEquatable<NewCustomRequestResponseRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomRequestResponseRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewCustomRequestResponseRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomRequestResponseRequest" /> class.
        /// </summary>
        /// <param name="content">content (required).</param>
        public NewCustomRequestResponseRequest(string content = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for NewCustomRequestResponseRequest and cannot be null");
            }
            else
            {
                this.Content = content;
            }
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCustomRequestResponseRequest {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as NewCustomRequestResponseRequest);
        }

        /// <summary>
        /// Returns true if NewCustomRequestResponseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NewCustomRequestResponseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewCustomRequestResponseRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
