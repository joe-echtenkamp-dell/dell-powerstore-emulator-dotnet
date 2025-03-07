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
        /// File interface route operational status: * Ok - The route is working fine. * Invalid_IP_Version - Source interfaces have a different IP protocol version than the route. * Invalid_Source_Interface - No source interfaces set up on the system. * Invalid_Gateway - Source interfaces in a different subnet than the gateway. * Not_Operational - The route is not operational. 
        /// </summary>
        /// <value>File interface route operational status: * Ok - The route is working fine. * Invalid_IP_Version - Source interfaces have a different IP protocol version than the route. * Invalid_Source_Interface - No source interfaces set up on the system. * Invalid_Gateway - Source interfaces in a different subnet than the gateway. * Not_Operational - The route is not operational. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum FileInterfaceRouteOperationalStatusEnum
        {
            
            /// <summary>
            /// Enum OkEnum for Ok
            /// </summary>
            [EnumMember(Value = "Ok")]
            OkEnum = 1,
            
            /// <summary>
            /// Enum InvalidIPVersionEnum for Invalid_IP_Version
            /// </summary>
            [EnumMember(Value = "Invalid_IP_Version")]
            InvalidIPVersionEnum = 2,
            
            /// <summary>
            /// Enum InvalidSourceInterfaceEnum for Invalid_Source_Interface
            /// </summary>
            [EnumMember(Value = "Invalid_Source_Interface")]
            InvalidSourceInterfaceEnum = 3,
            
            /// <summary>
            /// Enum InvalidGatewayEnum for Invalid_Gateway
            /// </summary>
            [EnumMember(Value = "Invalid_Gateway")]
            InvalidGatewayEnum = 4,
            
            /// <summary>
            /// Enum NotOperationalEnum for Not_Operational
            /// </summary>
            [EnumMember(Value = "Not_Operational")]
            NotOperationalEnum = 5
        }
}
