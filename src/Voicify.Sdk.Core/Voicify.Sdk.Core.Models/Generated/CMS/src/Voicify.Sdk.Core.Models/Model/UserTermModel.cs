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
    /// UserTermModel
    /// </summary>
    [DataContract]
    public partial class UserTermModel :  IEquatable<UserTermModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTermModel" /> class.
        /// </summary>
        /// <param name="term">term.</param>
        /// <param name="id">id.</param>
        /// <param name="agreed">agreed.</param>
        public UserTermModel(TermModel term = default(TermModel), string id = default(string), bool? agreed = default(bool?))
        {
            this.Term = term;
            this.Id = id;
            this.Agreed = agreed;
        }
        
        /// <summary>
        /// Gets or Sets Term
        /// </summary>
        [DataMember(Name="term", EmitDefaultValue=false)]
        public TermModel Term { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Agreed
        /// </summary>
        [DataMember(Name="agreed", EmitDefaultValue=false)]
        public bool? Agreed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserTermModel {\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Agreed: ").Append(Agreed).Append("\n");
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
            return this.Equals(input as UserTermModel);
        }

        /// <summary>
        /// Returns true if UserTermModel instances are equal
        /// </summary>
        /// <param name="input">Instance of UserTermModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTermModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Term == input.Term ||
                    (this.Term != null &&
                    this.Term.Equals(input.Term))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Agreed == input.Agreed ||
                    (this.Agreed != null &&
                    this.Agreed.Equals(input.Agreed))
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
                if (this.Term != null)
                    hashCode = hashCode * 59 + this.Term.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Agreed != null)
                    hashCode = hashCode * 59 + this.Agreed.GetHashCode();
                return hashCode;
            }
        }

    }

}
