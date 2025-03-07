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
        /// General health status of the VM in vCenter. Not applicable to VM snapshots. * Green - VM is operating normally. * Yellow - VM is operating normally, but there are potential issues. * Red - VM is experiencing issues and is not operating normally. * Gray - Status of the VM cannot be determined. 
        /// </summary>
        /// <value>General health status of the VM in vCenter. Not applicable to VM snapshots. * Green - VM is operating normally. * Yellow - VM is operating normally, but there are potential issues. * Red - VM is experiencing issues and is not operating normally. * Gray - Status of the VM cannot be determined. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum VirtualMachineStatusEnum
        {
            
            /// <summary>
            /// Enum GreenEnum for Green
            /// </summary>
            [EnumMember(Value = "Green")]
            GreenEnum = 1,
            
            /// <summary>
            /// Enum YellowEnum for Yellow
            /// </summary>
            [EnumMember(Value = "Yellow")]
            YellowEnum = 2,
            
            /// <summary>
            /// Enum RedEnum for Red
            /// </summary>
            [EnumMember(Value = "Red")]
            RedEnum = 3,
            
            /// <summary>
            /// Enum GrayEnum for Gray
            /// </summary>
            [EnumMember(Value = "Gray")]
            GrayEnum = 4
        }
}
