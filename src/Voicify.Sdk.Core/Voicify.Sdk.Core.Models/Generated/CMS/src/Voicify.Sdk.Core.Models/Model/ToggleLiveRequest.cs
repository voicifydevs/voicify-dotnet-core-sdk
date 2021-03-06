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
    /// ToggleLiveRequest
    /// </summary>
    [DataContract]
        public partial class ToggleLiveRequest :  IEquatable<ToggleLiveRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleLiveRequest" /> class.
        /// </summary>
        /// <param name="isLive">isLive (required).</param>
        public ToggleLiveRequest(bool? isLive = default(bool?))
        {
            // to ensure "isLive" is required (not null)
            if (isLive == null)
            {
                throw new InvalidDataException("isLive is a required property for ToggleLiveRequest and cannot be null");
            }
            else
            {
                this.IsLive = isLive;
            }
        }
        
        /// <summary>
        /// Gets or Sets IsLive
        /// </summary>
        [DataMember(Name="isLive", EmitDefaultValue=false)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToggleLiveRequest {\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
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
            return this.Equals(input as ToggleLiveRequest);
        }

        /// <summary>
        /// Returns true if ToggleLiveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ToggleLiveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToggleLiveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsLive == input.IsLive ||
                    (this.IsLive != null &&
                    this.IsLive.Equals(input.IsLive))
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
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                return hashCode;
            }
        }

    }
}
