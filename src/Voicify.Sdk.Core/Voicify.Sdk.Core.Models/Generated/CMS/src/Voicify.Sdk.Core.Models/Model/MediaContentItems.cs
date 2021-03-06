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
    /// MediaContentItems
    /// </summary>
    [DataContract]
        public partial class MediaContentItems :  IEquatable<MediaContentItems>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContentItems" /> class.
        /// </summary>
        /// <param name="mediaItemId">mediaItemId.</param>
        /// <param name="contentItems">contentItems.</param>
        public MediaContentItems(string mediaItemId = default(string), List<MediaRelatedContentItem> contentItems = default(List<MediaRelatedContentItem>))
        {
            this.MediaItemId = mediaItemId;
            this.ContentItems = contentItems;
        }
        
        /// <summary>
        /// Gets or Sets MediaItemId
        /// </summary>
        [DataMember(Name="mediaItemId", EmitDefaultValue=false)]
        public string MediaItemId { get; set; }

        /// <summary>
        /// Gets or Sets ContentItems
        /// </summary>
        [DataMember(Name="contentItems", EmitDefaultValue=false)]
        public List<MediaRelatedContentItem> ContentItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaContentItems {\n");
            sb.Append("  MediaItemId: ").Append(MediaItemId).Append("\n");
            sb.Append("  ContentItems: ").Append(ContentItems).Append("\n");
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
            return this.Equals(input as MediaContentItems);
        }

        /// <summary>
        /// Returns true if MediaContentItems instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaContentItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaContentItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MediaItemId == input.MediaItemId ||
                    (this.MediaItemId != null &&
                    this.MediaItemId.Equals(input.MediaItemId))
                ) && 
                (
                    this.ContentItems == input.ContentItems ||
                    this.ContentItems != null &&
                    input.ContentItems != null &&
                    this.ContentItems.SequenceEqual(input.ContentItems)
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
                if (this.MediaItemId != null)
                    hashCode = hashCode * 59 + this.MediaItemId.GetHashCode();
                if (this.ContentItems != null)
                    hashCode = hashCode * 59 + this.ContentItems.GetHashCode();
                return hashCode;
            }
        }

    }
}
