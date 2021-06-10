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
    /// LuisApplicationInformation
    /// </summary>
    [DataContract]
        public partial class LuisApplicationInformation :  IEquatable<LuisApplicationInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LuisApplicationInformation" /> class.
        /// </summary>
        /// <param name="endpoints">endpoints.</param>
        /// <param name="activeVersion">activeVersion.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        public LuisApplicationInformation(LuisAppEndpointsContainer endpoints = default(LuisAppEndpointsContainer), string activeVersion = default(string), string id = default(string), string name = default(string))
        {
            this.Endpoints = endpoints;
            this.ActiveVersion = activeVersion;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        [DataMember(Name="endpoints", EmitDefaultValue=false)]
        public LuisAppEndpointsContainer Endpoints { get; set; }

        /// <summary>
        /// Gets or Sets ActiveVersion
        /// </summary>
        [DataMember(Name="activeVersion", EmitDefaultValue=false)]
        public string ActiveVersion { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
            sb.Append("class LuisApplicationInformation {\n");
            sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  ActiveVersion: ").Append(ActiveVersion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as LuisApplicationInformation);
        }

        /// <summary>
        /// Returns true if LuisApplicationInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of LuisApplicationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LuisApplicationInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoints == input.Endpoints ||
                    (this.Endpoints != null &&
                    this.Endpoints.Equals(input.Endpoints))
                ) && 
                (
                    this.ActiveVersion == input.ActiveVersion ||
                    (this.ActiveVersion != null &&
                    this.ActiveVersion.Equals(input.ActiveVersion))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.ActiveVersion != null)
                    hashCode = hashCode * 59 + this.ActiveVersion.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }
}
