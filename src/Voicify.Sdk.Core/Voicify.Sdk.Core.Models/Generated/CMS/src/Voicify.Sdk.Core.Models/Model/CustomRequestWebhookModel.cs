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
    /// CustomRequestWebhookModel
    /// </summary>
    [DataContract]
    public partial class CustomRequestWebhookModel :  IEquatable<CustomRequestWebhookModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRequestWebhookModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="customRequestId">customRequestId.</param>
        /// <param name="webhook">webhook.</param>
        /// <param name="parameterValues">parameterValues.</param>
        public CustomRequestWebhookModel(string id = default(string), string customRequestId = default(string), WebhookModel webhook = default(WebhookModel), List<WebhookParameterValueModel> parameterValues = default(List<WebhookParameterValueModel>))
        {
            this.Id = id;
            this.CustomRequestId = customRequestId;
            this.Webhook = webhook;
            this.ParameterValues = parameterValues;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CustomRequestId
        /// </summary>
        [DataMember(Name="customRequestId", EmitDefaultValue=false)]
        public string CustomRequestId { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name="webhook", EmitDefaultValue=false)]
        public WebhookModel Webhook { get; set; }

        /// <summary>
        /// Gets or Sets ParameterValues
        /// </summary>
        [DataMember(Name="parameterValues", EmitDefaultValue=false)]
        public List<WebhookParameterValueModel> ParameterValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomRequestWebhookModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomRequestId: ").Append(CustomRequestId).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  ParameterValues: ").Append(ParameterValues).Append("\n");
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
            return this.Equals(input as CustomRequestWebhookModel);
        }

        /// <summary>
        /// Returns true if CustomRequestWebhookModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomRequestWebhookModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomRequestWebhookModel input)
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
                    this.CustomRequestId == input.CustomRequestId ||
                    (this.CustomRequestId != null &&
                    this.CustomRequestId.Equals(input.CustomRequestId))
                ) && 
                (
                    this.Webhook == input.Webhook ||
                    (this.Webhook != null &&
                    this.Webhook.Equals(input.Webhook))
                ) && 
                (
                    this.ParameterValues == input.ParameterValues ||
                    this.ParameterValues != null &&
                    this.ParameterValues.SequenceEqual(input.ParameterValues)
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
                if (this.CustomRequestId != null)
                    hashCode = hashCode * 59 + this.CustomRequestId.GetHashCode();
                if (this.Webhook != null)
                    hashCode = hashCode * 59 + this.Webhook.GetHashCode();
                if (this.ParameterValues != null)
                    hashCode = hashCode * 59 + this.ParameterValues.GetHashCode();
                return hashCode;
            }
        }

    }

}
