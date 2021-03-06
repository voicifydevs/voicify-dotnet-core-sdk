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
    /// UpdateBulkMediaResponseContainerRequest
    /// </summary>
    [DataContract]
        public partial class UpdateBulkMediaResponseContainerRequest :  IEquatable<UpdateBulkMediaResponseContainerRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBulkMediaResponseContainerRequest" /> class.
        /// </summary>
        /// <param name="additionalMediaItemIds">additionalMediaItemIds (required).</param>
        /// <param name="responses">responses (required).</param>
        public UpdateBulkMediaResponseContainerRequest(List<string> additionalMediaItemIds = default(List<string>), List<UpdateMediaResponseRequest> responses = default(List<UpdateMediaResponseRequest>))
        {
            // to ensure "additionalMediaItemIds" is required (not null)
            if (additionalMediaItemIds == null)
            {
                throw new InvalidDataException("additionalMediaItemIds is a required property for UpdateBulkMediaResponseContainerRequest and cannot be null");
            }
            else
            {
                this.AdditionalMediaItemIds = additionalMediaItemIds;
            }
            // to ensure "responses" is required (not null)
            if (responses == null)
            {
                throw new InvalidDataException("responses is a required property for UpdateBulkMediaResponseContainerRequest and cannot be null");
            }
            else
            {
                this.Responses = responses;
            }
        }
        
        /// <summary>
        /// Gets or Sets AdditionalMediaItemIds
        /// </summary>
        [DataMember(Name="additionalMediaItemIds", EmitDefaultValue=false)]
        public List<string> AdditionalMediaItemIds { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<UpdateMediaResponseRequest> Responses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBulkMediaResponseContainerRequest {\n");
            sb.Append("  AdditionalMediaItemIds: ").Append(AdditionalMediaItemIds).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
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
            return this.Equals(input as UpdateBulkMediaResponseContainerRequest);
        }

        /// <summary>
        /// Returns true if UpdateBulkMediaResponseContainerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateBulkMediaResponseContainerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateBulkMediaResponseContainerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalMediaItemIds == input.AdditionalMediaItemIds ||
                    this.AdditionalMediaItemIds != null &&
                    input.AdditionalMediaItemIds != null &&
                    this.AdditionalMediaItemIds.SequenceEqual(input.AdditionalMediaItemIds)
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    input.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
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
                if (this.AdditionalMediaItemIds != null)
                    hashCode = hashCode * 59 + this.AdditionalMediaItemIds.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                return hashCode;
            }
        }

    }
}
