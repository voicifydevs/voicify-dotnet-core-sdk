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
    /// ApplicationMemberModel
    /// </summary>
    [DataContract]
        public partial class ApplicationMemberModel :  IEquatable<ApplicationMemberModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMemberModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="organizationMemberId">organizationMemberId.</param>
        /// <param name="isAdmin">isAdmin.</param>
        /// <param name="canEdit">canEdit.</param>
        /// <param name="organizationMember">organizationMember.</param>
        public ApplicationMemberModel(string id = default(string), string applicationId = default(string), string organizationMemberId = default(string), bool? isAdmin = default(bool?), bool? canEdit = default(bool?), OrganizationMemberModel organizationMember = default(OrganizationMemberModel))
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.OrganizationMemberId = organizationMemberId;
            this.IsAdmin = isAdmin;
            this.CanEdit = canEdit;
            this.OrganizationMember = organizationMember;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationMemberId
        /// </summary>
        [DataMember(Name="organizationMemberId", EmitDefaultValue=false)]
        public string OrganizationMemberId { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name="isAdmin", EmitDefaultValue=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets CanEdit
        /// </summary>
        [DataMember(Name="canEdit", EmitDefaultValue=false)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationMember
        /// </summary>
        [DataMember(Name="organizationMember", EmitDefaultValue=false)]
        public OrganizationMemberModel OrganizationMember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationMemberModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  OrganizationMemberId: ").Append(OrganizationMemberId).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  CanEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  OrganizationMember: ").Append(OrganizationMember).Append("\n");
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
            return this.Equals(input as ApplicationMemberModel);
        }

        /// <summary>
        /// Returns true if ApplicationMemberModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationMemberModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationMemberModel input)
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
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.OrganizationMemberId == input.OrganizationMemberId ||
                    (this.OrganizationMemberId != null &&
                    this.OrganizationMemberId.Equals(input.OrganizationMemberId))
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.CanEdit == input.CanEdit ||
                    (this.CanEdit != null &&
                    this.CanEdit.Equals(input.CanEdit))
                ) && 
                (
                    this.OrganizationMember == input.OrganizationMember ||
                    (this.OrganizationMember != null &&
                    this.OrganizationMember.Equals(input.OrganizationMember))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.OrganizationMemberId != null)
                    hashCode = hashCode * 59 + this.OrganizationMemberId.GetHashCode();
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.CanEdit != null)
                    hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.OrganizationMember != null)
                    hashCode = hashCode * 59 + this.OrganizationMember.GetHashCode();
                return hashCode;
            }
        }

    }
}
