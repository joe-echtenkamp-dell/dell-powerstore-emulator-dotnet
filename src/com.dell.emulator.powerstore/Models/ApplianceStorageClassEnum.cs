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
        /// Describes the class of storage used by the appliance. Possible values include: * TLC_Based_Flash - Appliance uses Triple-level cell (TLC) data storage, which means each NAND flash memory cell contains three bits of data. * QLC_Based_Flash - Appliance uses Quad-level cell (QLC) data storage, which means each NAND flash memory cell contains four bits of data.   Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Describes the class of storage used by the appliance. Possible values include: * TLC_Based_Flash - Appliance uses Triple-level cell (TLC) data storage, which means each NAND flash memory cell contains three bits of data. * QLC_Based_Flash - Appliance uses Quad-level cell (QLC) data storage, which means each NAND flash memory cell contains four bits of data.   Was added in version 4.0.0.0.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ApplianceStorageClassEnum
        {
            
            /// <summary>
            /// Enum QLCBasedFlashEnum for QLC_Based_Flash
            /// </summary>
            [EnumMember(Value = "QLC_Based_Flash")]
            QLCBasedFlashEnum = 1,
            
            /// <summary>
            /// Enum TLCBasedFlashEnum for TLC_Based_Flash
            /// </summary>
            [EnumMember(Value = "TLC_Based_Flash")]
            TLCBasedFlashEnum = 2
        }
}
