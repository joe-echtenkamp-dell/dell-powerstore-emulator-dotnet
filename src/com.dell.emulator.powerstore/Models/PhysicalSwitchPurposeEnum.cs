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
        /// Physical switch purpose in network. Possible purposes are:   * Data_and_Management - Physical switch for all data and management networks.   * Management_Only - Physical switch for management network only. 
        /// </summary>
        /// <value>Physical switch purpose in network. Possible purposes are:   * Data_and_Management - Physical switch for all data and management networks.   * Management_Only - Physical switch for management network only. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PhysicalSwitchPurposeEnum
        {
            
            /// <summary>
            /// Enum DataAndManagementEnum for Data_and_Management
            /// </summary>
            [EnumMember(Value = "Data_and_Management")]
            DataAndManagementEnum = 1,
            
            /// <summary>
            /// Enum ManagementOnlyEnum for Management_Only
            /// </summary>
            [EnumMember(Value = "Management_Only")]
            ManagementOnlyEnum = 2
        }
}
