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
    /// Geolocation
    /// </summary>
    [DataContract]
    public partial class Geolocation :  IEquatable<Geolocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation" /> class.
        /// </summary>
        /// <param name="locationServices">locationServices.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="coordinate">coordinate.</param>
        /// <param name="altitude">altitude.</param>
        /// <param name="heading">heading.</param>
        /// <param name="speed">speed.</param>
        public Geolocation(LocationServices locationServices = default(LocationServices), DateTime? timestamp = default(DateTime?), GeolocationCoordinate coordinate = default(GeolocationCoordinate), GeolocationAltitude altitude = default(GeolocationAltitude), GeolocationHeading heading = default(GeolocationHeading), GeolocationSpeed speed = default(GeolocationSpeed))
        {
            this.LocationServices = locationServices;
            this.Timestamp = timestamp;
            this.Coordinate = coordinate;
            this.Altitude = altitude;
            this.Heading = heading;
            this.Speed = speed;
        }
        
        /// <summary>
        /// Gets or Sets LocationServices
        /// </summary>
        [DataMember(Name="locationServices", EmitDefaultValue=false)]
        public LocationServices LocationServices { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Coordinate
        /// </summary>
        [DataMember(Name="coordinate", EmitDefaultValue=false)]
        public GeolocationCoordinate Coordinate { get; set; }

        /// <summary>
        /// Gets or Sets Altitude
        /// </summary>
        [DataMember(Name="altitude", EmitDefaultValue=false)]
        public GeolocationAltitude Altitude { get; set; }

        /// <summary>
        /// Gets or Sets Heading
        /// </summary>
        [DataMember(Name="heading", EmitDefaultValue=false)]
        public GeolocationHeading Heading { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name="speed", EmitDefaultValue=false)]
        public GeolocationSpeed Speed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Geolocation {\n");
            sb.Append("  LocationServices: ").Append(LocationServices).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Coordinate: ").Append(Coordinate).Append("\n");
            sb.Append("  Altitude: ").Append(Altitude).Append("\n");
            sb.Append("  Heading: ").Append(Heading).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
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
            return this.Equals(input as Geolocation);
        }

        /// <summary>
        /// Returns true if Geolocation instances are equal
        /// </summary>
        /// <param name="input">Instance of Geolocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Geolocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationServices == input.LocationServices ||
                    (this.LocationServices != null &&
                    this.LocationServices.Equals(input.LocationServices))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Coordinate == input.Coordinate ||
                    (this.Coordinate != null &&
                    this.Coordinate.Equals(input.Coordinate))
                ) && 
                (
                    this.Altitude == input.Altitude ||
                    (this.Altitude != null &&
                    this.Altitude.Equals(input.Altitude))
                ) && 
                (
                    this.Heading == input.Heading ||
                    (this.Heading != null &&
                    this.Heading.Equals(input.Heading))
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
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
                if (this.LocationServices != null)
                    hashCode = hashCode * 59 + this.LocationServices.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Coordinate != null)
                    hashCode = hashCode * 59 + this.Coordinate.GetHashCode();
                if (this.Altitude != null)
                    hashCode = hashCode * 59 + this.Altitude.GetHashCode();
                if (this.Heading != null)
                    hashCode = hashCode * 59 + this.Heading.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
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
