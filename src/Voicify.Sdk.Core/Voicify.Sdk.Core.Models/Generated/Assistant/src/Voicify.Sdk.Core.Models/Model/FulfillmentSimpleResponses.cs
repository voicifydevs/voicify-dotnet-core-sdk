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
    /// FulfillmentSimpleResponses
    /// </summary>
    [DataContract]
    public partial class FulfillmentSimpleResponses :  IEquatable<FulfillmentSimpleResponses>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentSimpleResponses" /> class.
        /// </summary>
        /// <param name="simpleResponses">simpleResponses.</param>
        public FulfillmentSimpleResponses(List<SimpleResponseItem> simpleResponses = default(List<SimpleResponseItem>))
        {
            this.SimpleResponses = simpleResponses;
        }
        
        /// <summary>
        /// Gets or Sets SimpleResponses
        /// </summary>
        [DataMember(Name="simpleResponses", EmitDefaultValue=false)]
        public List<SimpleResponseItem> SimpleResponses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentSimpleResponses {\n");
            sb.Append("  SimpleResponses: ").Append(SimpleResponses).Append("\n");
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
            return this.Equals(input as FulfillmentSimpleResponses);
        }

        /// <summary>
        /// Returns true if FulfillmentSimpleResponses instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentSimpleResponses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentSimpleResponses input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SimpleResponses == input.SimpleResponses ||
                    this.SimpleResponses != null &&
                    this.SimpleResponses.SequenceEqual(input.SimpleResponses)
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
                if (this.SimpleResponses != null)
                    hashCode = hashCode * 59 + this.SimpleResponses.GetHashCode();
                return hashCode;
            }
        }

    }

}
