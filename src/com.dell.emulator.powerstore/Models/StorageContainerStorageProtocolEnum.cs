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
        /// The type of Storage Container. * SCSI - A storage container is dedicated to SCSI usage. * NVMe - A storage container is dedicated to NVMe usage.  Was added in version 3.0.0.0.
        /// </summary>
        /// <value>The type of Storage Container. * SCSI - A storage container is dedicated to SCSI usage. * NVMe - A storage container is dedicated to NVMe usage.  Was added in version 3.0.0.0.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StorageContainerStorageProtocolEnum
        {
            
            /// <summary>
            /// Enum SCSIEnum for SCSI
            /// </summary>
            [EnumMember(Value = "SCSI")]
            SCSIEnum = 1,
            
            /// <summary>
            /// Enum NVMeEnum for NVMe
            /// </summary>
            [EnumMember(Value = "NVMe")]
            NVMeEnum = 2
        }
}
