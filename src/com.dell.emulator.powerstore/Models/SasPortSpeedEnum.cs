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
        /// SAS port transmission speed. * 3_Gbps- 3 Gigabits per second * 6_Gbps- 6 Gigabits per second * 12_Gbps- 12 Gigabits per second 
        /// </summary>
        /// <value>SAS port transmission speed. * 3_Gbps- 3 Gigabits per second * 6_Gbps- 6 Gigabits per second * 12_Gbps- 12 Gigabits per second </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SasPortSpeedEnum
        {
            
            /// <summary>
            /// Enum _3GbpsEnum for 3_Gbps
            /// </summary>
            [EnumMember(Value = "3_Gbps")]
            _3GbpsEnum = 1,
            
            /// <summary>
            /// Enum _6GbpsEnum for 6_Gbps
            /// </summary>
            [EnumMember(Value = "6_Gbps")]
            _6GbpsEnum = 2,
            
            /// <summary>
            /// Enum _12GbpsEnum for 12_Gbps
            /// </summary>
            [EnumMember(Value = "12_Gbps")]
            _12GbpsEnum = 3
        }
}
