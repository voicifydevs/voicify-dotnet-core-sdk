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
    /// NewBulkApplicationMemberRequest
    /// </summary>
    [DataContract]
        public partial class NewBulkApplicationMemberRequest :  IEquatable<NewBulkApplicationMemberRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewBulkApplicationMemberRequest" /> class.
        /// </summary>
        /// <param name="organizationMemberIds">organizationMemberIds.</param>
        /// <param name="roleId">roleId.</param>
        public NewBulkApplicationMemberRequest(List<string> organizationMemberIds = default(List<string>), string roleId = default(string))
        {
            this.OrganizationMemberIds = organizationMemberIds;
            this.RoleId = roleId;
        }
        
        /// <summary>
        /// Gets or Sets OrganizationMemberIds
        /// </summary>
        [DataMember(Name="organizationMemberIds", EmitDefaultValue=false)]
        public List<string> OrganizationMemberIds { get; set; }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewBulkApplicationMemberRequest {\n");
            sb.Append("  OrganizationMemberIds: ").Append(OrganizationMemberIds).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
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
            return this.Equals(input as NewBulkApplicationMemberRequest);
        }

        /// <summary>
        /// Returns true if NewBulkApplicationMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NewBulkApplicationMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewBulkApplicationMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationMemberIds == input.OrganizationMemberIds ||
                    this.OrganizationMemberIds != null &&
                    input.OrganizationMemberIds != null &&
                    this.OrganizationMemberIds.SequenceEqual(input.OrganizationMemberIds)
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
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
                if (this.OrganizationMemberIds != null)
                    hashCode = hashCode * 59 + this.OrganizationMemberIds.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                return hashCode;
            }
        }

    }
}
