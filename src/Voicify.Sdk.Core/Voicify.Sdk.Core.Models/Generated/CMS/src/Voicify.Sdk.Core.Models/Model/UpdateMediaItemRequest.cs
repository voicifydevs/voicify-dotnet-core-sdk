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
    /// UpdateMediaItemRequest
    /// </summary>
    [DataContract]
    public partial class UpdateMediaItemRequest :  IEquatable<UpdateMediaItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMediaItemRequest" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="name">name.</param>
        /// <param name="mediaType">mediaType.</param>
        /// <param name="caption">caption.</param>
        /// <param name="fileExtension">fileExtension.</param>
        /// <param name="isDisabled">isDisabled.</param>
        public UpdateMediaItemRequest(string url = default(string), string name = default(string), string mediaType = default(string), string caption = default(string), string fileExtension = default(string), bool? isDisabled = default(bool?))
        {
            this.Url = url;
            this.Name = name;
            this.MediaType = mediaType;
            this.Caption = caption;
            this.FileExtension = fileExtension;
            this.IsDisabled = isDisabled;
        }
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name="caption", EmitDefaultValue=false)]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or Sets FileExtension
        /// </summary>
        [DataMember(Name="fileExtension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name="isDisabled", EmitDefaultValue=false)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMediaItemRequest {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
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
            return this.Equals(input as UpdateMediaItemRequest);
        }

        /// <summary>
        /// Returns true if UpdateMediaItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMediaItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMediaItemRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
                (
                    this.FileExtension == input.FileExtension ||
                    (this.FileExtension != null &&
                    this.FileExtension.Equals(input.FileExtension))
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    (this.IsDisabled != null &&
                    this.IsDisabled.Equals(input.IsDisabled))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.FileExtension != null)
                    hashCode = hashCode * 59 + this.FileExtension.GetHashCode();
                if (this.IsDisabled != null)
                    hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
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