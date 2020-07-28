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
    /// BixbyNumberRequest
    /// </summary>
    [DataContract]
    public partial class BixbyNumberRequest : Dictionary<String, Object>,  IEquatable<BixbyNumberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BixbyNumberRequest" /> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="vivContext">vivContext.</param>
        public BixbyNumberRequest(double? number = default(double?), VivContext vivContext = default(VivContext)) : base()
        {
            this.Number = number;
            this.VivContext = vivContext;
        }
        
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public double? Number { get; set; }

        /// <summary>
        /// Gets or Sets VivContext
        /// </summary>
        [DataMember(Name="$vivContext", EmitDefaultValue=false)]
        public VivContext VivContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BixbyNumberRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  VivContext: ").Append(VivContext).Append("\n");
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
            return this.Equals(input as BixbyNumberRequest);
        }

        /// <summary>
        /// Returns true if BixbyNumberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BixbyNumberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BixbyNumberRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && base.Equals(input) && 
                (
                    this.VivContext == input.VivContext ||
                    (this.VivContext != null &&
                    this.VivContext.Equals(input.VivContext))
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
                int hashCode = base.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.VivContext != null)
                    hashCode = hashCode * 59 + this.VivContext.GetHashCode();
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
