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
    /// UserProfile
    /// </summary>
    [DataContract]
    public partial class UserProfile :  IEquatable<UserProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="firstSeen">firstSeen.</param>
        /// <param name="userFlags">userFlags.</param>
        /// <param name="userAttributes">userAttributes.</param>
        public UserProfile(string id = default(string), string userId = default(string), string applicationId = default(string), DateTime? firstSeen = default(DateTime?), List<string> userFlags = default(List<string>), Dictionary<string, Object> userAttributes = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.UserId = userId;
            this.ApplicationId = applicationId;
            this.FirstSeen = firstSeen;
            this.UserFlags = userFlags;
            this.UserAttributes = userAttributes;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets FirstSeen
        /// </summary>
        [DataMember(Name="firstSeen", EmitDefaultValue=false)]
        public DateTime? FirstSeen { get; set; }

        /// <summary>
        /// Gets or Sets UserFlags
        /// </summary>
        [DataMember(Name="userFlags", EmitDefaultValue=false)]
        public List<string> UserFlags { get; set; }

        /// <summary>
        /// Gets or Sets UserAttributes
        /// </summary>
        [DataMember(Name="userAttributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> UserAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  FirstSeen: ").Append(FirstSeen).Append("\n");
            sb.Append("  UserFlags: ").Append(UserFlags).Append("\n");
            sb.Append("  UserAttributes: ").Append(UserAttributes).Append("\n");
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
            return this.Equals(input as UserProfile);
        }

        /// <summary>
        /// Returns true if UserProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.FirstSeen == input.FirstSeen ||
                    (this.FirstSeen != null &&
                    this.FirstSeen.Equals(input.FirstSeen))
                ) && 
                (
                    this.UserFlags == input.UserFlags ||
                    this.UserFlags != null &&
                    this.UserFlags.SequenceEqual(input.UserFlags)
                ) && 
                (
                    this.UserAttributes == input.UserAttributes ||
                    this.UserAttributes != null &&
                    this.UserAttributes.SequenceEqual(input.UserAttributes)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.FirstSeen != null)
                    hashCode = hashCode * 59 + this.FirstSeen.GetHashCode();
                if (this.UserFlags != null)
                    hashCode = hashCode * 59 + this.UserFlags.GetHashCode();
                if (this.UserAttributes != null)
                    hashCode = hashCode * 59 + this.UserAttributes.GetHashCode();
                return hashCode;
            }
        }

    }

}
