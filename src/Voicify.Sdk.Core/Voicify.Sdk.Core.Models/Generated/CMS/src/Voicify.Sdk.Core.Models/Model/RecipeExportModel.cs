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
    /// RecipeExportModel
    /// </summary>
    [DataContract]
        public partial class RecipeExportModel :  IEquatable<RecipeExportModel>
    {
        /// <summary>
        /// Gets or Sets WebhookChainingType
        /// </summary>
        [DataMember(Name="webhookChainingType", EmitDefaultValue=false)]
        public WebhookChainingType? WebhookChainingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeExportModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationFeatureId">applicationFeatureId.</param>
        /// <param name="title">title.</param>
        /// <param name="hits">hits.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="applicationModuleId">applicationModuleId.</param>
        /// <param name="recipeName">recipeName.</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="description">description.</param>
        /// <param name="mealType">mealType.</param>
        /// <param name="servings">servings.</param>
        /// <param name="totalTime">totalTime.</param>
        /// <param name="calories">calories.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="smallImage">smallImage.</param>
        /// <param name="largeImage">largeImage.</param>
        /// <param name="backgroundImage">backgroundImage.</param>
        /// <param name="audio">audio.</param>
        /// <param name="video">video.</param>
        /// <param name="mediaResponseContainer">mediaResponseContainer.</param>
        /// <param name="content">content.</param>
        /// <param name="ingredients">ingredients.</param>
        /// <param name="steps">steps.</param>
        /// <param name="recipeWebhooks">recipeWebhooks.</param>
        /// <param name="displayTextOverride">displayTextOverride.</param>
        /// <param name="displayTitleOverride">displayTitleOverride.</param>
        /// <param name="mediaResponseContainerId">mediaResponseContainerId.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="createdFromId">createdFromId.</param>
        /// <param name="languages">languages.</param>
        /// <param name="shouldNotSync">shouldNotSync.</param>
        /// <param name="webhookChainingType">webhookChainingType.</param>
        /// <param name="appliedApplicationTemplateFormId">appliedApplicationTemplateFormId.</param>
        public RecipeExportModel(string id = default(string), string applicationId = default(string), string applicationFeatureId = default(string), string title = default(string), int? hits = default(int?), bool? isLive = default(bool?), string applicationModuleId = default(string), string recipeName = default(string), string keywords = default(string), string description = default(string), string mealType = default(string), string servings = default(string), string totalTime = default(string), int? calories = default(int?), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), MediaItemModel smallImage = default(MediaItemModel), MediaItemModel largeImage = default(MediaItemModel), MediaItemModel backgroundImage = default(MediaItemModel), MediaItemModel audio = default(MediaItemModel), MediaItemModel video = default(MediaItemModel), MediaResponseContainerModel mediaResponseContainer = default(MediaResponseContainerModel), string content = default(string), List<RecipeIngredientModel> ingredients = default(List<RecipeIngredientModel>), List<RecipeStepModel> steps = default(List<RecipeStepModel>), List<RecipeWebhookModel> recipeWebhooks = default(List<RecipeWebhookModel>), string displayTextOverride = default(string), string displayTitleOverride = default(string), string mediaResponseContainerId = default(string), bool? requiresParent = default(bool?), bool? isComplete = default(bool?), string createdFromId = default(string), List<LanguageModel> languages = default(List<LanguageModel>), bool? shouldNotSync = default(bool?), WebhookChainingType? webhookChainingType = default(WebhookChainingType?), string appliedApplicationTemplateFormId = default(string))
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.ApplicationFeatureId = applicationFeatureId;
            this.Title = title;
            this.Hits = hits;
            this.IsLive = isLive;
            this.ApplicationModuleId = applicationModuleId;
            this.RecipeName = recipeName;
            this.Keywords = keywords;
            this.Description = description;
            this.MealType = mealType;
            this.Servings = servings;
            this.TotalTime = totalTime;
            this.Calories = calories;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.SmallImage = smallImage;
            this.LargeImage = largeImage;
            this.BackgroundImage = backgroundImage;
            this.Audio = audio;
            this.Video = video;
            this.MediaResponseContainer = mediaResponseContainer;
            this.Content = content;
            this.Ingredients = ingredients;
            this.Steps = steps;
            this.RecipeWebhooks = recipeWebhooks;
            this.DisplayTextOverride = displayTextOverride;
            this.DisplayTitleOverride = displayTitleOverride;
            this.MediaResponseContainerId = mediaResponseContainerId;
            this.RequiresParent = requiresParent;
            this.IsComplete = isComplete;
            this.CreatedFromId = createdFromId;
            this.Languages = languages;
            this.ShouldNotSync = shouldNotSync;
            this.WebhookChainingType = webhookChainingType;
            this.AppliedApplicationTemplateFormId = appliedApplicationTemplateFormId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationFeatureId
        /// </summary>
        [DataMember(Name="applicationFeatureId", EmitDefaultValue=false)]
        public string ApplicationFeatureId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name="hits", EmitDefaultValue=false)]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets IsLive
        /// </summary>
        [DataMember(Name="isLive", EmitDefaultValue=false)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationModuleId
        /// </summary>
        [DataMember(Name="applicationModuleId", EmitDefaultValue=false)]
        public string ApplicationModuleId { get; set; }

        /// <summary>
        /// Gets or Sets RecipeName
        /// </summary>
        [DataMember(Name="recipeName", EmitDefaultValue=false)]
        public string RecipeName { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets MealType
        /// </summary>
        [DataMember(Name="mealType", EmitDefaultValue=false)]
        public string MealType { get; set; }

        /// <summary>
        /// Gets or Sets Servings
        /// </summary>
        [DataMember(Name="servings", EmitDefaultValue=false)]
        public string Servings { get; set; }

        /// <summary>
        /// Gets or Sets TotalTime
        /// </summary>
        [DataMember(Name="totalTime", EmitDefaultValue=false)]
        public string TotalTime { get; set; }

        /// <summary>
        /// Gets or Sets Calories
        /// </summary>
        [DataMember(Name="calories", EmitDefaultValue=false)]
        public int? Calories { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets SmallImage
        /// </summary>
        [DataMember(Name="smallImage", EmitDefaultValue=false)]
        public MediaItemModel SmallImage { get; set; }

        /// <summary>
        /// Gets or Sets LargeImage
        /// </summary>
        [DataMember(Name="largeImage", EmitDefaultValue=false)]
        public MediaItemModel LargeImage { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name="backgroundImage", EmitDefaultValue=false)]
        public MediaItemModel BackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name="audio", EmitDefaultValue=false)]
        public MediaItemModel Audio { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public MediaItemModel Video { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponseContainer
        /// </summary>
        [DataMember(Name="mediaResponseContainer", EmitDefaultValue=false)]
        public MediaResponseContainerModel MediaResponseContainer { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>
        [DataMember(Name="ingredients", EmitDefaultValue=false)]
        public List<RecipeIngredientModel> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<RecipeStepModel> Steps { get; set; }

        /// <summary>
        /// Gets or Sets RecipeWebhooks
        /// </summary>
        [DataMember(Name="recipeWebhooks", EmitDefaultValue=false)]
        public List<RecipeWebhookModel> RecipeWebhooks { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTextOverride
        /// </summary>
        [DataMember(Name="displayTextOverride", EmitDefaultValue=false)]
        public string DisplayTextOverride { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTitleOverride
        /// </summary>
        [DataMember(Name="displayTitleOverride", EmitDefaultValue=false)]
        public string DisplayTitleOverride { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponseContainerId
        /// </summary>
        [DataMember(Name="mediaResponseContainerId", EmitDefaultValue=false)]
        public string MediaResponseContainerId { get; set; }

        /// <summary>
        /// Gets or Sets RequiresParent
        /// </summary>
        [DataMember(Name="requiresParent", EmitDefaultValue=false)]
        public bool? RequiresParent { get; set; }

        /// <summary>
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name="isComplete", EmitDefaultValue=false)]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguageModel> Languages { get; set; }

        /// <summary>
        /// Gets or Sets ShouldNotSync
        /// </summary>
        [DataMember(Name="shouldNotSync", EmitDefaultValue=false)]
        public bool? ShouldNotSync { get; set; }


        /// <summary>
        /// Gets or Sets AppliedApplicationTemplateFormId
        /// </summary>
        [DataMember(Name="appliedApplicationTemplateFormId", EmitDefaultValue=false)]
        public string AppliedApplicationTemplateFormId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipeExportModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  ApplicationModuleId: ").Append(ApplicationModuleId).Append("\n");
            sb.Append("  RecipeName: ").Append(RecipeName).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MealType: ").Append(MealType).Append("\n");
            sb.Append("  Servings: ").Append(Servings).Append("\n");
            sb.Append("  TotalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  Calories: ").Append(Calories).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  SmallImage: ").Append(SmallImage).Append("\n");
            sb.Append("  LargeImage: ").Append(LargeImage).Append("\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  MediaResponseContainer: ").Append(MediaResponseContainer).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  RecipeWebhooks: ").Append(RecipeWebhooks).Append("\n");
            sb.Append("  DisplayTextOverride: ").Append(DisplayTextOverride).Append("\n");
            sb.Append("  DisplayTitleOverride: ").Append(DisplayTitleOverride).Append("\n");
            sb.Append("  MediaResponseContainerId: ").Append(MediaResponseContainerId).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  ShouldNotSync: ").Append(ShouldNotSync).Append("\n");
            sb.Append("  WebhookChainingType: ").Append(WebhookChainingType).Append("\n");
            sb.Append("  AppliedApplicationTemplateFormId: ").Append(AppliedApplicationTemplateFormId).Append("\n");
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
            return this.Equals(input as RecipeExportModel);
        }

        /// <summary>
        /// Returns true if RecipeExportModel instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipeExportModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipeExportModel input)
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
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationFeatureId == input.ApplicationFeatureId ||
                    (this.ApplicationFeatureId != null &&
                    this.ApplicationFeatureId.Equals(input.ApplicationFeatureId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Hits == input.Hits ||
                    (this.Hits != null &&
                    this.Hits.Equals(input.Hits))
                ) && 
                (
                    this.IsLive == input.IsLive ||
                    (this.IsLive != null &&
                    this.IsLive.Equals(input.IsLive))
                ) && 
                (
                    this.ApplicationModuleId == input.ApplicationModuleId ||
                    (this.ApplicationModuleId != null &&
                    this.ApplicationModuleId.Equals(input.ApplicationModuleId))
                ) && 
                (
                    this.RecipeName == input.RecipeName ||
                    (this.RecipeName != null &&
                    this.RecipeName.Equals(input.RecipeName))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MealType == input.MealType ||
                    (this.MealType != null &&
                    this.MealType.Equals(input.MealType))
                ) && 
                (
                    this.Servings == input.Servings ||
                    (this.Servings != null &&
                    this.Servings.Equals(input.Servings))
                ) && 
                (
                    this.TotalTime == input.TotalTime ||
                    (this.TotalTime != null &&
                    this.TotalTime.Equals(input.TotalTime))
                ) && 
                (
                    this.Calories == input.Calories ||
                    (this.Calories != null &&
                    this.Calories.Equals(input.Calories))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.SmallImage == input.SmallImage ||
                    (this.SmallImage != null &&
                    this.SmallImage.Equals(input.SmallImage))
                ) && 
                (
                    this.LargeImage == input.LargeImage ||
                    (this.LargeImage != null &&
                    this.LargeImage.Equals(input.LargeImage))
                ) && 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.MediaResponseContainer == input.MediaResponseContainer ||
                    (this.MediaResponseContainer != null &&
                    this.MediaResponseContainer.Equals(input.MediaResponseContainer))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Ingredients == input.Ingredients ||
                    this.Ingredients != null &&
                    input.Ingredients != null &&
                    this.Ingredients.SequenceEqual(input.Ingredients)
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.RecipeWebhooks == input.RecipeWebhooks ||
                    this.RecipeWebhooks != null &&
                    input.RecipeWebhooks != null &&
                    this.RecipeWebhooks.SequenceEqual(input.RecipeWebhooks)
                ) && 
                (
                    this.DisplayTextOverride == input.DisplayTextOverride ||
                    (this.DisplayTextOverride != null &&
                    this.DisplayTextOverride.Equals(input.DisplayTextOverride))
                ) && 
                (
                    this.DisplayTitleOverride == input.DisplayTitleOverride ||
                    (this.DisplayTitleOverride != null &&
                    this.DisplayTitleOverride.Equals(input.DisplayTitleOverride))
                ) && 
                (
                    this.MediaResponseContainerId == input.MediaResponseContainerId ||
                    (this.MediaResponseContainerId != null &&
                    this.MediaResponseContainerId.Equals(input.MediaResponseContainerId))
                ) && 
                (
                    this.RequiresParent == input.RequiresParent ||
                    (this.RequiresParent != null &&
                    this.RequiresParent.Equals(input.RequiresParent))
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    (this.IsComplete != null &&
                    this.IsComplete.Equals(input.IsComplete))
                ) && 
                (
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.ShouldNotSync == input.ShouldNotSync ||
                    (this.ShouldNotSync != null &&
                    this.ShouldNotSync.Equals(input.ShouldNotSync))
                ) && 
                (
                    this.WebhookChainingType == input.WebhookChainingType ||
                    (this.WebhookChainingType != null &&
                    this.WebhookChainingType.Equals(input.WebhookChainingType))
                ) && 
                (
                    this.AppliedApplicationTemplateFormId == input.AppliedApplicationTemplateFormId ||
                    (this.AppliedApplicationTemplateFormId != null &&
                    this.AppliedApplicationTemplateFormId.Equals(input.AppliedApplicationTemplateFormId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationFeatureId != null)
                    hashCode = hashCode * 59 + this.ApplicationFeatureId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                if (this.ApplicationModuleId != null)
                    hashCode = hashCode * 59 + this.ApplicationModuleId.GetHashCode();
                if (this.RecipeName != null)
                    hashCode = hashCode * 59 + this.RecipeName.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MealType != null)
                    hashCode = hashCode * 59 + this.MealType.GetHashCode();
                if (this.Servings != null)
                    hashCode = hashCode * 59 + this.Servings.GetHashCode();
                if (this.TotalTime != null)
                    hashCode = hashCode * 59 + this.TotalTime.GetHashCode();
                if (this.Calories != null)
                    hashCode = hashCode * 59 + this.Calories.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.SmallImage != null)
                    hashCode = hashCode * 59 + this.SmallImage.GetHashCode();
                if (this.LargeImage != null)
                    hashCode = hashCode * 59 + this.LargeImage.GetHashCode();
                if (this.BackgroundImage != null)
                    hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.MediaResponseContainer != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainer.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Ingredients != null)
                    hashCode = hashCode * 59 + this.Ingredients.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.RecipeWebhooks != null)
                    hashCode = hashCode * 59 + this.RecipeWebhooks.GetHashCode();
                if (this.DisplayTextOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTextOverride.GetHashCode();
                if (this.DisplayTitleOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTitleOverride.GetHashCode();
                if (this.MediaResponseContainerId != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainerId.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.ShouldNotSync != null)
                    hashCode = hashCode * 59 + this.ShouldNotSync.GetHashCode();
                if (this.WebhookChainingType != null)
                    hashCode = hashCode * 59 + this.WebhookChainingType.GetHashCode();
                if (this.AppliedApplicationTemplateFormId != null)
                    hashCode = hashCode * 59 + this.AppliedApplicationTemplateFormId.GetHashCode();
                return hashCode;
            }
        }

    }
}
