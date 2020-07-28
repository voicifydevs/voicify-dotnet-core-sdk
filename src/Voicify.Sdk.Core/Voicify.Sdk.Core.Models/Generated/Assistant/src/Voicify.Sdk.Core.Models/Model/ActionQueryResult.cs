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
    /// ActionQueryResult
    /// </summary>
    [DataContract]
    public partial class ActionQueryResult :  IEquatable<ActionQueryResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionQueryResult" /> class.
        /// </summary>
        /// <param name="queryText">queryText.</param>
        /// <param name="action">action.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="allRequiredParamsPresent">allRequiredParamsPresent.</param>
        /// <param name="fulfillmentText">fulfillmentText.</param>
        /// <param name="fulfillmentMessages">fulfillmentMessages.</param>
        /// <param name="outputContexts">outputContexts.</param>
        /// <param name="intent">intent.</param>
        /// <param name="intentDetectionConfidence">intentDetectionConfidence.</param>
        /// <param name="diagnosticInfo">diagnosticInfo.</param>
        /// <param name="languageCode">languageCode.</param>
        public ActionQueryResult(string queryText = default(string), string action = default(string), Dictionary<string, string> parameters = default(Dictionary<string, string>), bool? allRequiredParamsPresent = default(bool?), string fulfillmentText = default(string), List<FulfillmentMessage> fulfillmentMessages = default(List<FulfillmentMessage>), List<ActionOutputContext> outputContexts = default(List<ActionOutputContext>), ActionIntent intent = default(ActionIntent), double? intentDetectionConfidence = default(double?), Object diagnosticInfo = default(Object), string languageCode = default(string))
        {
            this.QueryText = queryText;
            this.Action = action;
            this.Parameters = parameters;
            this.AllRequiredParamsPresent = allRequiredParamsPresent;
            this.FulfillmentText = fulfillmentText;
            this.FulfillmentMessages = fulfillmentMessages;
            this.OutputContexts = outputContexts;
            this.Intent = intent;
            this.IntentDetectionConfidence = intentDetectionConfidence;
            this.DiagnosticInfo = diagnosticInfo;
            this.LanguageCode = languageCode;
        }
        
        /// <summary>
        /// Gets or Sets QueryText
        /// </summary>
        [DataMember(Name="queryText", EmitDefaultValue=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets AllRequiredParamsPresent
        /// </summary>
        [DataMember(Name="allRequiredParamsPresent", EmitDefaultValue=false)]
        public bool? AllRequiredParamsPresent { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentText
        /// </summary>
        [DataMember(Name="fulfillmentText", EmitDefaultValue=false)]
        public string FulfillmentText { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentMessages
        /// </summary>
        [DataMember(Name="fulfillmentMessages", EmitDefaultValue=false)]
        public List<FulfillmentMessage> FulfillmentMessages { get; set; }

        /// <summary>
        /// Gets or Sets OutputContexts
        /// </summary>
        [DataMember(Name="outputContexts", EmitDefaultValue=false)]
        public List<ActionOutputContext> OutputContexts { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [DataMember(Name="intent", EmitDefaultValue=false)]
        public ActionIntent Intent { get; set; }

        /// <summary>
        /// Gets or Sets IntentDetectionConfidence
        /// </summary>
        [DataMember(Name="intentDetectionConfidence", EmitDefaultValue=false)]
        public double? IntentDetectionConfidence { get; set; }

        /// <summary>
        /// Gets or Sets DiagnosticInfo
        /// </summary>
        [DataMember(Name="diagnosticInfo", EmitDefaultValue=false)]
        public Object DiagnosticInfo { get; set; }

        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionQueryResult {\n");
            sb.Append("  QueryText: ").Append(QueryText).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  AllRequiredParamsPresent: ").Append(AllRequiredParamsPresent).Append("\n");
            sb.Append("  FulfillmentText: ").Append(FulfillmentText).Append("\n");
            sb.Append("  FulfillmentMessages: ").Append(FulfillmentMessages).Append("\n");
            sb.Append("  OutputContexts: ").Append(OutputContexts).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  IntentDetectionConfidence: ").Append(IntentDetectionConfidence).Append("\n");
            sb.Append("  DiagnosticInfo: ").Append(DiagnosticInfo).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
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
            return this.Equals(input as ActionQueryResult);
        }

        /// <summary>
        /// Returns true if ActionQueryResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionQueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionQueryResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueryText == input.QueryText ||
                    (this.QueryText != null &&
                    this.QueryText.Equals(input.QueryText))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.AllRequiredParamsPresent == input.AllRequiredParamsPresent ||
                    (this.AllRequiredParamsPresent != null &&
                    this.AllRequiredParamsPresent.Equals(input.AllRequiredParamsPresent))
                ) && 
                (
                    this.FulfillmentText == input.FulfillmentText ||
                    (this.FulfillmentText != null &&
                    this.FulfillmentText.Equals(input.FulfillmentText))
                ) && 
                (
                    this.FulfillmentMessages == input.FulfillmentMessages ||
                    this.FulfillmentMessages != null &&
                    this.FulfillmentMessages.SequenceEqual(input.FulfillmentMessages)
                ) && 
                (
                    this.OutputContexts == input.OutputContexts ||
                    this.OutputContexts != null &&
                    this.OutputContexts.SequenceEqual(input.OutputContexts)
                ) && 
                (
                    this.Intent == input.Intent ||
                    (this.Intent != null &&
                    this.Intent.Equals(input.Intent))
                ) && 
                (
                    this.IntentDetectionConfidence == input.IntentDetectionConfidence ||
                    (this.IntentDetectionConfidence != null &&
                    this.IntentDetectionConfidence.Equals(input.IntentDetectionConfidence))
                ) && 
                (
                    this.DiagnosticInfo == input.DiagnosticInfo ||
                    (this.DiagnosticInfo != null &&
                    this.DiagnosticInfo.Equals(input.DiagnosticInfo))
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
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
                if (this.QueryText != null)
                    hashCode = hashCode * 59 + this.QueryText.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.AllRequiredParamsPresent != null)
                    hashCode = hashCode * 59 + this.AllRequiredParamsPresent.GetHashCode();
                if (this.FulfillmentText != null)
                    hashCode = hashCode * 59 + this.FulfillmentText.GetHashCode();
                if (this.FulfillmentMessages != null)
                    hashCode = hashCode * 59 + this.FulfillmentMessages.GetHashCode();
                if (this.OutputContexts != null)
                    hashCode = hashCode * 59 + this.OutputContexts.GetHashCode();
                if (this.Intent != null)
                    hashCode = hashCode * 59 + this.Intent.GetHashCode();
                if (this.IntentDetectionConfidence != null)
                    hashCode = hashCode * 59 + this.IntentDetectionConfidence.GetHashCode();
                if (this.DiagnosticInfo != null)
                    hashCode = hashCode * 59 + this.DiagnosticInfo.GetHashCode();
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
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
