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
        /// File system locking policies. These policy choices control whether the NFSv4 range locks are honored. Because NFSv3 is advisory by design, this policy specifies that the NFSv4 locking feature behaves like NFSv3 (advisory mode), for backward compatiblity with applications expecting an advisory locking scheme.    * Advisory - No lock checking for NFS and honor SMB lock range only for SMB.  * Mandatory - Honor SMB and NFS lock range. 
        /// </summary>
        /// <value>File system locking policies. These policy choices control whether the NFSv4 range locks are honored. Because NFSv3 is advisory by design, this policy specifies that the NFSv4 locking feature behaves like NFSv3 (advisory mode), for backward compatiblity with applications expecting an advisory locking scheme.    * Advisory - No lock checking for NFS and honor SMB lock range only for SMB.  * Mandatory - Honor SMB and NFS lock range. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum FileSystemLockingPolicyEnum
        {
            
            /// <summary>
            /// Enum AdvisoryEnum for Advisory
            /// </summary>
            [EnumMember(Value = "Advisory")]
            AdvisoryEnum = 1,
            
            /// <summary>
            /// Enum MandatoryEnum for Mandatory
            /// </summary>
            [EnumMember(Value = "Mandatory")]
            MandatoryEnum = 2
        }
}
