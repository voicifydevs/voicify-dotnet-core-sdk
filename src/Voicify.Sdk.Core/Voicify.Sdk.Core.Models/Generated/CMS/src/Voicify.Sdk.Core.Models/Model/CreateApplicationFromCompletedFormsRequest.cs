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
    /// CreateApplicationFromCompletedFormsRequest
    /// </summary>
    [DataContract]
    public partial class CreateApplicationFromCompletedFormsRequest :  IEquatable<CreateApplicationFromCompletedFormsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationFromCompletedFormsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateApplicationFromCompletedFormsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationFromCompletedFormsRequest" /> class.
        /// </summary>
        /// <param name="organizationId">organizationId (required).</param>
        /// <param name="applicationInfo">applicationInfo (required).</param>
        /// <param name="completeForms">completeForms (required).</param>
        public CreateApplicationFromCompletedFormsRequest(string organizationId = default(string), NewApplicationRequest applicationInfo = default(NewApplicationRequest), List<CompleteTemplateFormModel> completeForms = default(List<CompleteTemplateFormModel>))
        {
            // to ensure "organizationId" is required (not null)
            if (organizationId == null)
            {
                throw new InvalidDataException("organizationId is a required property for CreateApplicationFromCompletedFormsRequest and cannot be null");
            }
            else
            {
                this.OrganizationId = organizationId;
            }
            // to ensure "applicationInfo" is required (not null)
            if (applicationInfo == null)
            {
                throw new InvalidDataException("applicationInfo is a required property for CreateApplicationFromCompletedFormsRequest and cannot be null");
            }
            else
            {
                this.ApplicationInfo = applicationInfo;
            }
            // to ensure "completeForms" is required (not null)
            if (completeForms == null)
            {
                throw new InvalidDataException("completeForms is a required property for CreateApplicationFromCompletedFormsRequest and cannot be null");
            }
            else
            {
                this.CompleteForms = completeForms;
            }
        }
        
        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationInfo
        /// </summary>
        [DataMember(Name="applicationInfo", EmitDefaultValue=false)]
        public NewApplicationRequest ApplicationInfo { get; set; }

        /// <summary>
        /// Gets or Sets CompleteForms
        /// </summary>
        [DataMember(Name="completeForms", EmitDefaultValue=false)]
        public List<CompleteTemplateFormModel> CompleteForms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationFromCompletedFormsRequest {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  CompleteForms: ").Append(CompleteForms).Append("\n");
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
            return this.Equals(input as CreateApplicationFromCompletedFormsRequest);
        }

        /// <summary>
        /// Returns true if CreateApplicationFromCompletedFormsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateApplicationFromCompletedFormsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateApplicationFromCompletedFormsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.ApplicationInfo == input.ApplicationInfo ||
                    (this.ApplicationInfo != null &&
                    this.ApplicationInfo.Equals(input.ApplicationInfo))
                ) && 
                (
                    this.CompleteForms == input.CompleteForms ||
                    this.CompleteForms != null &&
                    this.CompleteForms.SequenceEqual(input.CompleteForms)
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
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.ApplicationInfo != null)
                    hashCode = hashCode * 59 + this.ApplicationInfo.GetHashCode();
                if (this.CompleteForms != null)
                    hashCode = hashCode * 59 + this.CompleteForms.GetHashCode();
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