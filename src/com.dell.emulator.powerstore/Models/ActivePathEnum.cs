/*
 * PowerStore REST API
 *
 * Storage cluster REST API definition. ( For \"Try It Out\", use the cluster management IP address to load this swaggerui interface. )
 *
 * OpenAPI spec version: 4.0.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Dell.Emulator.Powerstore.Models
{ 
        /// <summary>
        /// Active path of the import host volume. Valid values are:  * None - No active path available.  * Source - Current IO path is set to source.  * Destination - Current IO path is set to destination. 
        /// </summary>
        /// <value>Active path of the import host volume. Valid values are:  * None - No active path available.  * Source - Current IO path is set to source.  * Destination - Current IO path is set to destination. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ActivePathEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum SourceEnum for Source
            /// </summary>
            [EnumMember(Value = "Source")]
            SourceEnum = 2,
            
            /// <summary>
            /// Enum DestinationEnum for Destination
            /// </summary>
            [EnumMember(Value = "Destination")]
            DestinationEnum = 3
        }
}
