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
    /// ParentContentContainerModel
    /// </summary>
    [DataContract]
        public partial class ParentContentContainerModel :  IEquatable<ParentContentContainerModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentContentContainerModel" /> class.
        /// </summary>
        /// <param name="welcomeMessages">welcomeMessages.</param>
        /// <param name="helpMessages">helpMessages.</param>
        /// <param name="fallbackMessages">fallbackMessages.</param>
        /// <param name="exitMessages">exitMessages.</param>
        /// <param name="questionAnswers">questionAnswers.</param>
        /// <param name="latestMessages">latestMessages.</param>
        /// <param name="eventItems">eventItems.</param>
        /// <param name="recipes">recipes.</param>
        /// <param name="simpleChoices">simpleChoices.</param>
        /// <param name="numberRanges">numberRanges.</param>
        /// <param name="customRequests">customRequests.</param>
        /// <param name="contentItems">contentItems.</param>
        public ParentContentContainerModel(List<WelcomeMessageModel> welcomeMessages = default(List<WelcomeMessageModel>), List<HelpMessageModel> helpMessages = default(List<HelpMessageModel>), List<FallbackMessageModel> fallbackMessages = default(List<FallbackMessageModel>), List<ExitMessageModel> exitMessages = default(List<ExitMessageModel>), List<QuestionAnswerModel> questionAnswers = default(List<QuestionAnswerModel>), List<LatestMessageModel> latestMessages = default(List<LatestMessageModel>), List<EventItemModel> eventItems = default(List<EventItemModel>), List<RecipeModel> recipes = default(List<RecipeModel>), List<SimpleChoiceModel> simpleChoices = default(List<SimpleChoiceModel>), List<NumberRangeModel> numberRanges = default(List<NumberRangeModel>), List<CustomRequestModel> customRequests = default(List<CustomRequestModel>), List<GenericContentModel> contentItems = default(List<GenericContentModel>))
        {
            this.WelcomeMessages = welcomeMessages;
            this.HelpMessages = helpMessages;
            this.FallbackMessages = fallbackMessages;
            this.ExitMessages = exitMessages;
            this.QuestionAnswers = questionAnswers;
            this.LatestMessages = latestMessages;
            this.EventItems = eventItems;
            this.Recipes = recipes;
            this.SimpleChoices = simpleChoices;
            this.NumberRanges = numberRanges;
            this.CustomRequests = customRequests;
            this.ContentItems = contentItems;
        }
        
        /// <summary>
        /// Gets or Sets WelcomeMessages
        /// </summary>
        [DataMember(Name="welcomeMessages", EmitDefaultValue=false)]
        public List<WelcomeMessageModel> WelcomeMessages { get; set; }

        /// <summary>
        /// Gets or Sets HelpMessages
        /// </summary>
        [DataMember(Name="helpMessages", EmitDefaultValue=false)]
        public List<HelpMessageModel> HelpMessages { get; set; }

        /// <summary>
        /// Gets or Sets FallbackMessages
        /// </summary>
        [DataMember(Name="fallbackMessages", EmitDefaultValue=false)]
        public List<FallbackMessageModel> FallbackMessages { get; set; }

        /// <summary>
        /// Gets or Sets ExitMessages
        /// </summary>
        [DataMember(Name="exitMessages", EmitDefaultValue=false)]
        public List<ExitMessageModel> ExitMessages { get; set; }

        /// <summary>
        /// Gets or Sets QuestionAnswers
        /// </summary>
        [DataMember(Name="questionAnswers", EmitDefaultValue=false)]
        public List<QuestionAnswerModel> QuestionAnswers { get; set; }

        /// <summary>
        /// Gets or Sets LatestMessages
        /// </summary>
        [DataMember(Name="latestMessages", EmitDefaultValue=false)]
        public List<LatestMessageModel> LatestMessages { get; set; }

        /// <summary>
        /// Gets or Sets EventItems
        /// </summary>
        [DataMember(Name="eventItems", EmitDefaultValue=false)]
        public List<EventItemModel> EventItems { get; set; }

        /// <summary>
        /// Gets or Sets Recipes
        /// </summary>
        [DataMember(Name="recipes", EmitDefaultValue=false)]
        public List<RecipeModel> Recipes { get; set; }

        /// <summary>
        /// Gets or Sets SimpleChoices
        /// </summary>
        [DataMember(Name="simpleChoices", EmitDefaultValue=false)]
        public List<SimpleChoiceModel> SimpleChoices { get; set; }

        /// <summary>
        /// Gets or Sets NumberRanges
        /// </summary>
        [DataMember(Name="numberRanges", EmitDefaultValue=false)]
        public List<NumberRangeModel> NumberRanges { get; set; }

        /// <summary>
        /// Gets or Sets CustomRequests
        /// </summary>
        [DataMember(Name="customRequests", EmitDefaultValue=false)]
        public List<CustomRequestModel> CustomRequests { get; set; }

        /// <summary>
        /// Gets or Sets ContentItems
        /// </summary>
        [DataMember(Name="contentItems", EmitDefaultValue=false)]
        public List<GenericContentModel> ContentItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParentContentContainerModel {\n");
            sb.Append("  WelcomeMessages: ").Append(WelcomeMessages).Append("\n");
            sb.Append("  HelpMessages: ").Append(HelpMessages).Append("\n");
            sb.Append("  FallbackMessages: ").Append(FallbackMessages).Append("\n");
            sb.Append("  ExitMessages: ").Append(ExitMessages).Append("\n");
            sb.Append("  QuestionAnswers: ").Append(QuestionAnswers).Append("\n");
            sb.Append("  LatestMessages: ").Append(LatestMessages).Append("\n");
            sb.Append("  EventItems: ").Append(EventItems).Append("\n");
            sb.Append("  Recipes: ").Append(Recipes).Append("\n");
            sb.Append("  SimpleChoices: ").Append(SimpleChoices).Append("\n");
            sb.Append("  NumberRanges: ").Append(NumberRanges).Append("\n");
            sb.Append("  CustomRequests: ").Append(CustomRequests).Append("\n");
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
            return this.Equals(input as ParentContentContainerModel);
        }

        /// <summary>
        /// Returns true if ParentContentContainerModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ParentContentContainerModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParentContentContainerModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WelcomeMessages == input.WelcomeMessages ||
                    this.WelcomeMessages != null &&
                    input.WelcomeMessages != null &&
                    this.WelcomeMessages.SequenceEqual(input.WelcomeMessages)
                ) && 
                (
                    this.HelpMessages == input.HelpMessages ||
                    this.HelpMessages != null &&
                    input.HelpMessages != null &&
                    this.HelpMessages.SequenceEqual(input.HelpMessages)
                ) && 
                (
                    this.FallbackMessages == input.FallbackMessages ||
                    this.FallbackMessages != null &&
                    input.FallbackMessages != null &&
                    this.FallbackMessages.SequenceEqual(input.FallbackMessages)
                ) && 
                (
                    this.ExitMessages == input.ExitMessages ||
                    this.ExitMessages != null &&
                    input.ExitMessages != null &&
                    this.ExitMessages.SequenceEqual(input.ExitMessages)
                ) && 
                (
                    this.QuestionAnswers == input.QuestionAnswers ||
                    this.QuestionAnswers != null &&
                    input.QuestionAnswers != null &&
                    this.QuestionAnswers.SequenceEqual(input.QuestionAnswers)
                ) && 
                (
                    this.LatestMessages == input.LatestMessages ||
                    this.LatestMessages != null &&
                    input.LatestMessages != null &&
                    this.LatestMessages.SequenceEqual(input.LatestMessages)
                ) && 
                (
                    this.EventItems == input.EventItems ||
                    this.EventItems != null &&
                    input.EventItems != null &&
                    this.EventItems.SequenceEqual(input.EventItems)
                ) && 
                (
                    this.Recipes == input.Recipes ||
                    this.Recipes != null &&
                    input.Recipes != null &&
                    this.Recipes.SequenceEqual(input.Recipes)
                ) && 
                (
                    this.SimpleChoices == input.SimpleChoices ||
                    this.SimpleChoices != null &&
                    input.SimpleChoices != null &&
                    this.SimpleChoices.SequenceEqual(input.SimpleChoices)
                ) && 
                (
                    this.NumberRanges == input.NumberRanges ||
                    this.NumberRanges != null &&
                    input.NumberRanges != null &&
                    this.NumberRanges.SequenceEqual(input.NumberRanges)
                ) && 
                (
                    this.CustomRequests == input.CustomRequests ||
                    this.CustomRequests != null &&
                    input.CustomRequests != null &&
                    this.CustomRequests.SequenceEqual(input.CustomRequests)
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
                if (this.WelcomeMessages != null)
                    hashCode = hashCode * 59 + this.WelcomeMessages.GetHashCode();
                if (this.HelpMessages != null)
                    hashCode = hashCode * 59 + this.HelpMessages.GetHashCode();
                if (this.FallbackMessages != null)
                    hashCode = hashCode * 59 + this.FallbackMessages.GetHashCode();
                if (this.ExitMessages != null)
                    hashCode = hashCode * 59 + this.ExitMessages.GetHashCode();
                if (this.QuestionAnswers != null)
                    hashCode = hashCode * 59 + this.QuestionAnswers.GetHashCode();
                if (this.LatestMessages != null)
                    hashCode = hashCode * 59 + this.LatestMessages.GetHashCode();
                if (this.EventItems != null)
                    hashCode = hashCode * 59 + this.EventItems.GetHashCode();
                if (this.Recipes != null)
                    hashCode = hashCode * 59 + this.Recipes.GetHashCode();
                if (this.SimpleChoices != null)
                    hashCode = hashCode * 59 + this.SimpleChoices.GetHashCode();
                if (this.NumberRanges != null)
                    hashCode = hashCode * 59 + this.NumberRanges.GetHashCode();
                if (this.CustomRequests != null)
                    hashCode = hashCode * 59 + this.CustomRequests.GetHashCode();
                if (this.ContentItems != null)
                    hashCode = hashCode * 59 + this.ContentItems.GetHashCode();
                return hashCode;
            }
        }

    }
}
