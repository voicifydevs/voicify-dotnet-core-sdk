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
    /// NewUserTermRequestModel
    /// </summary>
    [DataContract]
    public partial class NewUserTermRequestModel :  IEquatable<NewUserTermRequestModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserTermRequestModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewUserTermRequestModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserTermRequestModel" /> class.
        /// </summary>
        /// <param name="termId">termId (required).</param>
        /// <param name="agreed">agreed (required).</param>
        public NewUserTermRequestModel(string termId = default(string), bool? agreed = default(bool?))
        {
            // to ensure "termId" is required (not null)
            if (termId == null)
            {
                throw new InvalidDataException("termId is a required property for NewUserTermRequestModel and cannot be null");
            }
            else
            {
                this.TermId = termId;
            }
            // to ensure "agreed" is required (not null)
            if (agreed == null)
            {
                throw new InvalidDataException("agreed is a required property for NewUserTermRequestModel and cannot be null");
            }
            else
            {
                this.Agreed = agreed;
            }
        }
        
        /// <summary>
        /// Gets or Sets TermId
        /// </summary>
        [DataMember(Name="termId", EmitDefaultValue=false)]
        public string TermId { get; set; }

        /// <summary>
        /// Gets or Sets Agreed
        /// </summary>
        [DataMember(Name="agreed", EmitDefaultValue=false)]
        public bool? Agreed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUserTermRequestModel {\n");
            sb.Append("  TermId: ").Append(TermId).Append("\n");
            sb.Append("  Agreed: ").Append(Agreed).Append("\n");
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
            return this.Equals(input as NewUserTermRequestModel);
        }

        /// <summary>
        /// Returns true if NewUserTermRequestModel instances are equal
        /// </summary>
        /// <param name="input">Instance of NewUserTermRequestModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUserTermRequestModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TermId == input.TermId ||
                    (this.TermId != null &&
                    this.TermId.Equals(input.TermId))
                ) && 
                (
                    this.Agreed == input.Agreed ||
                    (this.Agreed != null &&
                    this.Agreed.Equals(input.Agreed))
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
                if (this.TermId != null)
                    hashCode = hashCode * 59 + this.TermId.GetHashCode();
                if (this.Agreed != null)
                    hashCode = hashCode * 59 + this.Agreed.GetHashCode();
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
