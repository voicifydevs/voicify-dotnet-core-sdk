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
    /// AssistantUsageModel
    /// </summary>
    [DataContract]
    public partial class AssistantUsageModel :  IEquatable<AssistantUsageModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantUsageModel" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="count">count.</param>
        /// <param name="assistant">assistant.</param>
        public AssistantUsageModel(string key = default(string), long? count = default(long?), string assistant = default(string))
        {
            this.Key = key;
            this.Count = count;
            this.Assistant = assistant;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or Sets Assistant
        /// </summary>
        [DataMember(Name="assistant", EmitDefaultValue=false)]
        public string Assistant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistantUsageModel {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Assistant: ").Append(Assistant).Append("\n");
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
            return this.Equals(input as AssistantUsageModel);
        }

        /// <summary>
        /// Returns true if AssistantUsageModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AssistantUsageModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssistantUsageModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Assistant == input.Assistant ||
                    (this.Assistant != null &&
                    this.Assistant.Equals(input.Assistant))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Assistant != null)
                    hashCode = hashCode * 59 + this.Assistant.GetHashCode();
                return hashCode;
            }
        }

    }

}
