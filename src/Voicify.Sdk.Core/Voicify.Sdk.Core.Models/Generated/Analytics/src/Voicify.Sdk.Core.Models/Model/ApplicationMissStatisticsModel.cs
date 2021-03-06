/* 
 * Voicify Analytics API
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
    /// ApplicationMissStatisticsModel
    /// </summary>
    [DataContract]
    public partial class ApplicationMissStatisticsModel :  IEquatable<ApplicationMissStatisticsModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMissStatisticsModel" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="featureMissCount">featureMissCount.</param>
        /// <param name="contentMissCount">contentMissCount.</param>
        public ApplicationMissStatisticsModel(string applicationId = default(string), long? featureMissCount = default(long?), long? contentMissCount = default(long?))
        {
            this.ApplicationId = applicationId;
            this.FeatureMissCount = featureMissCount;
            this.ContentMissCount = contentMissCount;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets FeatureMissCount
        /// </summary>
        [DataMember(Name="featureMissCount", EmitDefaultValue=false)]
        public long? FeatureMissCount { get; set; }

        /// <summary>
        /// Gets or Sets ContentMissCount
        /// </summary>
        [DataMember(Name="contentMissCount", EmitDefaultValue=false)]
        public long? ContentMissCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationMissStatisticsModel {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  FeatureMissCount: ").Append(FeatureMissCount).Append("\n");
            sb.Append("  ContentMissCount: ").Append(ContentMissCount).Append("\n");
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
            return this.Equals(input as ApplicationMissStatisticsModel);
        }

        /// <summary>
        /// Returns true if ApplicationMissStatisticsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationMissStatisticsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationMissStatisticsModel input)
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
                    this.FeatureMissCount == input.FeatureMissCount ||
                    (this.FeatureMissCount != null &&
                    this.FeatureMissCount.Equals(input.FeatureMissCount))
                ) && 
                (
                    this.ContentMissCount == input.ContentMissCount ||
                    (this.ContentMissCount != null &&
                    this.ContentMissCount.Equals(input.ContentMissCount))
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
                if (this.FeatureMissCount != null)
                    hashCode = hashCode * 59 + this.FeatureMissCount.GetHashCode();
                if (this.ContentMissCount != null)
                    hashCode = hashCode * 59 + this.ContentMissCount.GetHashCode();
                return hashCode;
            }
        }

    }

}
