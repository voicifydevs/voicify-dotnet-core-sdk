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
    /// TemplateFormModel
    /// </summary>
    [DataContract]
        public partial class TemplateFormModel :  IEquatable<TemplateFormModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFormModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="templateConfigurationId">templateConfigurationId.</param>
        /// <param name="instructionsMarkdown">instructionsMarkdown.</param>
        /// <param name="templateFormSections">templateFormSections.</param>
        public TemplateFormModel(string id = default(string), string templateConfigurationId = default(string), string instructionsMarkdown = default(string), List<TemplateFormSectionModel> templateFormSections = default(List<TemplateFormSectionModel>))
        {
            this.Id = id;
            this.TemplateConfigurationId = templateConfigurationId;
            this.InstructionsMarkdown = instructionsMarkdown;
            this.TemplateFormSections = templateFormSections;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TemplateConfigurationId
        /// </summary>
        [DataMember(Name="templateConfigurationId", EmitDefaultValue=false)]
        public string TemplateConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets InstructionsMarkdown
        /// </summary>
        [DataMember(Name="instructionsMarkdown", EmitDefaultValue=false)]
        public string InstructionsMarkdown { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormSections
        /// </summary>
        [DataMember(Name="templateFormSections", EmitDefaultValue=false)]
        public List<TemplateFormSectionModel> TemplateFormSections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateFormModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateConfigurationId: ").Append(TemplateConfigurationId).Append("\n");
            sb.Append("  InstructionsMarkdown: ").Append(InstructionsMarkdown).Append("\n");
            sb.Append("  TemplateFormSections: ").Append(TemplateFormSections).Append("\n");
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
            return this.Equals(input as TemplateFormModel);
        }

        /// <summary>
        /// Returns true if TemplateFormModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateFormModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateFormModel input)
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
                    this.TemplateConfigurationId == input.TemplateConfigurationId ||
                    (this.TemplateConfigurationId != null &&
                    this.TemplateConfigurationId.Equals(input.TemplateConfigurationId))
                ) && 
                (
                    this.InstructionsMarkdown == input.InstructionsMarkdown ||
                    (this.InstructionsMarkdown != null &&
                    this.InstructionsMarkdown.Equals(input.InstructionsMarkdown))
                ) && 
                (
                    this.TemplateFormSections == input.TemplateFormSections ||
                    this.TemplateFormSections != null &&
                    input.TemplateFormSections != null &&
                    this.TemplateFormSections.SequenceEqual(input.TemplateFormSections)
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
                if (this.TemplateConfigurationId != null)
                    hashCode = hashCode * 59 + this.TemplateConfigurationId.GetHashCode();
                if (this.InstructionsMarkdown != null)
                    hashCode = hashCode * 59 + this.InstructionsMarkdown.GetHashCode();
                if (this.TemplateFormSections != null)
                    hashCode = hashCode * 59 + this.TemplateFormSections.GetHashCode();
                return hashCode;
            }
        }

    }
}
