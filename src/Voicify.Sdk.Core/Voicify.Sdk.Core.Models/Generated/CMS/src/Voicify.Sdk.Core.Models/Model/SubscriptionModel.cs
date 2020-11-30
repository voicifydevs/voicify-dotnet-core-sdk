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
    /// SubscriptionModel
    /// </summary>
    [DataContract]
    public partial class SubscriptionModel :  IEquatable<SubscriptionModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="subscriptionTypeId">subscriptionTypeId.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="isExpired">isExpired.</param>
        /// <param name="subscriptionType">subscriptionType.</param>
        public SubscriptionModel(string id = default(string), string organizationId = default(string), string subscriptionTypeId = default(string), DateTime? startDate = default(DateTime?), DateTime? expirationDate = default(DateTime?), bool? isExpired = default(bool?), SubscriptionTypeModel subscriptionType = default(SubscriptionTypeModel))
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.SubscriptionTypeId = subscriptionTypeId;
            this.StartDate = startDate;
            this.ExpirationDate = expirationDate;
            this.IsExpired = isExpired;
            this.SubscriptionType = subscriptionType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionTypeId
        /// </summary>
        [DataMember(Name="subscriptionTypeId", EmitDefaultValue=false)]
        public string SubscriptionTypeId { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets IsExpired
        /// </summary>
        [DataMember(Name="isExpired", EmitDefaultValue=false)]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionType
        /// </summary>
        [DataMember(Name="subscriptionType", EmitDefaultValue=false)]
        public SubscriptionTypeModel SubscriptionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  SubscriptionTypeId: ").Append(SubscriptionTypeId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
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
            return this.Equals(input as SubscriptionModel);
        }

        /// <summary>
        /// Returns true if SubscriptionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionModel input)
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
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.SubscriptionTypeId == input.SubscriptionTypeId ||
                    (this.SubscriptionTypeId != null &&
                    this.SubscriptionTypeId.Equals(input.SubscriptionTypeId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.IsExpired == input.IsExpired ||
                    (this.IsExpired != null &&
                    this.IsExpired.Equals(input.IsExpired))
                ) && 
                (
                    this.SubscriptionType == input.SubscriptionType ||
                    (this.SubscriptionType != null &&
                    this.SubscriptionType.Equals(input.SubscriptionType))
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
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.SubscriptionTypeId != null)
                    hashCode = hashCode * 59 + this.SubscriptionTypeId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.IsExpired != null)
                    hashCode = hashCode * 59 + this.IsExpired.GetHashCode();
                if (this.SubscriptionType != null)
                    hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                return hashCode;
            }
        }

    }

}
