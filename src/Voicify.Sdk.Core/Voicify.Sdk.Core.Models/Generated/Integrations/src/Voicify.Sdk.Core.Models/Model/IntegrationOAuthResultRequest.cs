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
    /// IntegrationOAuthResultRequest
    /// </summary>
    [DataContract]
    public partial class IntegrationOAuthResultRequest :  IEquatable<IntegrationOAuthResultRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationOAuthResultRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntegrationOAuthResultRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationOAuthResultRequest" /> class.
        /// </summary>
        /// <param name="oAuthUrl">oAuthUrl.</param>
        /// <param name="code">code (required).</param>
        /// <param name="state">state.</param>
        public IntegrationOAuthResultRequest(string oAuthUrl = default(string), string code = default(string), string state = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for IntegrationOAuthResultRequest and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            this.OAuthUrl = oAuthUrl;
            this.State = state;
        }
        
        /// <summary>
        /// Gets or Sets OAuthUrl
        /// </summary>
        [DataMember(Name="oAuthUrl", EmitDefaultValue=false)]
        public string OAuthUrl { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationOAuthResultRequest {\n");
            sb.Append("  OAuthUrl: ").Append(OAuthUrl).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as IntegrationOAuthResultRequest);
        }

        /// <summary>
        /// Returns true if IntegrationOAuthResultRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationOAuthResultRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationOAuthResultRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OAuthUrl == input.OAuthUrl ||
                    (this.OAuthUrl != null &&
                    this.OAuthUrl.Equals(input.OAuthUrl))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.OAuthUrl != null)
                    hashCode = hashCode * 59 + this.OAuthUrl.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}
