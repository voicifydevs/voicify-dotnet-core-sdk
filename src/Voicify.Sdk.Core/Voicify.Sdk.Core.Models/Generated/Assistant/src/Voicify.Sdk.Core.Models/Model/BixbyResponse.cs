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
    /// BixbyResponse
    /// </summary>
    [DataContract]
    public partial class BixbyResponse :  IEquatable<BixbyResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BixbyResponse" /> class.
        /// </summary>
        /// <param name="responseId">responseId.</param>
        /// <param name="ssml">ssml.</param>
        /// <param name="outputSpeech">outputSpeech.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="displayTitle">displayTitle.</param>
        /// <param name="responseTemplate">responseTemplate.</param>
        /// <param name="foregroundImage">foregroundImage.</param>
        /// <param name="backgroundImage">backgroundImage.</param>
        /// <param name="audioFile">audioFile.</param>
        /// <param name="videoFile">videoFile.</param>
        /// <param name="sessionAttributes">sessionAttributes.</param>
        /// <param name="hints">hints.</param>
        /// <param name="listItems">listItems.</param>
        public BixbyResponse(string responseId = default(string), string ssml = default(string), string outputSpeech = default(string), string displayText = default(string), string displayTitle = default(string), string responseTemplate = default(string), MediaItemModel foregroundImage = default(MediaItemModel), MediaItemModel backgroundImage = default(MediaItemModel), MediaItemModel audioFile = default(MediaItemModel), MediaItemModel videoFile = default(MediaItemModel), Dictionary<string, Object> sessionAttributes = default(Dictionary<string, Object>), List<string> hints = default(List<string>), List<BixbyListItem> listItems = default(List<BixbyListItem>))
        {
            this.ResponseId = responseId;
            this.Ssml = ssml;
            this.OutputSpeech = outputSpeech;
            this.DisplayText = displayText;
            this.DisplayTitle = displayTitle;
            this.ResponseTemplate = responseTemplate;
            this.ForegroundImage = foregroundImage;
            this.BackgroundImage = backgroundImage;
            this.AudioFile = audioFile;
            this.VideoFile = videoFile;
            this.SessionAttributes = sessionAttributes;
            this.Hints = hints;
            this.ListItems = listItems;
        }
        
        /// <summary>
        /// Gets or Sets ResponseId
        /// </summary>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Gets or Sets Ssml
        /// </summary>
        [DataMember(Name="ssml", EmitDefaultValue=false)]
        public string Ssml { get; set; }

        /// <summary>
        /// Gets or Sets OutputSpeech
        /// </summary>
        [DataMember(Name="outputSpeech", EmitDefaultValue=false)]
        public string OutputSpeech { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=false)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTitle
        /// </summary>
        [DataMember(Name="displayTitle", EmitDefaultValue=false)]
        public string DisplayTitle { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTemplate
        /// </summary>
        [DataMember(Name="responseTemplate", EmitDefaultValue=false)]
        public string ResponseTemplate { get; set; }

        /// <summary>
        /// Gets or Sets ForegroundImage
        /// </summary>
        [DataMember(Name="foregroundImage", EmitDefaultValue=false)]
        public MediaItemModel ForegroundImage { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name="backgroundImage", EmitDefaultValue=false)]
        public MediaItemModel BackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets AudioFile
        /// </summary>
        [DataMember(Name="audioFile", EmitDefaultValue=false)]
        public MediaItemModel AudioFile { get; set; }

        /// <summary>
        /// Gets or Sets VideoFile
        /// </summary>
        [DataMember(Name="videoFile", EmitDefaultValue=false)]
        public MediaItemModel VideoFile { get; set; }

        /// <summary>
        /// Gets or Sets SessionAttributes
        /// </summary>
        [DataMember(Name="sessionAttributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> SessionAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Hints
        /// </summary>
        [DataMember(Name="hints", EmitDefaultValue=false)]
        public List<string> Hints { get; set; }

        /// <summary>
        /// Gets or Sets ListItems
        /// </summary>
        [DataMember(Name="listItems", EmitDefaultValue=false)]
        public List<BixbyListItem> ListItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BixbyResponse {\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  Ssml: ").Append(Ssml).Append("\n");
            sb.Append("  OutputSpeech: ").Append(OutputSpeech).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  DisplayTitle: ").Append(DisplayTitle).Append("\n");
            sb.Append("  ResponseTemplate: ").Append(ResponseTemplate).Append("\n");
            sb.Append("  ForegroundImage: ").Append(ForegroundImage).Append("\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  AudioFile: ").Append(AudioFile).Append("\n");
            sb.Append("  VideoFile: ").Append(VideoFile).Append("\n");
            sb.Append("  SessionAttributes: ").Append(SessionAttributes).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("  ListItems: ").Append(ListItems).Append("\n");
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
            return this.Equals(input as BixbyResponse);
        }

        /// <summary>
        /// Returns true if BixbyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BixbyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BixbyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
                ) && 
                (
                    this.Ssml == input.Ssml ||
                    (this.Ssml != null &&
                    this.Ssml.Equals(input.Ssml))
                ) && 
                (
                    this.OutputSpeech == input.OutputSpeech ||
                    (this.OutputSpeech != null &&
                    this.OutputSpeech.Equals(input.OutputSpeech))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.DisplayTitle == input.DisplayTitle ||
                    (this.DisplayTitle != null &&
                    this.DisplayTitle.Equals(input.DisplayTitle))
                ) && 
                (
                    this.ResponseTemplate == input.ResponseTemplate ||
                    (this.ResponseTemplate != null &&
                    this.ResponseTemplate.Equals(input.ResponseTemplate))
                ) && 
                (
                    this.ForegroundImage == input.ForegroundImage ||
                    (this.ForegroundImage != null &&
                    this.ForegroundImage.Equals(input.ForegroundImage))
                ) && 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.AudioFile == input.AudioFile ||
                    (this.AudioFile != null &&
                    this.AudioFile.Equals(input.AudioFile))
                ) && 
                (
                    this.VideoFile == input.VideoFile ||
                    (this.VideoFile != null &&
                    this.VideoFile.Equals(input.VideoFile))
                ) && 
                (
                    this.SessionAttributes == input.SessionAttributes ||
                    this.SessionAttributes != null &&
                    this.SessionAttributes.SequenceEqual(input.SessionAttributes)
                ) && 
                (
                    this.Hints == input.Hints ||
                    this.Hints != null &&
                    this.Hints.SequenceEqual(input.Hints)
                ) && 
                (
                    this.ListItems == input.ListItems ||
                    this.ListItems != null &&
                    this.ListItems.SequenceEqual(input.ListItems)
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
                if (this.ResponseId != null)
                    hashCode = hashCode * 59 + this.ResponseId.GetHashCode();
                if (this.Ssml != null)
                    hashCode = hashCode * 59 + this.Ssml.GetHashCode();
                if (this.OutputSpeech != null)
                    hashCode = hashCode * 59 + this.OutputSpeech.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.DisplayTitle != null)
                    hashCode = hashCode * 59 + this.DisplayTitle.GetHashCode();
                if (this.ResponseTemplate != null)
                    hashCode = hashCode * 59 + this.ResponseTemplate.GetHashCode();
                if (this.ForegroundImage != null)
                    hashCode = hashCode * 59 + this.ForegroundImage.GetHashCode();
                if (this.BackgroundImage != null)
                    hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.AudioFile != null)
                    hashCode = hashCode * 59 + this.AudioFile.GetHashCode();
                if (this.VideoFile != null)
                    hashCode = hashCode * 59 + this.VideoFile.GetHashCode();
                if (this.SessionAttributes != null)
                    hashCode = hashCode * 59 + this.SessionAttributes.GetHashCode();
                if (this.Hints != null)
                    hashCode = hashCode * 59 + this.Hints.GetHashCode();
                if (this.ListItems != null)
                    hashCode = hashCode * 59 + this.ListItems.GetHashCode();
                return hashCode;
            }
        }

    }

}
