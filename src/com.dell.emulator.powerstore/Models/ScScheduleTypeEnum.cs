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
        /// Available SC snapshot schedule types. Valid values are:  * Once - Take snapshot only once.  * Daily- Take snapshot hourly.  * Weekly - Take snapshot on a weekly basis.  * Monthly - Take snapshot on a monthly basis.  * Unknown - SC schedule type is unknown to PowerStore. 
        /// </summary>
        /// <value>Available SC snapshot schedule types. Valid values are:  * Once - Take snapshot only once.  * Daily- Take snapshot hourly.  * Weekly - Take snapshot on a weekly basis.  * Monthly - Take snapshot on a monthly basis.  * Unknown - SC schedule type is unknown to PowerStore. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ScScheduleTypeEnum
        {
            
            /// <summary>
            /// Enum OnceEnum for Once
            /// </summary>
            [EnumMember(Value = "Once")]
            OnceEnum = 1,
            
            /// <summary>
            /// Enum DailyEnum for Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            DailyEnum = 2,
            
            /// <summary>
            /// Enum WeeklyEnum for Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            WeeklyEnum = 3,
            
            /// <summary>
            /// Enum MonthlyEnum for Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            MonthlyEnum = 4,
            
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 5
        }
}
