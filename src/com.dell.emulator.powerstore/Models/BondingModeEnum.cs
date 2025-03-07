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
        /// Bonding mode:   * LACP - Uses an IEEE 802.3ad dynamic link aggregation policy. Aggregation groups share     the same speed and duplex settings. This mode transmits and receives network traffic on     all interfaces in the active aggregator. 
        /// </summary>
        /// <value>Bonding mode:   * LACP - Uses an IEEE 802.3ad dynamic link aggregation policy. Aggregation groups share     the same speed and duplex settings. This mode transmits and receives network traffic on     all interfaces in the active aggregator. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BondingModeEnum
        {
            
            /// <summary>
            /// Enum LACPEnum for LACP
            /// </summary>
            [EnumMember(Value = "LACP")]
            LACPEnum = 1
        }
}
