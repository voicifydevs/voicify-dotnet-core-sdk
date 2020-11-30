/* 
 * Voicify Assistant API
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
    /// SemanticAction
    /// </summary>
    [DataContract]
    public partial class SemanticAction :  IEquatable<SemanticAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticAction" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entities">entities.</param>
        public SemanticAction(string id = default(string), Dictionary<string, Entity> entities = default(Dictionary<string, Entity>))
        {
            this.Id = id;
            this.Entities = entities;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public Dictionary<string, Entity> Entities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SemanticAction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(input as SemanticAction);
        }

        /// <summary>
        /// Returns true if SemanticAction instances are equal
        /// </summary>
        /// <param name="input">Instance of SemanticAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SemanticAction input)
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
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
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
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                return hashCode;
            }
        }

    }

}
