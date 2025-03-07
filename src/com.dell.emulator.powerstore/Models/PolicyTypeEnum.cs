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
        /// Supported policy types.  * Protection - A protection policy for associating with volumes or volume groups, consisting of snapshot and replication rules.  * Performance - A performance policy for associating with volumes, consisting of performance rules.  * QoS - A performance policy for associating with volumes or volume groups, consisting of quality of service rules. 
        /// </summary>
        /// <value>Supported policy types.  * Protection - A protection policy for associating with volumes or volume groups, consisting of snapshot and replication rules.  * Performance - A performance policy for associating with volumes, consisting of performance rules.  * QoS - A performance policy for associating with volumes or volume groups, consisting of quality of service rules. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PolicyTypeEnum
        {
            
            /// <summary>
            /// Enum ProtectionEnum for Protection
            /// </summary>
            [EnumMember(Value = "Protection")]
            ProtectionEnum = 1,
            
            /// <summary>
            /// Enum PerformanceEnum for Performance
            /// </summary>
            [EnumMember(Value = "Performance")]
            PerformanceEnum = 2,
            
            /// <summary>
            /// Enum QoSEnum for QoS
            /// </summary>
            [EnumMember(Value = "QoS")]
            QoSEnum = 3
        }
}
