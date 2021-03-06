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
    /// NewSimulatorPinnedMessageRequest
    /// </summary>
    [DataContract]
        public partial class NewSimulatorPinnedMessageRequest :  IEquatable<NewSimulatorPinnedMessageRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewSimulatorPinnedMessageRequest" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId (required).</param>
        /// <param name="message">message (required).</param>
        public NewSimulatorPinnedMessageRequest(string applicationId = default(string), string message = default(string))
        {
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for NewSimulatorPinnedMessageRequest and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for NewSimulatorPinnedMessageRequest and cannot be null");
            }
            else
            {
                this.Message = message;
            }
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewSimulatorPinnedMessageRequest {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as NewSimulatorPinnedMessageRequest);
        }

        /// <summary>
        /// Returns true if NewSimulatorPinnedMessageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NewSimulatorPinnedMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewSimulatorPinnedMessageRequest input)
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }
}
