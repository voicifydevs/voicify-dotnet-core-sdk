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
    /// CustomAssistantDevice
    /// </summary>
    [DataContract]
    public partial class CustomAssistantDevice :  IEquatable<CustomAssistantDevice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAssistantDevice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomAssistantDevice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAssistantDevice" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="supportsVideo">supportsVideo.</param>
        /// <param name="supportsForegroundImage">supportsForegroundImage.</param>
        /// <param name="supportsBackgroundImage">supportsBackgroundImage.</param>
        /// <param name="supportsAudio">supportsAudio.</param>
        /// <param name="supportsSsml">supportsSsml.</param>
        /// <param name="supportsDisplayText">supportsDisplayText.</param>
        /// <param name="supportsVoiceInput">supportsVoiceInput.</param>
        /// <param name="supportsTextInput">supportsTextInput.</param>
        public CustomAssistantDevice(string id = default(string), string name = default(string), bool? supportsVideo = default(bool?), bool? supportsForegroundImage = default(bool?), bool? supportsBackgroundImage = default(bool?), bool? supportsAudio = default(bool?), bool? supportsSsml = default(bool?), bool? supportsDisplayText = default(bool?), bool? supportsVoiceInput = default(bool?), bool? supportsTextInput = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CustomAssistantDevice and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CustomAssistantDevice and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.SupportsVideo = supportsVideo;
            this.SupportsForegroundImage = supportsForegroundImage;
            this.SupportsBackgroundImage = supportsBackgroundImage;
            this.SupportsAudio = supportsAudio;
            this.SupportsSsml = supportsSsml;
            this.SupportsDisplayText = supportsDisplayText;
            this.SupportsVoiceInput = supportsVoiceInput;
            this.SupportsTextInput = supportsTextInput;
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
        /// Gets or Sets SupportsVideo
        /// </summary>
        [DataMember(Name="supportsVideo", EmitDefaultValue=false)]
        public bool? SupportsVideo { get; set; }

        /// <summary>
        /// Gets or Sets SupportsForegroundImage
        /// </summary>
        [DataMember(Name="supportsForegroundImage", EmitDefaultValue=false)]
        public bool? SupportsForegroundImage { get; set; }

        /// <summary>
        /// Gets or Sets SupportsBackgroundImage
        /// </summary>
        [DataMember(Name="supportsBackgroundImage", EmitDefaultValue=false)]
        public bool? SupportsBackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets SupportsAudio
        /// </summary>
        [DataMember(Name="supportsAudio", EmitDefaultValue=false)]
        public bool? SupportsAudio { get; set; }

        /// <summary>
        /// Gets or Sets SupportsSsml
        /// </summary>
        [DataMember(Name="supportsSsml", EmitDefaultValue=false)]
        public bool? SupportsSsml { get; set; }

        /// <summary>
        /// Gets or Sets SupportsDisplayText
        /// </summary>
        [DataMember(Name="supportsDisplayText", EmitDefaultValue=false)]
        public bool? SupportsDisplayText { get; set; }

        /// <summary>
        /// Gets or Sets SupportsVoiceInput
        /// </summary>
        [DataMember(Name="supportsVoiceInput", EmitDefaultValue=false)]
        public bool? SupportsVoiceInput { get; set; }

        /// <summary>
        /// Gets or Sets SupportsTextInput
        /// </summary>
        [DataMember(Name="supportsTextInput", EmitDefaultValue=false)]
        public bool? SupportsTextInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomAssistantDevice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportsVideo: ").Append(SupportsVideo).Append("\n");
            sb.Append("  SupportsForegroundImage: ").Append(SupportsForegroundImage).Append("\n");
            sb.Append("  SupportsBackgroundImage: ").Append(SupportsBackgroundImage).Append("\n");
            sb.Append("  SupportsAudio: ").Append(SupportsAudio).Append("\n");
            sb.Append("  SupportsSsml: ").Append(SupportsSsml).Append("\n");
            sb.Append("  SupportsDisplayText: ").Append(SupportsDisplayText).Append("\n");
            sb.Append("  SupportsVoiceInput: ").Append(SupportsVoiceInput).Append("\n");
            sb.Append("  SupportsTextInput: ").Append(SupportsTextInput).Append("\n");
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
            return this.Equals(input as CustomAssistantDevice);
        }

        /// <summary>
        /// Returns true if CustomAssistantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomAssistantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAssistantDevice input)
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
                    this.SupportsVideo == input.SupportsVideo ||
                    (this.SupportsVideo != null &&
                    this.SupportsVideo.Equals(input.SupportsVideo))
                ) && 
                (
                    this.SupportsForegroundImage == input.SupportsForegroundImage ||
                    (this.SupportsForegroundImage != null &&
                    this.SupportsForegroundImage.Equals(input.SupportsForegroundImage))
                ) && 
                (
                    this.SupportsBackgroundImage == input.SupportsBackgroundImage ||
                    (this.SupportsBackgroundImage != null &&
                    this.SupportsBackgroundImage.Equals(input.SupportsBackgroundImage))
                ) && 
                (
                    this.SupportsAudio == input.SupportsAudio ||
                    (this.SupportsAudio != null &&
                    this.SupportsAudio.Equals(input.SupportsAudio))
                ) && 
                (
                    this.SupportsSsml == input.SupportsSsml ||
                    (this.SupportsSsml != null &&
                    this.SupportsSsml.Equals(input.SupportsSsml))
                ) && 
                (
                    this.SupportsDisplayText == input.SupportsDisplayText ||
                    (this.SupportsDisplayText != null &&
                    this.SupportsDisplayText.Equals(input.SupportsDisplayText))
                ) && 
                (
                    this.SupportsVoiceInput == input.SupportsVoiceInput ||
                    (this.SupportsVoiceInput != null &&
                    this.SupportsVoiceInput.Equals(input.SupportsVoiceInput))
                ) && 
                (
                    this.SupportsTextInput == input.SupportsTextInput ||
                    (this.SupportsTextInput != null &&
                    this.SupportsTextInput.Equals(input.SupportsTextInput))
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
                if (this.SupportsVideo != null)
                    hashCode = hashCode * 59 + this.SupportsVideo.GetHashCode();
                if (this.SupportsForegroundImage != null)
                    hashCode = hashCode * 59 + this.SupportsForegroundImage.GetHashCode();
                if (this.SupportsBackgroundImage != null)
                    hashCode = hashCode * 59 + this.SupportsBackgroundImage.GetHashCode();
                if (this.SupportsAudio != null)
                    hashCode = hashCode * 59 + this.SupportsAudio.GetHashCode();
                if (this.SupportsSsml != null)
                    hashCode = hashCode * 59 + this.SupportsSsml.GetHashCode();
                if (this.SupportsDisplayText != null)
                    hashCode = hashCode * 59 + this.SupportsDisplayText.GetHashCode();
                if (this.SupportsVoiceInput != null)
                    hashCode = hashCode * 59 + this.SupportsVoiceInput.GetHashCode();
                if (this.SupportsTextInput != null)
                    hashCode = hashCode * 59 + this.SupportsTextInput.GetHashCode();
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
