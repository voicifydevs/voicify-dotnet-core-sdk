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
    /// TopContentMissModel
    /// </summary>
    [DataContract]
    public partial class TopContentMissModel :  IEquatable<TopContentMissModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopContentMissModel" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="items">items.</param>
        public TopContentMissModel(string applicationId = default(string), List<ContentMissModel> items = default(List<ContentMissModel>))
        {
            this.ApplicationId = applicationId;
            this.Items = items;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ContentMissModel> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopContentMissModel {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as TopContentMissModel);
        }

        /// <summary>
        /// Returns true if TopContentMissModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TopContentMissModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopContentMissModel input)
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
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }

    }

}
