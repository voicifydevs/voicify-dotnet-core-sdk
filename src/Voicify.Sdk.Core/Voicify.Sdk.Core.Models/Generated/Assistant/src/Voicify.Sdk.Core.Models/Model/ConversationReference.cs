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
    /// ConversationReference
    /// </summary>
    [DataContract]
    public partial class ConversationReference :  IEquatable<ConversationReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationReference" /> class.
        /// </summary>
        /// <param name="activityId">activityId.</param>
        /// <param name="user">user.</param>
        /// <param name="bot">bot.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="channelId">channelId.</param>
        /// <param name="serviceUrl">serviceUrl.</param>
        public ConversationReference(string activityId = default(string), ChannelAccount user = default(ChannelAccount), ChannelAccount bot = default(ChannelAccount), ConversationAccount conversation = default(ConversationAccount), string channelId = default(string), string serviceUrl = default(string))
        {
            this.ActivityId = activityId;
            this.User = user;
            this.Bot = bot;
            this.Conversation = conversation;
            this.ChannelId = channelId;
            this.ServiceUrl = serviceUrl;
        }
        
        /// <summary>
        /// Gets or Sets ActivityId
        /// </summary>
        [DataMember(Name="activityId", EmitDefaultValue=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public ChannelAccount User { get; set; }

        /// <summary>
        /// Gets or Sets Bot
        /// </summary>
        [DataMember(Name="bot", EmitDefaultValue=false)]
        public ChannelAccount Bot { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationAccount Conversation { get; set; }

        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceUrl
        /// </summary>
        [DataMember(Name="serviceUrl", EmitDefaultValue=false)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationReference {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Bot: ").Append(Bot).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  ServiceUrl: ").Append(ServiceUrl).Append("\n");
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
            return this.Equals(input as ConversationReference);
        }

        /// <summary>
        /// Returns true if ConversationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Bot == input.Bot ||
                    (this.Bot != null &&
                    this.Bot.Equals(input.Bot))
                ) && 
                (
                    this.Conversation == input.Conversation ||
                    (this.Conversation != null &&
                    this.Conversation.Equals(input.Conversation))
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))
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
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Bot != null)
                    hashCode = hashCode * 59 + this.Bot.GetHashCode();
                if (this.Conversation != null)
                    hashCode = hashCode * 59 + this.Conversation.GetHashCode();
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.ServiceUrl != null)
                    hashCode = hashCode * 59 + this.ServiceUrl.GetHashCode();
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
