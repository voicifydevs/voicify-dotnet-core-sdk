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
    /// UserTermAgreementModel
    /// </summary>
    [DataContract]
    public partial class UserTermAgreementModel :  IEquatable<UserTermAgreementModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTermAgreementModel" /> class.
        /// </summary>
        /// <param name="userTerms">userTerms.</param>
        /// <param name="hasAgreedToLatest">hasAgreedToLatest.</param>
        /// <param name="latestTerm">latestTerm.</param>
        public UserTermAgreementModel(List<UserTermModel> userTerms = default(List<UserTermModel>), bool? hasAgreedToLatest = default(bool?), TermModel latestTerm = default(TermModel))
        {
            this.UserTerms = userTerms;
            this.HasAgreedToLatest = hasAgreedToLatest;
            this.LatestTerm = latestTerm;
        }
        
        /// <summary>
        /// Gets or Sets UserTerms
        /// </summary>
        [DataMember(Name="userTerms", EmitDefaultValue=false)]
        public List<UserTermModel> UserTerms { get; set; }

        /// <summary>
        /// Gets or Sets HasAgreedToLatest
        /// </summary>
        [DataMember(Name="hasAgreedToLatest", EmitDefaultValue=false)]
        public bool? HasAgreedToLatest { get; set; }

        /// <summary>
        /// Gets or Sets LatestTerm
        /// </summary>
        [DataMember(Name="latestTerm", EmitDefaultValue=false)]
        public TermModel LatestTerm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserTermAgreementModel {\n");
            sb.Append("  UserTerms: ").Append(UserTerms).Append("\n");
            sb.Append("  HasAgreedToLatest: ").Append(HasAgreedToLatest).Append("\n");
            sb.Append("  LatestTerm: ").Append(LatestTerm).Append("\n");
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
            return this.Equals(input as UserTermAgreementModel);
        }

        /// <summary>
        /// Returns true if UserTermAgreementModel instances are equal
        /// </summary>
        /// <param name="input">Instance of UserTermAgreementModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTermAgreementModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserTerms == input.UserTerms ||
                    this.UserTerms != null &&
                    this.UserTerms.SequenceEqual(input.UserTerms)
                ) && 
                (
                    this.HasAgreedToLatest == input.HasAgreedToLatest ||
                    (this.HasAgreedToLatest != null &&
                    this.HasAgreedToLatest.Equals(input.HasAgreedToLatest))
                ) && 
                (
                    this.LatestTerm == input.LatestTerm ||
                    (this.LatestTerm != null &&
                    this.LatestTerm.Equals(input.LatestTerm))
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
                if (this.UserTerms != null)
                    hashCode = hashCode * 59 + this.UserTerms.GetHashCode();
                if (this.HasAgreedToLatest != null)
                    hashCode = hashCode * 59 + this.HasAgreedToLatest.GetHashCode();
                if (this.LatestTerm != null)
                    hashCode = hashCode * 59 + this.LatestTerm.GetHashCode();
                return hashCode;
            }
        }

    }

}
