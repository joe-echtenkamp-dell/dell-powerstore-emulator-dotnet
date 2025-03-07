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
        /// General status of the VASA vendor provider in vCenter. * Not_Registered - The provider is not registered with vCenter. * Offline - vCenter cannot connect with the provider. * Online - vCenter is communicating with the provider. * Unavailable - VASA provider status can't be determined due to lost connection to vCenter.  Was added in version 2.0.0.0. Values was added in 3.5.0.0: Unavailable.
        /// </summary>
        /// <value>General status of the VASA vendor provider in vCenter. * Not_Registered - The provider is not registered with vCenter. * Offline - vCenter cannot connect with the provider. * Online - vCenter is communicating with the provider. * Unavailable - VASA provider status can't be determined due to lost connection to vCenter.  Was added in version 2.0.0.0. Values was added in 3.5.0.0: Unavailable.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum VendorProviderStatusEnum
        {
            
            /// <summary>
            /// Enum NotRegisteredEnum for Not_Registered
            /// </summary>
            [EnumMember(Value = "Not_Registered")]
            NotRegisteredEnum = 1,
            
            /// <summary>
            /// Enum OfflineEnum for Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            OfflineEnum = 2,
            
            /// <summary>
            /// Enum OnlineEnum for Online
            /// </summary>
            [EnumMember(Value = "Online")]
            OnlineEnum = 3,
            
            /// <summary>
            /// Enum UnavailableEnum for Unavailable
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            UnavailableEnum = 4
        }
}
