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
        /// Default access level for all hosts that can access the Export. * No_Access- Deny access to the Export for the hosts. * Read_Only- Allow read only access to the Export for the hosts. * Read_Write- Allow read write access to the Export for the hosts. * Root - Allow read write access to the Export for the hosts. Allow access to the Export for root user. * Read_Only_Root- Allow read only root access to the Export for the hosts. 
        /// </summary>
        /// <value>Default access level for all hosts that can access the Export. * No_Access- Deny access to the Export for the hosts. * Read_Only- Allow read only access to the Export for the hosts. * Read_Write- Allow read write access to the Export for the hosts. * Root - Allow read write access to the Export for the hosts. Allow access to the Export for root user. * Read_Only_Root- Allow read only root access to the Export for the hosts. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NFSExportDefaultAccessEnum
        {
            
            /// <summary>
            /// Enum NoAccessEnum for No_Access
            /// </summary>
            [EnumMember(Value = "No_Access")]
            NoAccessEnum = 1,
            
            /// <summary>
            /// Enum ReadOnlyEnum for Read_Only
            /// </summary>
            [EnumMember(Value = "Read_Only")]
            ReadOnlyEnum = 2,
            
            /// <summary>
            /// Enum ReadWriteEnum for Read_Write
            /// </summary>
            [EnumMember(Value = "Read_Write")]
            ReadWriteEnum = 3,
            
            /// <summary>
            /// Enum RootEnum for Root
            /// </summary>
            [EnumMember(Value = "Root")]
            RootEnum = 4,
            
            /// <summary>
            /// Enum ReadOnlyRootEnum for Read_Only_Root
            /// </summary>
            [EnumMember(Value = "Read_Only_Root")]
            ReadOnlyRootEnum = 5
        }
}
