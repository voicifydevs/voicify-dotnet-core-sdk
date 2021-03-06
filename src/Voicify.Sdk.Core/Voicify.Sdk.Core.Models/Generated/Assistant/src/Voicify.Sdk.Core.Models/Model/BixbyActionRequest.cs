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
    /// BixbyActionRequest
    /// </summary>
    [DataContract]
    public partial class BixbyActionRequest : Dictionary<String, Object>,  IEquatable<BixbyActionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BixbyActionRequest" /> class.
        /// </summary>
        /// <param name="vivContext">vivContext.</param>
        public BixbyActionRequest(VivContext vivContext = default(VivContext)) : base()
        {
            this.VivContext = vivContext;
        }
        
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
            sb.Append("class BixbyActionRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as BixbyActionRequest);
        }

        /// <summary>
        /// Returns true if BixbyActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BixbyActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BixbyActionRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                if (this.VivContext != null)
                    hashCode = hashCode * 59 + this.VivContext.GetHashCode();
                return hashCode;
            }
        }

    }

}
