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
    /// FinalizeTemplateFormRequest
    /// </summary>
    [DataContract]
        public partial class FinalizeTemplateFormRequest :  IEquatable<FinalizeTemplateFormRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinalizeTemplateFormRequest" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="appliedApplicationTemplateFormId">appliedApplicationTemplateFormId.</param>
        /// <param name="data">data.</param>
        /// <param name="apiKey">apiKey.</param>
        public FinalizeTemplateFormRequest(string applicationId = default(string), string appliedApplicationTemplateFormId = default(string), UpdateAppliedApplicationTemplateFormRequest data = default(UpdateAppliedApplicationTemplateFormRequest), string apiKey = default(string))
        {
            this.ApplicationId = applicationId;
            this.AppliedApplicationTemplateFormId = appliedApplicationTemplateFormId;
            this.Data = data;
            this.ApiKey = apiKey;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets AppliedApplicationTemplateFormId
        /// </summary>
        [DataMember(Name="appliedApplicationTemplateFormId", EmitDefaultValue=false)]
        public string AppliedApplicationTemplateFormId { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public UpdateAppliedApplicationTemplateFormRequest Data { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinalizeTemplateFormRequest {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  AppliedApplicationTemplateFormId: ").Append(AppliedApplicationTemplateFormId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
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
            return this.Equals(input as FinalizeTemplateFormRequest);
        }

        /// <summary>
        /// Returns true if FinalizeTemplateFormRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FinalizeTemplateFormRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinalizeTemplateFormRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.AppliedApplicationTemplateFormId == input.AppliedApplicationTemplateFormId ||
                    (this.AppliedApplicationTemplateFormId != null &&
                    this.AppliedApplicationTemplateFormId.Equals(input.AppliedApplicationTemplateFormId))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.AppliedApplicationTemplateFormId != null)
                    hashCode = hashCode * 59 + this.AppliedApplicationTemplateFormId.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                return hashCode;
            }
        }

    }
}
