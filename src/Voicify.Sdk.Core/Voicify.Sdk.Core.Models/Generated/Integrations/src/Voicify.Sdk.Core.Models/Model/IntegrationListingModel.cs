/* 
 * Voicify Integrations API
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
    /// IntegrationListingModel
    /// </summary>
    [DataContract]
    public partial class IntegrationListingModel :  IEquatable<IntegrationListingModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationListingModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="provider">provider.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="setupUrl">setupUrl.</param>
        /// <param name="configUrl">configUrl.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="organizationId">organizationId.</param>
        public IntegrationListingModel(string id = default(string), string provider = default(string), string name = default(string), string description = default(string), string setupUrl = default(string), string configUrl = default(string), string iconUrl = default(string), string organizationId = default(string))
        {
            this.Id = id;
            this.Provider = provider;
            this.Name = name;
            this.Description = description;
            this.SetupUrl = setupUrl;
            this.ConfigUrl = configUrl;
            this.IconUrl = iconUrl;
            this.OrganizationId = organizationId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SetupUrl
        /// </summary>
        [DataMember(Name="setupUrl", EmitDefaultValue=false)]
        public string SetupUrl { get; set; }

        /// <summary>
        /// Gets or Sets ConfigUrl
        /// </summary>
        [DataMember(Name="configUrl", EmitDefaultValue=false)]
        public string ConfigUrl { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationListingModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SetupUrl: ").Append(SetupUrl).Append("\n");
            sb.Append("  ConfigUrl: ").Append(ConfigUrl).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
            return this.Equals(input as IntegrationListingModel);
        }

        /// <summary>
        /// Returns true if IntegrationListingModel instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationListingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationListingModel input)
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
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SetupUrl == input.SetupUrl ||
                    (this.SetupUrl != null &&
                    this.SetupUrl.Equals(input.SetupUrl))
                ) && 
                (
                    this.ConfigUrl == input.ConfigUrl ||
                    (this.ConfigUrl != null &&
                    this.ConfigUrl.Equals(input.ConfigUrl))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
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
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SetupUrl != null)
                    hashCode = hashCode * 59 + this.SetupUrl.GetHashCode();
                if (this.ConfigUrl != null)
                    hashCode = hashCode * 59 + this.ConfigUrl.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
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