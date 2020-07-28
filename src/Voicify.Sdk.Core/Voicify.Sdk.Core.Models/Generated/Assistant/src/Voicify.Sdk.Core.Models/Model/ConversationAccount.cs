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
    /// ConversationAccount
    /// </summary>
    [DataContract]
    public partial class ConversationAccount : Dictionary<String, Object>,  IEquatable<ConversationAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAccount" /> class.
        /// </summary>
        /// <param name="isGroup">isGroup.</param>
        /// <param name="conversationType">conversationType.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="aadObjectId">aadObjectId.</param>
        /// <param name="role">role.</param>
        /// <param name="tenantId">tenantId.</param>
        public ConversationAccount(bool? isGroup = default(bool?), string conversationType = default(string), string id = default(string), string name = default(string), string aadObjectId = default(string), string role = default(string), string tenantId = default(string)) : base()
        {
            this.IsGroup = isGroup;
            this.ConversationType = conversationType;
            this.Id = id;
            this.Name = name;
            this.AadObjectId = aadObjectId;
            this.Role = role;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Gets or Sets IsGroup
        /// </summary>
        [DataMember(Name="isGroup", EmitDefaultValue=false)]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Gets or Sets ConversationType
        /// </summary>
        [DataMember(Name="conversationType", EmitDefaultValue=false)]
        public string ConversationType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AadObjectId
        /// </summary>
        [DataMember(Name="aadObjectId", EmitDefaultValue=false)]
        public string AadObjectId { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAccount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  ConversationType: ").Append(ConversationType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AadObjectId: ").Append(AadObjectId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as ConversationAccount);
        }

        /// <summary>
        /// Returns true if ConversationAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAccount input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.IsGroup == input.IsGroup ||
                    (this.IsGroup != null &&
                    this.IsGroup.Equals(input.IsGroup))
                ) && base.Equals(input) && 
                (
                    this.ConversationType == input.ConversationType ||
                    (this.ConversationType != null &&
                    this.ConversationType.Equals(input.ConversationType))
                ) && base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.AadObjectId == input.AadObjectId ||
                    (this.AadObjectId != null &&
                    this.AadObjectId.Equals(input.AadObjectId))
                ) && base.Equals(input) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && base.Equals(input) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.IsGroup != null)
                    hashCode = hashCode * 59 + this.IsGroup.GetHashCode();
                if (this.ConversationType != null)
                    hashCode = hashCode * 59 + this.ConversationType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AadObjectId != null)
                    hashCode = hashCode * 59 + this.AadObjectId.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
