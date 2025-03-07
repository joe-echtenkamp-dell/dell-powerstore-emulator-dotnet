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
        /// Stale state of the Hardware. Current states are:  * Not_Stale - Not stale.  * Disconnected - Either this Hardware or an ancestor of this Hardware has a Disconnected lifecycle state and therefore is not updated.  Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Stale state of the Hardware. Current states are:  * Not_Stale - Not stale.  * Disconnected - Either this Hardware or an ancestor of this Hardware has a Disconnected lifecycle state and therefore is not updated.  Was added in version 2.0.0.0.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HardwareStaleStateEnum
        {
            
            /// <summary>
            /// Enum NotStaleEnum for Not_Stale
            /// </summary>
            [EnumMember(Value = "Not_Stale")]
            NotStaleEnum = 1,
            
            /// <summary>
            /// Enum DisconnectedEnum for Disconnected
            /// </summary>
            [EnumMember(Value = "Disconnected")]
            DisconnectedEnum = 2
        }
}
