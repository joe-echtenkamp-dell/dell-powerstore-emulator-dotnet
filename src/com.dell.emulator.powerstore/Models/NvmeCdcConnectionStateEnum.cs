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
        /// Current state of the Centralized Discovery Controller (CDC) connection to the Direct Discovery Controller (DDC). * Uninitialized - Sending mDNS queries to discover CDC. * Kickstarting - CDC was discovered (mDNS response was received or CDC was manually configured) and Kickstart Requests was sent towards CDC to initiate connectivity. * Pending - Kickstart messaging succeeded, pending to connectivity establishment from CDC. * Established - CDC established connectivity with DDC.  Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Current state of the Centralized Discovery Controller (CDC) connection to the Direct Discovery Controller (DDC). * Uninitialized - Sending mDNS queries to discover CDC. * Kickstarting - CDC was discovered (mDNS response was received or CDC was manually configured) and Kickstart Requests was sent towards CDC to initiate connectivity. * Pending - Kickstart messaging succeeded, pending to connectivity establishment from CDC. * Established - CDC established connectivity with DDC.  Was added in version 3.0.0.0.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NvmeCdcConnectionStateEnum
        {
            
            /// <summary>
            /// Enum UninitializedEnum for Uninitialized
            /// </summary>
            [EnumMember(Value = "Uninitialized")]
            UninitializedEnum = 1,
            
            /// <summary>
            /// Enum KickstartingEnum for Kickstarting
            /// </summary>
            [EnumMember(Value = "Kickstarting")]
            KickstartingEnum = 2,
            
            /// <summary>
            /// Enum PendingEnum for Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            PendingEnum = 3,
            
            /// <summary>
            /// Enum EstablishedEnum for Established
            /// </summary>
            [EnumMember(Value = "Established")]
            EstablishedEnum = 4
        }
}
