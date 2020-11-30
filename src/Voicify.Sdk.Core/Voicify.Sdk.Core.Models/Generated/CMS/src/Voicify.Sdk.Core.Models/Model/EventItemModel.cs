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
    /// EventItemModel
    /// </summary>
    [DataContract]
    public partial class EventItemModel :  IEquatable<EventItemModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventItemModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationFeatureId">applicationFeatureId.</param>
        /// <param name="title">title.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="applicationModuleId">applicationModuleId.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="description">description.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="address">address.</param>
        /// <param name="status">status.</param>
        /// <param name="eventStartDate">eventStartDate.</param>
        /// <param name="eventEndDate">eventEndDate.</param>
        /// <param name="categories">categories.</param>
        /// <param name="responses">responses.</param>
        /// <param name="eventItemWebhooks">eventItemWebhooks.</param>
        /// <param name="hits">hits.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="languages">languages.</param>
        /// <param name="createdFromId">createdFromId.</param>
        /// <param name="shouldNotSync">shouldNotSync.</param>
        public EventItemModel(string id = default(string), string applicationId = default(string), string applicationFeatureId = default(string), string title = default(string), bool? isLive = default(bool?), string applicationModuleId = default(string), string eventName = default(string), string description = default(string), string locationName = default(string), string ownerName = default(string), string address = default(string), string status = default(string), DateTime? eventStartDate = default(DateTime?), DateTime? eventEndDate = default(DateTime?), List<EventCategoryModel> categories = default(List<EventCategoryModel>), List<EventResponseModel> responses = default(List<EventResponseModel>), List<EventItemWebhookModel> eventItemWebhooks = default(List<EventItemWebhookModel>), int? hits = default(int?), DateTime? modifiedDate = default(DateTime?), DateTime? createdDate = default(DateTime?), bool? requiresParent = default(bool?), bool? isComplete = default(bool?), List<LanguageModel> languages = default(List<LanguageModel>), string createdFromId = default(string), bool? shouldNotSync = default(bool?))
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.ApplicationFeatureId = applicationFeatureId;
            this.Title = title;
            this.IsLive = isLive;
            this.ApplicationModuleId = applicationModuleId;
            this.EventName = eventName;
            this.Description = description;
            this.LocationName = locationName;
            this.OwnerName = ownerName;
            this.Address = address;
            this.Status = status;
            this.EventStartDate = eventStartDate;
            this.EventEndDate = eventEndDate;
            this.Categories = categories;
            this.Responses = responses;
            this.EventItemWebhooks = eventItemWebhooks;
            this.Hits = hits;
            this.ModifiedDate = modifiedDate;
            this.CreatedDate = createdDate;
            this.RequiresParent = requiresParent;
            this.IsComplete = isComplete;
            this.Languages = languages;
            this.CreatedFromId = createdFromId;
            this.ShouldNotSync = shouldNotSync;
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
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="locationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name="ownerName", EmitDefaultValue=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets EventStartDate
        /// </summary>
        [DataMember(Name="eventStartDate", EmitDefaultValue=false)]
        public DateTime? EventStartDate { get; set; }

        /// <summary>
        /// Gets or Sets EventEndDate
        /// </summary>
        [DataMember(Name="eventEndDate", EmitDefaultValue=false)]
        public DateTime? EventEndDate { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<EventCategoryModel> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<EventResponseModel> Responses { get; set; }

        /// <summary>
        /// Gets or Sets EventItemWebhooks
        /// </summary>
        [DataMember(Name="eventItemWebhooks", EmitDefaultValue=false)]
        public List<EventItemWebhookModel> EventItemWebhooks { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name="hits", EmitDefaultValue=false)]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

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
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguageModel> Languages { get; set; }

        /// <summary>
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Gets or Sets ShouldNotSync
        /// </summary>
        [DataMember(Name="shouldNotSync", EmitDefaultValue=false)]
        public bool? ShouldNotSync { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  ApplicationModuleId: ").Append(ApplicationModuleId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventStartDate: ").Append(EventStartDate).Append("\n");
            sb.Append("  EventEndDate: ").Append(EventEndDate).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  EventItemWebhooks: ").Append(EventItemWebhooks).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
            sb.Append("  ShouldNotSync: ").Append(ShouldNotSync).Append("\n");
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
            return this.Equals(input as EventItemModel);
        }

        /// <summary>
        /// Returns true if EventItemModel instances are equal
        /// </summary>
        /// <param name="input">Instance of EventItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventItemModel input)
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
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EventStartDate == input.EventStartDate ||
                    (this.EventStartDate != null &&
                    this.EventStartDate.Equals(input.EventStartDate))
                ) && 
                (
                    this.EventEndDate == input.EventEndDate ||
                    (this.EventEndDate != null &&
                    this.EventEndDate.Equals(input.EventEndDate))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) && 
                (
                    this.EventItemWebhooks == input.EventItemWebhooks ||
                    this.EventItemWebhooks != null &&
                    this.EventItemWebhooks.SequenceEqual(input.EventItemWebhooks)
                ) && 
                (
                    this.Hits == input.Hits ||
                    (this.Hits != null &&
                    this.Hits.Equals(input.Hits))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
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
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
                ) && 
                (
                    this.ShouldNotSync == input.ShouldNotSync ||
                    (this.ShouldNotSync != null &&
                    this.ShouldNotSync.Equals(input.ShouldNotSync))
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
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                if (this.ApplicationModuleId != null)
                    hashCode = hashCode * 59 + this.ApplicationModuleId.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EventStartDate != null)
                    hashCode = hashCode * 59 + this.EventStartDate.GetHashCode();
                if (this.EventEndDate != null)
                    hashCode = hashCode * 59 + this.EventEndDate.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                if (this.EventItemWebhooks != null)
                    hashCode = hashCode * 59 + this.EventItemWebhooks.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
                if (this.ShouldNotSync != null)
                    hashCode = hashCode * 59 + this.ShouldNotSync.GetHashCode();
                return hashCode;
            }
        }

    }

}
