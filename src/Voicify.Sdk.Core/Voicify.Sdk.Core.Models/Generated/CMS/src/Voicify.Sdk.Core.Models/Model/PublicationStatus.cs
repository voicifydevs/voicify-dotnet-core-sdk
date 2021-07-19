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
    /// Defines PublicationStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum PublicationStatus
    {
        /// <summary>
        /// Enum DEVELOPMENT for value: DEVELOPMENT
        /// </summary>
        [EnumMember(Value = "DEVELOPMENT")]
        DEVELOPMENT = 0,
        /// <summary>
        /// Enum CERTIFICATION for value: CERTIFICATION
        /// </summary>
        [EnumMember(Value = "CERTIFICATION")]
        CERTIFICATION = 1,
        /// <summary>
        /// Enum PUBLISHED for value: PUBLISHED
        /// </summary>
        [EnumMember(Value = "PUBLISHED")]
        PUBLISHED = 2,
        /// <summary>
        /// Enum SUPPRESSED for value: SUPPRESSED
        /// </summary>
        [EnumMember(Value = "SUPPRESSED")]
        SUPPRESSED = 3,
        /// <summary>
        /// Enum PULLED for value: PULLED
        /// </summary>
        [EnumMember(Value = "PULLED")]
        PULLED = 4,
        /// <summary>
        /// Enum HIDDEN for value: HIDDEN
        /// </summary>
        [EnumMember(Value = "HIDDEN")]
        HIDDEN = 5,
        /// <summary>
        /// Enum REMOVED for value: REMOVED
        /// </summary>
        [EnumMember(Value = "REMOVED")]
        REMOVED = 7    }
}
