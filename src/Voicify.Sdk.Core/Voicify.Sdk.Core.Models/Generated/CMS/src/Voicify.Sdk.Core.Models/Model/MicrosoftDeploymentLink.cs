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
    /// MicrosoftDeploymentLink
    /// </summary>
    [DataContract]
    public partial class MicrosoftDeploymentLink :  IEquatable<MicrosoftDeploymentLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MicrosoftDeploymentLink" /> class.
        /// </summary>
        /// <param name="botServiceName">botServiceName.</param>
        /// <param name="microsoftAppId">microsoftAppId.</param>
        /// <param name="microsoftAppPassword">microsoftAppPassword.</param>
        /// <param name="luisRegion">luisRegion.</param>
        /// <param name="luisAuthoringKey">luisAuthoringKey.</param>
        /// <param name="luisAppId">luisAppId.</param>
        public MicrosoftDeploymentLink(string botServiceName = default(string), string microsoftAppId = default(string), string microsoftAppPassword = default(string), string luisRegion = default(string), string luisAuthoringKey = default(string), string luisAppId = default(string))
        {
            this.BotServiceName = botServiceName;
            this.MicrosoftAppId = microsoftAppId;
            this.MicrosoftAppPassword = microsoftAppPassword;
            this.LuisRegion = luisRegion;
            this.LuisAuthoringKey = luisAuthoringKey;
            this.LuisAppId = luisAppId;
        }
        
        /// <summary>
        /// Gets or Sets BotServiceName
        /// </summary>
        [DataMember(Name="botServiceName", EmitDefaultValue=false)]
        public string BotServiceName { get; set; }

        /// <summary>
        /// Gets or Sets MicrosoftAppId
        /// </summary>
        [DataMember(Name="microsoftAppId", EmitDefaultValue=false)]
        public string MicrosoftAppId { get; set; }

        /// <summary>
        /// Gets or Sets MicrosoftAppPassword
        /// </summary>
        [DataMember(Name="microsoftAppPassword", EmitDefaultValue=false)]
        public string MicrosoftAppPassword { get; set; }

        /// <summary>
        /// Gets or Sets LuisRegion
        /// </summary>
        [DataMember(Name="luisRegion", EmitDefaultValue=false)]
        public string LuisRegion { get; set; }

        /// <summary>
        /// Gets or Sets LuisAuthoringKey
        /// </summary>
        [DataMember(Name="luisAuthoringKey", EmitDefaultValue=false)]
        public string LuisAuthoringKey { get; set; }

        /// <summary>
        /// Gets or Sets LuisAppId
        /// </summary>
        [DataMember(Name="luisAppId", EmitDefaultValue=false)]
        public string LuisAppId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MicrosoftDeploymentLink {\n");
            sb.Append("  BotServiceName: ").Append(BotServiceName).Append("\n");
            sb.Append("  MicrosoftAppId: ").Append(MicrosoftAppId).Append("\n");
            sb.Append("  MicrosoftAppPassword: ").Append(MicrosoftAppPassword).Append("\n");
            sb.Append("  LuisRegion: ").Append(LuisRegion).Append("\n");
            sb.Append("  LuisAuthoringKey: ").Append(LuisAuthoringKey).Append("\n");
            sb.Append("  LuisAppId: ").Append(LuisAppId).Append("\n");
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
            return this.Equals(input as MicrosoftDeploymentLink);
        }

        /// <summary>
        /// Returns true if MicrosoftDeploymentLink instances are equal
        /// </summary>
        /// <param name="input">Instance of MicrosoftDeploymentLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MicrosoftDeploymentLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BotServiceName == input.BotServiceName ||
                    (this.BotServiceName != null &&
                    this.BotServiceName.Equals(input.BotServiceName))
                ) && 
                (
                    this.MicrosoftAppId == input.MicrosoftAppId ||
                    (this.MicrosoftAppId != null &&
                    this.MicrosoftAppId.Equals(input.MicrosoftAppId))
                ) && 
                (
                    this.MicrosoftAppPassword == input.MicrosoftAppPassword ||
                    (this.MicrosoftAppPassword != null &&
                    this.MicrosoftAppPassword.Equals(input.MicrosoftAppPassword))
                ) && 
                (
                    this.LuisRegion == input.LuisRegion ||
                    (this.LuisRegion != null &&
                    this.LuisRegion.Equals(input.LuisRegion))
                ) && 
                (
                    this.LuisAuthoringKey == input.LuisAuthoringKey ||
                    (this.LuisAuthoringKey != null &&
                    this.LuisAuthoringKey.Equals(input.LuisAuthoringKey))
                ) && 
                (
                    this.LuisAppId == input.LuisAppId ||
                    (this.LuisAppId != null &&
                    this.LuisAppId.Equals(input.LuisAppId))
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
                if (this.BotServiceName != null)
                    hashCode = hashCode * 59 + this.BotServiceName.GetHashCode();
                if (this.MicrosoftAppId != null)
                    hashCode = hashCode * 59 + this.MicrosoftAppId.GetHashCode();
                if (this.MicrosoftAppPassword != null)
                    hashCode = hashCode * 59 + this.MicrosoftAppPassword.GetHashCode();
                if (this.LuisRegion != null)
                    hashCode = hashCode * 59 + this.LuisRegion.GetHashCode();
                if (this.LuisAuthoringKey != null)
                    hashCode = hashCode * 59 + this.LuisAuthoringKey.GetHashCode();
                if (this.LuisAppId != null)
                    hashCode = hashCode * 59 + this.LuisAppId.GetHashCode();
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