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
    /// FulfillmentImage
    /// </summary>
    [DataContract]
    public partial class FulfillmentImage :  IEquatable<FulfillmentImage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentImage" /> class.
        /// </summary>
        /// <param name="imageUri">imageUri.</param>
        /// <param name="accessibilityText">accessibilityText.</param>
        public FulfillmentImage(string imageUri = default(string), string accessibilityText = default(string))
        {
            this.ImageUri = imageUri;
            this.AccessibilityText = accessibilityText;
        }
        
        /// <summary>
        /// Gets or Sets ImageUri
        /// </summary>
        [DataMember(Name="imageUri", EmitDefaultValue=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// Gets or Sets AccessibilityText
        /// </summary>
        [DataMember(Name="accessibilityText", EmitDefaultValue=false)]
        public string AccessibilityText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentImage {\n");
            sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
            sb.Append("  AccessibilityText: ").Append(AccessibilityText).Append("\n");
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
            return this.Equals(input as FulfillmentImage);
        }

        /// <summary>
        /// Returns true if FulfillmentImage instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageUri == input.ImageUri ||
                    (this.ImageUri != null &&
                    this.ImageUri.Equals(input.ImageUri))
                ) && 
                (
                    this.AccessibilityText == input.AccessibilityText ||
                    (this.AccessibilityText != null &&
                    this.AccessibilityText.Equals(input.AccessibilityText))
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
                if (this.ImageUri != null)
                    hashCode = hashCode * 59 + this.ImageUri.GetHashCode();
                if (this.AccessibilityText != null)
                    hashCode = hashCode * 59 + this.AccessibilityText.GetHashCode();
                return hashCode;
            }
        }

    }

}
