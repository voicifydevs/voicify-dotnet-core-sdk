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
    /// ApplicationsByGoogleAccount
    /// </summary>
    [DataContract]
    public partial class ApplicationsByGoogleAccount :  IEquatable<ApplicationsByGoogleAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsByGoogleAccount" /> class.
        /// </summary>
        /// <param name="applicationIds">applicationIds.</param>
        /// <param name="userName">userName.</param>
        /// <param name="id">id.</param>
        public ApplicationsByGoogleAccount(List<string> applicationIds = default(List<string>), string userName = default(string), string id = default(string))
        {
            this.ApplicationIds = applicationIds;
            this.UserName = userName;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; private set; }

        /// <summary>
        /// Gets or Sets ApplicationIds
        /// </summary>
        [DataMember(Name="applicationIds", EmitDefaultValue=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationsByGoogleAccount {\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ApplicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ApplicationsByGoogleAccount);
        }

        /// <summary>
        /// Returns true if ApplicationsByGoogleAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationsByGoogleAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationsByGoogleAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.ApplicationIds == input.ApplicationIds ||
                    this.ApplicationIds != null &&
                    this.ApplicationIds.SequenceEqual(input.ApplicationIds)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.ApplicationIds != null)
                    hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
