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
    /// ResponseTemplateTypeModel
    /// </summary>
    [DataContract]
        public partial class ResponseTemplateTypeModel :  IEquatable<ResponseTemplateTypeModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTemplateTypeModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="nativeName">nativeName.</param>
        /// <param name="description">description.</param>
        /// <param name="assistant">assistant.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="isDisabled">isDisabled.</param>
        /// <param name="usesVideo">usesVideo.</param>
        /// <param name="usesAudio">usesAudio.</param>
        /// <param name="usesBackgroundImage">usesBackgroundImage.</param>
        /// <param name="usesForegroundImage">usesForegroundImage.</param>
        /// <param name="usesDisplayText">usesDisplayText.</param>
        /// <param name="usesDisplayTitle">usesDisplayTitle.</param>
        /// <param name="usesReadout">usesReadout.</param>
        /// <param name="usesCustomMarkup">usesCustomMarkup.</param>
        /// <param name="requiresVideo">requiresVideo.</param>
        /// <param name="requiresAudio">requiresAudio.</param>
        /// <param name="requiresBackgroundImage">requiresBackgroundImage.</param>
        /// <param name="requiresForegroundImage">requiresForegroundImage.</param>
        /// <param name="requiresDisplayText">requiresDisplayText.</param>
        /// <param name="requiresDisplayTitle">requiresDisplayTitle.</param>
        /// <param name="requiresReadout">requiresReadout.</param>
        /// <param name="requiresCustomMarkup">requiresCustomMarkup.</param>
        public ResponseTemplateTypeModel(string id = default(string), string name = default(string), string nativeName = default(string), string description = default(string), string assistant = default(string), string iconUrl = default(string), bool? isDisabled = default(bool?), bool? usesVideo = default(bool?), bool? usesAudio = default(bool?), bool? usesBackgroundImage = default(bool?), bool? usesForegroundImage = default(bool?), bool? usesDisplayText = default(bool?), bool? usesDisplayTitle = default(bool?), bool? usesReadout = default(bool?), bool? usesCustomMarkup = default(bool?), bool? requiresVideo = default(bool?), bool? requiresAudio = default(bool?), bool? requiresBackgroundImage = default(bool?), bool? requiresForegroundImage = default(bool?), bool? requiresDisplayText = default(bool?), bool? requiresDisplayTitle = default(bool?), bool? requiresReadout = default(bool?), bool? requiresCustomMarkup = default(bool?))
        {
            this.Id = id;
            this.Name = name;
            this.NativeName = nativeName;
            this.Description = description;
            this.Assistant = assistant;
            this.IconUrl = iconUrl;
            this.IsDisabled = isDisabled;
            this.UsesVideo = usesVideo;
            this.UsesAudio = usesAudio;
            this.UsesBackgroundImage = usesBackgroundImage;
            this.UsesForegroundImage = usesForegroundImage;
            this.UsesDisplayText = usesDisplayText;
            this.UsesDisplayTitle = usesDisplayTitle;
            this.UsesReadout = usesReadout;
            this.UsesCustomMarkup = usesCustomMarkup;
            this.RequiresVideo = requiresVideo;
            this.RequiresAudio = requiresAudio;
            this.RequiresBackgroundImage = requiresBackgroundImage;
            this.RequiresForegroundImage = requiresForegroundImage;
            this.RequiresDisplayText = requiresDisplayText;
            this.RequiresDisplayTitle = requiresDisplayTitle;
            this.RequiresReadout = requiresReadout;
            this.RequiresCustomMarkup = requiresCustomMarkup;
        }
        
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
        /// Gets or Sets NativeName
        /// </summary>
        [DataMember(Name="nativeName", EmitDefaultValue=false)]
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Assistant
        /// </summary>
        [DataMember(Name="assistant", EmitDefaultValue=false)]
        public string Assistant { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name="isDisabled", EmitDefaultValue=false)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets UsesVideo
        /// </summary>
        [DataMember(Name="usesVideo", EmitDefaultValue=false)]
        public bool? UsesVideo { get; set; }

        /// <summary>
        /// Gets or Sets UsesAudio
        /// </summary>
        [DataMember(Name="usesAudio", EmitDefaultValue=false)]
        public bool? UsesAudio { get; set; }

        /// <summary>
        /// Gets or Sets UsesBackgroundImage
        /// </summary>
        [DataMember(Name="usesBackgroundImage", EmitDefaultValue=false)]
        public bool? UsesBackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets UsesForegroundImage
        /// </summary>
        [DataMember(Name="usesForegroundImage", EmitDefaultValue=false)]
        public bool? UsesForegroundImage { get; set; }

        /// <summary>
        /// Gets or Sets UsesDisplayText
        /// </summary>
        [DataMember(Name="usesDisplayText", EmitDefaultValue=false)]
        public bool? UsesDisplayText { get; set; }

        /// <summary>
        /// Gets or Sets UsesDisplayTitle
        /// </summary>
        [DataMember(Name="usesDisplayTitle", EmitDefaultValue=false)]
        public bool? UsesDisplayTitle { get; set; }

        /// <summary>
        /// Gets or Sets UsesReadout
        /// </summary>
        [DataMember(Name="usesReadout", EmitDefaultValue=false)]
        public bool? UsesReadout { get; set; }

        /// <summary>
        /// Gets or Sets UsesCustomMarkup
        /// </summary>
        [DataMember(Name="usesCustomMarkup", EmitDefaultValue=false)]
        public bool? UsesCustomMarkup { get; set; }

        /// <summary>
        /// Gets or Sets RequiresVideo
        /// </summary>
        [DataMember(Name="requiresVideo", EmitDefaultValue=false)]
        public bool? RequiresVideo { get; set; }

        /// <summary>
        /// Gets or Sets RequiresAudio
        /// </summary>
        [DataMember(Name="requiresAudio", EmitDefaultValue=false)]
        public bool? RequiresAudio { get; set; }

        /// <summary>
        /// Gets or Sets RequiresBackgroundImage
        /// </summary>
        [DataMember(Name="requiresBackgroundImage", EmitDefaultValue=false)]
        public bool? RequiresBackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets RequiresForegroundImage
        /// </summary>
        [DataMember(Name="requiresForegroundImage", EmitDefaultValue=false)]
        public bool? RequiresForegroundImage { get; set; }

        /// <summary>
        /// Gets or Sets RequiresDisplayText
        /// </summary>
        [DataMember(Name="requiresDisplayText", EmitDefaultValue=false)]
        public bool? RequiresDisplayText { get; set; }

        /// <summary>
        /// Gets or Sets RequiresDisplayTitle
        /// </summary>
        [DataMember(Name="requiresDisplayTitle", EmitDefaultValue=false)]
        public bool? RequiresDisplayTitle { get; set; }

        /// <summary>
        /// Gets or Sets RequiresReadout
        /// </summary>
        [DataMember(Name="requiresReadout", EmitDefaultValue=false)]
        public bool? RequiresReadout { get; set; }

        /// <summary>
        /// Gets or Sets RequiresCustomMarkup
        /// </summary>
        [DataMember(Name="requiresCustomMarkup", EmitDefaultValue=false)]
        public bool? RequiresCustomMarkup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseTemplateTypeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NativeName: ").Append(NativeName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Assistant: ").Append(Assistant).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  UsesVideo: ").Append(UsesVideo).Append("\n");
            sb.Append("  UsesAudio: ").Append(UsesAudio).Append("\n");
            sb.Append("  UsesBackgroundImage: ").Append(UsesBackgroundImage).Append("\n");
            sb.Append("  UsesForegroundImage: ").Append(UsesForegroundImage).Append("\n");
            sb.Append("  UsesDisplayText: ").Append(UsesDisplayText).Append("\n");
            sb.Append("  UsesDisplayTitle: ").Append(UsesDisplayTitle).Append("\n");
            sb.Append("  UsesReadout: ").Append(UsesReadout).Append("\n");
            sb.Append("  UsesCustomMarkup: ").Append(UsesCustomMarkup).Append("\n");
            sb.Append("  RequiresVideo: ").Append(RequiresVideo).Append("\n");
            sb.Append("  RequiresAudio: ").Append(RequiresAudio).Append("\n");
            sb.Append("  RequiresBackgroundImage: ").Append(RequiresBackgroundImage).Append("\n");
            sb.Append("  RequiresForegroundImage: ").Append(RequiresForegroundImage).Append("\n");
            sb.Append("  RequiresDisplayText: ").Append(RequiresDisplayText).Append("\n");
            sb.Append("  RequiresDisplayTitle: ").Append(RequiresDisplayTitle).Append("\n");
            sb.Append("  RequiresReadout: ").Append(RequiresReadout).Append("\n");
            sb.Append("  RequiresCustomMarkup: ").Append(RequiresCustomMarkup).Append("\n");
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
            return this.Equals(input as ResponseTemplateTypeModel);
        }

        /// <summary>
        /// Returns true if ResponseTemplateTypeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseTemplateTypeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseTemplateTypeModel input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NativeName == input.NativeName ||
                    (this.NativeName != null &&
                    this.NativeName.Equals(input.NativeName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Assistant == input.Assistant ||
                    (this.Assistant != null &&
                    this.Assistant.Equals(input.Assistant))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    (this.IsDisabled != null &&
                    this.IsDisabled.Equals(input.IsDisabled))
                ) && 
                (
                    this.UsesVideo == input.UsesVideo ||
                    (this.UsesVideo != null &&
                    this.UsesVideo.Equals(input.UsesVideo))
                ) && 
                (
                    this.UsesAudio == input.UsesAudio ||
                    (this.UsesAudio != null &&
                    this.UsesAudio.Equals(input.UsesAudio))
                ) && 
                (
                    this.UsesBackgroundImage == input.UsesBackgroundImage ||
                    (this.UsesBackgroundImage != null &&
                    this.UsesBackgroundImage.Equals(input.UsesBackgroundImage))
                ) && 
                (
                    this.UsesForegroundImage == input.UsesForegroundImage ||
                    (this.UsesForegroundImage != null &&
                    this.UsesForegroundImage.Equals(input.UsesForegroundImage))
                ) && 
                (
                    this.UsesDisplayText == input.UsesDisplayText ||
                    (this.UsesDisplayText != null &&
                    this.UsesDisplayText.Equals(input.UsesDisplayText))
                ) && 
                (
                    this.UsesDisplayTitle == input.UsesDisplayTitle ||
                    (this.UsesDisplayTitle != null &&
                    this.UsesDisplayTitle.Equals(input.UsesDisplayTitle))
                ) && 
                (
                    this.UsesReadout == input.UsesReadout ||
                    (this.UsesReadout != null &&
                    this.UsesReadout.Equals(input.UsesReadout))
                ) && 
                (
                    this.UsesCustomMarkup == input.UsesCustomMarkup ||
                    (this.UsesCustomMarkup != null &&
                    this.UsesCustomMarkup.Equals(input.UsesCustomMarkup))
                ) && 
                (
                    this.RequiresVideo == input.RequiresVideo ||
                    (this.RequiresVideo != null &&
                    this.RequiresVideo.Equals(input.RequiresVideo))
                ) && 
                (
                    this.RequiresAudio == input.RequiresAudio ||
                    (this.RequiresAudio != null &&
                    this.RequiresAudio.Equals(input.RequiresAudio))
                ) && 
                (
                    this.RequiresBackgroundImage == input.RequiresBackgroundImage ||
                    (this.RequiresBackgroundImage != null &&
                    this.RequiresBackgroundImage.Equals(input.RequiresBackgroundImage))
                ) && 
                (
                    this.RequiresForegroundImage == input.RequiresForegroundImage ||
                    (this.RequiresForegroundImage != null &&
                    this.RequiresForegroundImage.Equals(input.RequiresForegroundImage))
                ) && 
                (
                    this.RequiresDisplayText == input.RequiresDisplayText ||
                    (this.RequiresDisplayText != null &&
                    this.RequiresDisplayText.Equals(input.RequiresDisplayText))
                ) && 
                (
                    this.RequiresDisplayTitle == input.RequiresDisplayTitle ||
                    (this.RequiresDisplayTitle != null &&
                    this.RequiresDisplayTitle.Equals(input.RequiresDisplayTitle))
                ) && 
                (
                    this.RequiresReadout == input.RequiresReadout ||
                    (this.RequiresReadout != null &&
                    this.RequiresReadout.Equals(input.RequiresReadout))
                ) && 
                (
                    this.RequiresCustomMarkup == input.RequiresCustomMarkup ||
                    (this.RequiresCustomMarkup != null &&
                    this.RequiresCustomMarkup.Equals(input.RequiresCustomMarkup))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NativeName != null)
                    hashCode = hashCode * 59 + this.NativeName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Assistant != null)
                    hashCode = hashCode * 59 + this.Assistant.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.IsDisabled != null)
                    hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
                if (this.UsesVideo != null)
                    hashCode = hashCode * 59 + this.UsesVideo.GetHashCode();
                if (this.UsesAudio != null)
                    hashCode = hashCode * 59 + this.UsesAudio.GetHashCode();
                if (this.UsesBackgroundImage != null)
                    hashCode = hashCode * 59 + this.UsesBackgroundImage.GetHashCode();
                if (this.UsesForegroundImage != null)
                    hashCode = hashCode * 59 + this.UsesForegroundImage.GetHashCode();
                if (this.UsesDisplayText != null)
                    hashCode = hashCode * 59 + this.UsesDisplayText.GetHashCode();
                if (this.UsesDisplayTitle != null)
                    hashCode = hashCode * 59 + this.UsesDisplayTitle.GetHashCode();
                if (this.UsesReadout != null)
                    hashCode = hashCode * 59 + this.UsesReadout.GetHashCode();
                if (this.UsesCustomMarkup != null)
                    hashCode = hashCode * 59 + this.UsesCustomMarkup.GetHashCode();
                if (this.RequiresVideo != null)
                    hashCode = hashCode * 59 + this.RequiresVideo.GetHashCode();
                if (this.RequiresAudio != null)
                    hashCode = hashCode * 59 + this.RequiresAudio.GetHashCode();
                if (this.RequiresBackgroundImage != null)
                    hashCode = hashCode * 59 + this.RequiresBackgroundImage.GetHashCode();
                if (this.RequiresForegroundImage != null)
                    hashCode = hashCode * 59 + this.RequiresForegroundImage.GetHashCode();
                if (this.RequiresDisplayText != null)
                    hashCode = hashCode * 59 + this.RequiresDisplayText.GetHashCode();
                if (this.RequiresDisplayTitle != null)
                    hashCode = hashCode * 59 + this.RequiresDisplayTitle.GetHashCode();
                if (this.RequiresReadout != null)
                    hashCode = hashCode * 59 + this.RequiresReadout.GetHashCode();
                if (this.RequiresCustomMarkup != null)
                    hashCode = hashCode * 59 + this.RequiresCustomMarkup.GetHashCode();
                return hashCode;
            }
        }

    }
}
