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
    /// GeolocationCoordinate
    /// </summary>
    [DataContract]
    public partial class GeolocationCoordinate :  IEquatable<GeolocationCoordinate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationCoordinate" /> class.
        /// </summary>
        /// <param name="latitudeInDegrees">latitudeInDegrees.</param>
        /// <param name="longitudeInDegrees">longitudeInDegrees.</param>
        /// <param name="accuracyInMeters">accuracyInMeters.</param>
        public GeolocationCoordinate(double? latitudeInDegrees = default(double?), double? longitudeInDegrees = default(double?), double? accuracyInMeters = default(double?))
        {
            this.LatitudeInDegrees = latitudeInDegrees;
            this.LongitudeInDegrees = longitudeInDegrees;
            this.AccuracyInMeters = accuracyInMeters;
        }
        
        /// <summary>
        /// Gets or Sets LatitudeInDegrees
        /// </summary>
        [DataMember(Name="latitudeInDegrees", EmitDefaultValue=false)]
        public double? LatitudeInDegrees { get; set; }

        /// <summary>
        /// Gets or Sets LongitudeInDegrees
        /// </summary>
        [DataMember(Name="longitudeInDegrees", EmitDefaultValue=false)]
        public double? LongitudeInDegrees { get; set; }

        /// <summary>
        /// Gets or Sets AccuracyInMeters
        /// </summary>
        [DataMember(Name="accuracyInMeters", EmitDefaultValue=false)]
        public double? AccuracyInMeters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeolocationCoordinate {\n");
            sb.Append("  LatitudeInDegrees: ").Append(LatitudeInDegrees).Append("\n");
            sb.Append("  LongitudeInDegrees: ").Append(LongitudeInDegrees).Append("\n");
            sb.Append("  AccuracyInMeters: ").Append(AccuracyInMeters).Append("\n");
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
            return this.Equals(input as GeolocationCoordinate);
        }

        /// <summary>
        /// Returns true if GeolocationCoordinate instances are equal
        /// </summary>
        /// <param name="input">Instance of GeolocationCoordinate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeolocationCoordinate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LatitudeInDegrees == input.LatitudeInDegrees ||
                    (this.LatitudeInDegrees != null &&
                    this.LatitudeInDegrees.Equals(input.LatitudeInDegrees))
                ) && 
                (
                    this.LongitudeInDegrees == input.LongitudeInDegrees ||
                    (this.LongitudeInDegrees != null &&
                    this.LongitudeInDegrees.Equals(input.LongitudeInDegrees))
                ) && 
                (
                    this.AccuracyInMeters == input.AccuracyInMeters ||
                    (this.AccuracyInMeters != null &&
                    this.AccuracyInMeters.Equals(input.AccuracyInMeters))
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
                if (this.LatitudeInDegrees != null)
                    hashCode = hashCode * 59 + this.LatitudeInDegrees.GetHashCode();
                if (this.LongitudeInDegrees != null)
                    hashCode = hashCode * 59 + this.LongitudeInDegrees.GetHashCode();
                if (this.AccuracyInMeters != null)
                    hashCode = hashCode * 59 + this.AccuracyInMeters.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
