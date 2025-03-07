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
        /// Supported speed. Available on the SFP hardware type. Current supported speeds are:  * Auto - Automatically selected link speed  * 4_Gbps - 4 Gigabits per second  * 8_Gbps - 8 Gigabits per second  * 16_Gbps - 16 Gigabits per second  * 32_Gbps - 32 Gigabits per second  * 10_Mbps - 10 Megabits per second  * 100_Mbps - 100 Megabits per second  * 1_Gbps - 1 Gigabit per second  * 10_Gbps - 10 Gigabits per second  * 25_Gbps - 25 Gigabits per second  * 40_Gbps - 40 Gigabits per second  * 100_Gbps - 100 Gigabits per second  * 3_Gbps - 3 Gigabits per second  * 6_Gbps - 6 Gigabits per second  * 12_Gbps - 12 Gigabits per second  Values was added in 3.0.0.0: 100_Gbps. Values was added in 3.6.0.0: 3_Gbps, 6_Gbps, 12_Gbps.
        /// </summary>
        /// <value>Supported speed. Available on the SFP hardware type. Current supported speeds are:  * Auto - Automatically selected link speed  * 4_Gbps - 4 Gigabits per second  * 8_Gbps - 8 Gigabits per second  * 16_Gbps - 16 Gigabits per second  * 32_Gbps - 32 Gigabits per second  * 10_Mbps - 10 Megabits per second  * 100_Mbps - 100 Megabits per second  * 1_Gbps - 1 Gigabit per second  * 10_Gbps - 10 Gigabits per second  * 25_Gbps - 25 Gigabits per second  * 40_Gbps - 40 Gigabits per second  * 100_Gbps - 100 Gigabits per second  * 3_Gbps - 3 Gigabits per second  * 6_Gbps - 6 Gigabits per second  * 12_Gbps - 12 Gigabits per second  Values was added in 3.0.0.0: 100_Gbps. Values was added in 3.6.0.0: 3_Gbps, 6_Gbps, 12_Gbps.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HardwareSFPSpeedEnum
        {
            
            /// <summary>
            /// Enum AutoEnum for Auto
            /// </summary>
            [EnumMember(Value = "Auto")]
            AutoEnum = 1,
            
            /// <summary>
            /// Enum _4GbpsEnum for 4_Gbps
            /// </summary>
            [EnumMember(Value = "4_Gbps")]
            _4GbpsEnum = 2,
            
            /// <summary>
            /// Enum _8GbpsEnum for 8_Gbps
            /// </summary>
            [EnumMember(Value = "8_Gbps")]
            _8GbpsEnum = 3,
            
            /// <summary>
            /// Enum _16GbpsEnum for 16_Gbps
            /// </summary>
            [EnumMember(Value = "16_Gbps")]
            _16GbpsEnum = 4,
            
            /// <summary>
            /// Enum _32GbpsEnum for 32_Gbps
            /// </summary>
            [EnumMember(Value = "32_Gbps")]
            _32GbpsEnum = 5,
            
            /// <summary>
            /// Enum _10MbpsEnum for 10_Mbps
            /// </summary>
            [EnumMember(Value = "10_Mbps")]
            _10MbpsEnum = 6,
            
            /// <summary>
            /// Enum _100MbpsEnum for 100_Mbps
            /// </summary>
            [EnumMember(Value = "100_Mbps")]
            _100MbpsEnum = 7,
            
            /// <summary>
            /// Enum _1GbpsEnum for 1_Gbps
            /// </summary>
            [EnumMember(Value = "1_Gbps")]
            _1GbpsEnum = 8,
            
            /// <summary>
            /// Enum _10GbpsEnum for 10_Gbps
            /// </summary>
            [EnumMember(Value = "10_Gbps")]
            _10GbpsEnum = 9,
            
            /// <summary>
            /// Enum _25GbpsEnum for 25_Gbps
            /// </summary>
            [EnumMember(Value = "25_Gbps")]
            _25GbpsEnum = 10,
            
            /// <summary>
            /// Enum _40GbpsEnum for 40_Gbps
            /// </summary>
            [EnumMember(Value = "40_Gbps")]
            _40GbpsEnum = 11,
            
            /// <summary>
            /// Enum _100GbpsEnum for 100_Gbps
            /// </summary>
            [EnumMember(Value = "100_Gbps")]
            _100GbpsEnum = 12,
            
            /// <summary>
            /// Enum _3GbpsEnum for 3_Gbps
            /// </summary>
            [EnumMember(Value = "3_Gbps")]
            _3GbpsEnum = 13,
            
            /// <summary>
            /// Enum _6GbpsEnum for 6_Gbps
            /// </summary>
            [EnumMember(Value = "6_Gbps")]
            _6GbpsEnum = 14,
            
            /// <summary>
            /// Enum _12GbpsEnum for 12_Gbps
            /// </summary>
            [EnumMember(Value = "12_Gbps")]
            _12GbpsEnum = 15
        }
}
