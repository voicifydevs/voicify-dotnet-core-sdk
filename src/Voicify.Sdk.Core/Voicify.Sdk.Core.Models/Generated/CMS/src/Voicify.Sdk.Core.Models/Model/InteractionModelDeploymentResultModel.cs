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
    /// InteractionModelDeploymentResultModel
    /// </summary>
    [DataContract]
    public partial class InteractionModelDeploymentResultModel :  IEquatable<InteractionModelDeploymentResultModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionModelDeploymentResultModel" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="success">success.</param>
        /// <param name="platform">platform.</param>
        /// <param name="error">error.</param>
        /// <param name="validAsOfTicks">validAsOfTicks.</param>
        public InteractionModelDeploymentResultModel(string applicationId = default(string), bool? success = default(bool?), string platform = default(string), string error = default(string), long? validAsOfTicks = default(long?))
        {
            this.ApplicationId = applicationId;
            this.Success = success;
            this.Platform = platform;
            this.Error = error;
            this.ValidAsOfTicks = validAsOfTicks;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ValidAsOfTicks
        /// </summary>
        [DataMember(Name="validAsOfTicks", EmitDefaultValue=false)]
        public long? ValidAsOfTicks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractionModelDeploymentResultModel {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ValidAsOfTicks: ").Append(ValidAsOfTicks).Append("\n");
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
            return this.Equals(input as InteractionModelDeploymentResultModel);
        }

        /// <summary>
        /// Returns true if InteractionModelDeploymentResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InteractionModelDeploymentResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteractionModelDeploymentResultModel input)
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
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ValidAsOfTicks == input.ValidAsOfTicks ||
                    (this.ValidAsOfTicks != null &&
                    this.ValidAsOfTicks.Equals(input.ValidAsOfTicks))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ValidAsOfTicks != null)
                    hashCode = hashCode * 59 + this.ValidAsOfTicks.GetHashCode();
                return hashCode;
            }
        }

    }

}
