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
        /// Operating system of the host. Values are: * Windows * Linux * ESXi * AIX * HP-UX * Solaris 
        /// </summary>
        /// <value>Operating system of the host. Values are: * Windows * Linux * ESXi * AIX * HP-UX * Solaris </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum OSTypeEnum
        {
            
            /// <summary>
            /// Enum WindowsEnum for Windows
            /// </summary>
            [EnumMember(Value = "Windows")]
            WindowsEnum = 1,
            
            /// <summary>
            /// Enum LinuxEnum for Linux
            /// </summary>
            [EnumMember(Value = "Linux")]
            LinuxEnum = 2,
            
            /// <summary>
            /// Enum ESXiEnum for ESXi
            /// </summary>
            [EnumMember(Value = "ESXi")]
            ESXiEnum = 3,
            
            /// <summary>
            /// Enum AIXEnum for AIX
            /// </summary>
            [EnumMember(Value = "AIX")]
            AIXEnum = 4,
            
            /// <summary>
            /// Enum HPUXEnum for HP-UX
            /// </summary>
            [EnumMember(Value = "HP-UX")]
            HPUXEnum = 5,
            
            /// <summary>
            /// Enum SolarisEnum for Solaris
            /// </summary>
            [EnumMember(Value = "Solaris")]
            SolarisEnum = 6
        }
}
