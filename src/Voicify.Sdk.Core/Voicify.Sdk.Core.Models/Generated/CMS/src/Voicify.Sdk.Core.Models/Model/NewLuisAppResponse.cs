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
    /// NewLuisAppResponse
    /// </summary>
    [DataContract]
        public partial class NewLuisAppResponse :  IEquatable<NewLuisAppResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewLuisAppResponse" /> class.
        /// </summary>
        /// <param name="luisAppId">luisAppId.</param>
        /// <param name="name">name.</param>
        public NewLuisAppResponse(string luisAppId = default(string), string name = default(string))
        {
            this.LuisAppId = luisAppId;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets LuisAppId
        /// </summary>
        [DataMember(Name="luisAppId", EmitDefaultValue=false)]
        public string LuisAppId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewLuisAppResponse {\n");
            sb.Append("  LuisAppId: ").Append(LuisAppId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as NewLuisAppResponse);
        }

        /// <summary>
        /// Returns true if NewLuisAppResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NewLuisAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewLuisAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LuisAppId == input.LuisAppId ||
                    (this.LuisAppId != null &&
                    this.LuisAppId.Equals(input.LuisAppId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.LuisAppId != null)
                    hashCode = hashCode * 59 + this.LuisAppId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }
}
