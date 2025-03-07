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
        /// file connection states for remote system * OK                       - Normal conditions. * Update_Needed            - Verify and update needed to handle network configuration changes on the systems. * Not_OK                   - File connection to the remote peer is lost. * Status_Unknown           - File Connection status is unknown at the moment.  Was added in version 3.0.0.0.
        /// </summary>
        /// <value>file connection states for remote system * OK                       - Normal conditions. * Update_Needed            - Verify and update needed to handle network configuration changes on the systems. * Not_OK                   - File connection to the remote peer is lost. * Status_Unknown           - File Connection status is unknown at the moment.  Was added in version 3.0.0.0.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum RemoteSystemFileConnectionStateEnum
        {
            
            /// <summary>
            /// Enum OKEnum for OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OKEnum = 1,
            
            /// <summary>
            /// Enum UpdateNeededEnum for Update_Needed
            /// </summary>
            [EnumMember(Value = "Update_Needed")]
            UpdateNeededEnum = 2,
            
            /// <summary>
            /// Enum NotOKEnum for Not_OK
            /// </summary>
            [EnumMember(Value = "Not_OK")]
            NotOKEnum = 3,
            
            /// <summary>
            /// Enum StatusUnknownEnum for Status_Unknown
            /// </summary>
            [EnumMember(Value = "Status_Unknown")]
            StatusUnknownEnum = 4
        }
}
