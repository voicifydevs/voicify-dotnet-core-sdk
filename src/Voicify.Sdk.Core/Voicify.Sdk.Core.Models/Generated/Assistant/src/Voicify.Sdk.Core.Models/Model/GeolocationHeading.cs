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
    /// GeolocationHeading
    /// </summary>
    [DataContract]
    public partial class GeolocationHeading :  IEquatable<GeolocationHeading>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationHeading" /> class.
        /// </summary>
        /// <param name="directionInDegrees">directionInDegrees.</param>
        /// <param name="accuracyInDegrees">accuracyInDegrees.</param>
        public GeolocationHeading(double? directionInDegrees = default(double?), double? accuracyInDegrees = default(double?))
        {
            this.DirectionInDegrees = directionInDegrees;
            this.AccuracyInDegrees = accuracyInDegrees;
        }
        
        /// <summary>
        /// Gets or Sets DirectionInDegrees
        /// </summary>
        [DataMember(Name="directionInDegrees", EmitDefaultValue=false)]
        public double? DirectionInDegrees { get; set; }

        /// <summary>
        /// Gets or Sets AccuracyInDegrees
        /// </summary>
        [DataMember(Name="accuracyInDegrees", EmitDefaultValue=false)]
        public double? AccuracyInDegrees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeolocationHeading {\n");
            sb.Append("  DirectionInDegrees: ").Append(DirectionInDegrees).Append("\n");
            sb.Append("  AccuracyInDegrees: ").Append(AccuracyInDegrees).Append("\n");
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
            return this.Equals(input as GeolocationHeading);
        }

        /// <summary>
        /// Returns true if GeolocationHeading instances are equal
        /// </summary>
        /// <param name="input">Instance of GeolocationHeading to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeolocationHeading input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirectionInDegrees == input.DirectionInDegrees ||
                    (this.DirectionInDegrees != null &&
                    this.DirectionInDegrees.Equals(input.DirectionInDegrees))
                ) && 
                (
                    this.AccuracyInDegrees == input.AccuracyInDegrees ||
                    (this.AccuracyInDegrees != null &&
                    this.AccuracyInDegrees.Equals(input.AccuracyInDegrees))
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
                if (this.DirectionInDegrees != null)
                    hashCode = hashCode * 59 + this.DirectionInDegrees.GetHashCode();
                if (this.AccuracyInDegrees != null)
                    hashCode = hashCode * 59 + this.AccuracyInDegrees.GetHashCode();
                return hashCode;
            }
        }

    }

}
