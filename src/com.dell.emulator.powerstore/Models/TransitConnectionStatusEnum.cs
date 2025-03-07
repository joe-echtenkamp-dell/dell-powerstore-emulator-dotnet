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
        /// Possible transit connection statuses: * Login_Success               - Login to target successful. * Authentication_Failure      - Failed to authenticate the connection. * Connection_Refused          - Connection was refused. * Login_Timeout               - Login to target timed out. * Network_Error - Network error * General_Failure             - Other failure not listed. * Login_Success_No_Ports      - Login successful after discovery failure. Used only for PS EqualLogic systems. * Discovery_Success           - Discovery of target IP successful. * Discovery_Authentication_Failure - Authentication failure during discovery of target. * Discovery_Connection_Refused     - Connection was refused during discovery of target. * Discovery_Timeout                - Discovery of target timed out. * Operation_Timeout               - Operations on the connection timed out. Used only for PowerProtect DD systems.  Values was added in 3.5.0.0: Operation_Timeout.
        /// </summary>
        /// <value>Possible transit connection statuses: * Login_Success               - Login to target successful. * Authentication_Failure      - Failed to authenticate the connection. * Connection_Refused          - Connection was refused. * Login_Timeout               - Login to target timed out. * Network_Error - Network error * General_Failure             - Other failure not listed. * Login_Success_No_Ports      - Login successful after discovery failure. Used only for PS EqualLogic systems. * Discovery_Success           - Discovery of target IP successful. * Discovery_Authentication_Failure - Authentication failure during discovery of target. * Discovery_Connection_Refused     - Connection was refused during discovery of target. * Discovery_Timeout                - Discovery of target timed out. * Operation_Timeout               - Operations on the connection timed out. Used only for PowerProtect DD systems.  Values was added in 3.5.0.0: Operation_Timeout.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TransitConnectionStatusEnum
        {
            
            /// <summary>
            /// Enum LoginSuccessEnum for Login_Success
            /// </summary>
            [EnumMember(Value = "Login_Success")]
            LoginSuccessEnum = 1,
            
            /// <summary>
            /// Enum AuthenticationFailureEnum for Authentication_Failure
            /// </summary>
            [EnumMember(Value = "Authentication_Failure")]
            AuthenticationFailureEnum = 2,
            
            /// <summary>
            /// Enum ConnectionRefusedEnum for Connection_Refused
            /// </summary>
            [EnumMember(Value = "Connection_Refused")]
            ConnectionRefusedEnum = 3,
            
            /// <summary>
            /// Enum LoginTimeoutEnum for Login_Timeout
            /// </summary>
            [EnumMember(Value = "Login_Timeout")]
            LoginTimeoutEnum = 4,
            
            /// <summary>
            /// Enum NetworkErrorEnum for Network_Error
            /// </summary>
            [EnumMember(Value = "Network_Error")]
            NetworkErrorEnum = 5,
            
            /// <summary>
            /// Enum GeneralFailureEnum for General_Failure
            /// </summary>
            [EnumMember(Value = "General_Failure")]
            GeneralFailureEnum = 6,
            
            /// <summary>
            /// Enum LoginSuccessNoPortsEnum for Login_Success_No_Ports
            /// </summary>
            [EnumMember(Value = "Login_Success_No_Ports")]
            LoginSuccessNoPortsEnum = 7,
            
            /// <summary>
            /// Enum DiscoverySuccessEnum for Discovery_Success
            /// </summary>
            [EnumMember(Value = "Discovery_Success")]
            DiscoverySuccessEnum = 8,
            
            /// <summary>
            /// Enum DiscoveryAuthenticationFailureEnum for Discovery_Authentication_Failure
            /// </summary>
            [EnumMember(Value = "Discovery_Authentication_Failure")]
            DiscoveryAuthenticationFailureEnum = 9,
            
            /// <summary>
            /// Enum DiscoveryConnectionRefusedEnum for Discovery_Connection_Refused
            /// </summary>
            [EnumMember(Value = "Discovery_Connection_Refused")]
            DiscoveryConnectionRefusedEnum = 10,
            
            /// <summary>
            /// Enum DiscoveryTimeoutEnum for Discovery_Timeout
            /// </summary>
            [EnumMember(Value = "Discovery_Timeout")]
            DiscoveryTimeoutEnum = 11,
            
            /// <summary>
            /// Enum OperationTimeoutEnum for Operation_Timeout
            /// </summary>
            [EnumMember(Value = "Operation_Timeout")]
            OperationTimeoutEnum = 12
        }
}
