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
        /// Current status of the job. Deprecated in Smuttynose-SP2. * PENDING - Job has not started executing yet * QUEUED - Job has been queued * IN_PROGRESS - Job is currently executing * COMPLETED - Job has completed successfully * SKIPPED - Job will not be executed. This state is defined upfront and it is related to NDU. * FAILING - Job will not complete successfully, but has not completed clean up * UNRECOVERABLE_FAILED - Job failed, and couldn't complete its clean up steps, leaving the system inconsistent * FAILED - Job failed, and completed its clean up  Was deprecated in version 1.0.2. Values was added in 1.0.2: FAILING.
        /// </summary>
        /// <value>Current status of the job. Deprecated in Smuttynose-SP2. * PENDING - Job has not started executing yet * QUEUED - Job has been queued * IN_PROGRESS - Job is currently executing * COMPLETED - Job has completed successfully * SKIPPED - Job will not be executed. This state is defined upfront and it is related to NDU. * FAILING - Job will not complete successfully, but has not completed clean up * UNRECOVERABLE_FAILED - Job failed, and couldn't complete its clean up steps, leaving the system inconsistent * FAILED - Job failed, and completed its clean up  Was deprecated in version 1.0.2. Values was added in 1.0.2: FAILING.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum JobStateEnum
        {
            
            /// <summary>
            /// Enum PENDINGEnum for PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDINGEnum = 1,
            
            /// <summary>
            /// Enum QUEUEDEnum for QUEUED
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            QUEUEDEnum = 2,
            
            /// <summary>
            /// Enum INPROGRESSEnum for IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            INPROGRESSEnum = 3,
            
            /// <summary>
            /// Enum COMPLETEDEnum for COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETEDEnum = 4,
            
            /// <summary>
            /// Enum SKIPPEDEnum for SKIPPED
            /// </summary>
            [EnumMember(Value = "SKIPPED")]
            SKIPPEDEnum = 5,
            
            /// <summary>
            /// Enum FAILINGEnum for FAILING
            /// </summary>
            [EnumMember(Value = "FAILING")]
            FAILINGEnum = 6,
            
            /// <summary>
            /// Enum UNRECOVERABLEFAILEDEnum for UNRECOVERABLE_FAILED
            /// </summary>
            [EnumMember(Value = "UNRECOVERABLE_FAILED")]
            UNRECOVERABLEFAILEDEnum = 7,
            
            /// <summary>
            /// Enum FAILEDEnum for FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILEDEnum = 8
        }
}
