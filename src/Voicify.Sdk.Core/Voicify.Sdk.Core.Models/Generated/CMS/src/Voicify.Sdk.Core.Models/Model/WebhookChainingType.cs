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
    /// Defines WebhookChainingType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum WebhookChainingType
    {
        /// <summary>
        /// Enum NoChaining for value: NoChaining
        /// </summary>
        [EnumMember(Value = "NoChaining")]
        NoChaining = 0,
        /// <summary>
        /// Enum InstanceLevelChaining for value: InstanceLevelChaining
        /// </summary>
        [EnumMember(Value = "InstanceLevelChaining")]
        InstanceLevelChaining = 2    }
}
