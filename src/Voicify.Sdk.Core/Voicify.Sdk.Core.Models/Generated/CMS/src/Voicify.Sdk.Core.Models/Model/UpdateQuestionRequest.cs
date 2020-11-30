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
    /// UpdateQuestionRequest
    /// </summary>
    [DataContract]
    public partial class UpdateQuestionRequest :  IEquatable<UpdateQuestionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateQuestionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateQuestionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateQuestionRequest" /> class.
        /// </summary>
        /// <param name="questionId">questionId.</param>
        /// <param name="content">content (required).</param>
        public UpdateQuestionRequest(string questionId = default(string), string content = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for UpdateQuestionRequest and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.QuestionId = questionId;
        }
        
        /// <summary>
        /// Gets or Sets QuestionId
        /// </summary>
        [DataMember(Name="questionId", EmitDefaultValue=false)]
        public string QuestionId { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateQuestionRequest {\n");
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as UpdateQuestionRequest);
        }

        /// <summary>
        /// Returns true if UpdateQuestionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateQuestionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateQuestionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuestionId == input.QuestionId ||
                    (this.QuestionId != null &&
                    this.QuestionId.Equals(input.QuestionId))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.QuestionId != null)
                    hashCode = hashCode * 59 + this.QuestionId.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }

    }

}
