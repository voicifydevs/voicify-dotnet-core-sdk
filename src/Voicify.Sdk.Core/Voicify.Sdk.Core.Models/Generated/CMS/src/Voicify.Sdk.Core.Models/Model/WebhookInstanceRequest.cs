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
    /// WebhookInstanceRequest
    /// </summary>
    [DataContract]
        public partial class WebhookInstanceRequest :  IEquatable<WebhookInstanceRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstanceRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="webhookId">webhookId (required).</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="priority">priority.</param>
        public WebhookInstanceRequest(string id = default(string), string webhookId = default(string), Dictionary<string, string> parameters = default(Dictionary<string, string>), int? priority = default(int?))
        {
            // to ensure "webhookId" is required (not null)
            if (webhookId == null)
            {
                throw new InvalidDataException("webhookId is a required property for WebhookInstanceRequest and cannot be null");
            }
            else
            {
                this.WebhookId = webhookId;
            }
            this.Id = id;
            this.Parameters = parameters;
            this.Priority = priority;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets WebhookId
        /// </summary>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public string WebhookId { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookInstanceRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as WebhookInstanceRequest);
        }

        /// <summary>
        /// Returns true if WebhookInstanceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookInstanceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookInstanceRequest input)
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
                    this.WebhookId == input.WebhookId ||
                    (this.WebhookId != null &&
                    this.WebhookId.Equals(input.WebhookId))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.WebhookId != null)
                    hashCode = hashCode * 59 + this.WebhookId.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }

    }
}
