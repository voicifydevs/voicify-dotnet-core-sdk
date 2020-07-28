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
    /// ChangePasswordRequest
    /// </summary>
    [DataContract]
    public partial class ChangePasswordRequest :  IEquatable<ChangePasswordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangePasswordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        /// <param name="oldPassword">oldPassword (required).</param>
        /// <param name="newPassword">newPassword (required).</param>
        /// <param name="newPasswordConfirmation">newPasswordConfirmation (required).</param>
        public ChangePasswordRequest(string oldPassword = default(string), string newPassword = default(string), string newPasswordConfirmation = default(string))
        {
            // to ensure "oldPassword" is required (not null)
            if (oldPassword == null)
            {
                throw new InvalidDataException("oldPassword is a required property for ChangePasswordRequest and cannot be null");
            }
            else
            {
                this.OldPassword = oldPassword;
            }
            // to ensure "newPassword" is required (not null)
            if (newPassword == null)
            {
                throw new InvalidDataException("newPassword is a required property for ChangePasswordRequest and cannot be null");
            }
            else
            {
                this.NewPassword = newPassword;
            }
            // to ensure "newPasswordConfirmation" is required (not null)
            if (newPasswordConfirmation == null)
            {
                throw new InvalidDataException("newPasswordConfirmation is a required property for ChangePasswordRequest and cannot be null");
            }
            else
            {
                this.NewPasswordConfirmation = newPasswordConfirmation;
            }
        }
        
        /// <summary>
        /// Gets or Sets OldPassword
        /// </summary>
        [DataMember(Name="oldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or Sets NewPasswordConfirmation
        /// </summary>
        [DataMember(Name="newPasswordConfirmation", EmitDefaultValue=false)]
        public string NewPasswordConfirmation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordRequest {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  NewPasswordConfirmation: ").Append(NewPasswordConfirmation).Append("\n");
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
            return this.Equals(input as ChangePasswordRequest);
        }

        /// <summary>
        /// Returns true if ChangePasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangePasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePasswordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.NewPasswordConfirmation == input.NewPasswordConfirmation ||
                    (this.NewPasswordConfirmation != null &&
                    this.NewPasswordConfirmation.Equals(input.NewPasswordConfirmation))
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
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.NewPasswordConfirmation != null)
                    hashCode = hashCode * 59 + this.NewPasswordConfirmation.GetHashCode();
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
            // NewPassword (string) minLength
            if(this.NewPassword != null && this.NewPassword.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewPassword, length must be greater than 6.", new [] { "NewPassword" });
            }

            // NewPasswordConfirmation (string) minLength
            if(this.NewPasswordConfirmation != null && this.NewPasswordConfirmation.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewPasswordConfirmation, length must be greater than 6.", new [] { "NewPasswordConfirmation" });
            }

            yield break;
        }
    }

}