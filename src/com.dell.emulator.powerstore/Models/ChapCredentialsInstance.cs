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
    /// Information about the iSCSI initiator, target session, or discovery CHAP secrets. 
    /// </summary>
    [DataContract]
    public partial class ChapCredentialsInstance : IEquatable<ChapCredentialsInstance>
    { 
        /// <summary>
        /// Username used by the target to authenticate the initiator during session authentication. Single CHAP mode only. 
        /// </summary>
        /// <value>Username used by the target to authenticate the initiator during session authentication. Single CHAP mode only. </value>

        [DataMember(Name="target_session_username")]
        public string TargetSessionUsername { get; set; }

        /// <summary>
        /// Password used by the target to authenticate the initiator during session authentication. Single CHAP mode only. 
        /// </summary>
        /// <value>Password used by the target to authenticate the initiator during session authentication. Single CHAP mode only. </value>

        [DataMember(Name="target_session_password")]
        public string TargetSessionPassword { get; set; }

        /// <summary>
        /// Username used by the target to authenticate the initiator during discovery authentication. Single CHAP mode only. 
        /// </summary>
        /// <value>Username used by the target to authenticate the initiator during discovery authentication. Single CHAP mode only. </value>

        [DataMember(Name="target_discovery_username")]
        public string TargetDiscoveryUsername { get; set; }

        /// <summary>
        /// Password used by the target to authenticate the initiator during discovery authentication. Single CHAP mode only. 
        /// </summary>
        /// <value>Password used by the target to authenticate the initiator during discovery authentication. Single CHAP mode only. </value>

        [DataMember(Name="target_discovery_password")]
        public string TargetDiscoveryPassword { get; set; }

        /// <summary>
        /// Username used by the initiator to authenticate the target during session authentication. Mutual CHAP mode only. 
        /// </summary>
        /// <value>Username used by the initiator to authenticate the target during session authentication. Mutual CHAP mode only. </value>

        [DataMember(Name="initiator_session_username")]
        public string InitiatorSessionUsername { get; set; }

        /// <summary>
        /// Password used by the initiator to authenticate the target during session authentication. Mutual CHAP mode only. 
        /// </summary>
        /// <value>Password used by the initiator to authenticate the target during session authentication. Mutual CHAP mode only. </value>

        [DataMember(Name="initiator_session_password")]
        public string InitiatorSessionPassword { get; set; }

        /// <summary>
        /// Username used by the initiator to authenticate the target during discovery authentication. Mutual CHAP mode only. 
        /// </summary>
        /// <value>Username used by the initiator to authenticate the target during discovery authentication. Mutual CHAP mode only. </value>

        [DataMember(Name="initiator_discovery_username")]
        public string InitiatorDiscoveryUsername { get; set; }

        /// <summary>
        /// Password used by the initiator to authenticate the target during discovery authentication. Mutual CHAP mode only. 
        /// </summary>
        /// <value>Password used by the initiator to authenticate the target during discovery authentication. Mutual CHAP mode only. </value>

        [DataMember(Name="initiator_discovery_password")]
        public string InitiatorDiscoveryPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChapCredentialsInstance {\n");
            sb.Append("  TargetSessionUsername: ").Append(TargetSessionUsername).Append("\n");
            sb.Append("  TargetSessionPassword: ").Append(TargetSessionPassword).Append("\n");
            sb.Append("  TargetDiscoveryUsername: ").Append(TargetDiscoveryUsername).Append("\n");
            sb.Append("  TargetDiscoveryPassword: ").Append(TargetDiscoveryPassword).Append("\n");
            sb.Append("  InitiatorSessionUsername: ").Append(InitiatorSessionUsername).Append("\n");
            sb.Append("  InitiatorSessionPassword: ").Append(InitiatorSessionPassword).Append("\n");
            sb.Append("  InitiatorDiscoveryUsername: ").Append(InitiatorDiscoveryUsername).Append("\n");
            sb.Append("  InitiatorDiscoveryPassword: ").Append(InitiatorDiscoveryPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ChapCredentialsInstance)obj);
        }

        /// <summary>
        /// Returns true if ChapCredentialsInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ChapCredentialsInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChapCredentialsInstance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TargetSessionUsername == other.TargetSessionUsername ||
                    TargetSessionUsername != null &&
                    TargetSessionUsername.Equals(other.TargetSessionUsername)
                ) && 
                (
                    TargetSessionPassword == other.TargetSessionPassword ||
                    TargetSessionPassword != null &&
                    TargetSessionPassword.Equals(other.TargetSessionPassword)
                ) && 
                (
                    TargetDiscoveryUsername == other.TargetDiscoveryUsername ||
                    TargetDiscoveryUsername != null &&
                    TargetDiscoveryUsername.Equals(other.TargetDiscoveryUsername)
                ) && 
                (
                    TargetDiscoveryPassword == other.TargetDiscoveryPassword ||
                    TargetDiscoveryPassword != null &&
                    TargetDiscoveryPassword.Equals(other.TargetDiscoveryPassword)
                ) && 
                (
                    InitiatorSessionUsername == other.InitiatorSessionUsername ||
                    InitiatorSessionUsername != null &&
                    InitiatorSessionUsername.Equals(other.InitiatorSessionUsername)
                ) && 
                (
                    InitiatorSessionPassword == other.InitiatorSessionPassword ||
                    InitiatorSessionPassword != null &&
                    InitiatorSessionPassword.Equals(other.InitiatorSessionPassword)
                ) && 
                (
                    InitiatorDiscoveryUsername == other.InitiatorDiscoveryUsername ||
                    InitiatorDiscoveryUsername != null &&
                    InitiatorDiscoveryUsername.Equals(other.InitiatorDiscoveryUsername)
                ) && 
                (
                    InitiatorDiscoveryPassword == other.InitiatorDiscoveryPassword ||
                    InitiatorDiscoveryPassword != null &&
                    InitiatorDiscoveryPassword.Equals(other.InitiatorDiscoveryPassword)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (TargetSessionUsername != null)
                    hashCode = hashCode * 59 + TargetSessionUsername.GetHashCode();
                    if (TargetSessionPassword != null)
                    hashCode = hashCode * 59 + TargetSessionPassword.GetHashCode();
                    if (TargetDiscoveryUsername != null)
                    hashCode = hashCode * 59 + TargetDiscoveryUsername.GetHashCode();
                    if (TargetDiscoveryPassword != null)
                    hashCode = hashCode * 59 + TargetDiscoveryPassword.GetHashCode();
                    if (InitiatorSessionUsername != null)
                    hashCode = hashCode * 59 + InitiatorSessionUsername.GetHashCode();
                    if (InitiatorSessionPassword != null)
                    hashCode = hashCode * 59 + InitiatorSessionPassword.GetHashCode();
                    if (InitiatorDiscoveryUsername != null)
                    hashCode = hashCode * 59 + InitiatorDiscoveryUsername.GetHashCode();
                    if (InitiatorDiscoveryPassword != null)
                    hashCode = hashCode * 59 + InitiatorDiscoveryPassword.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChapCredentialsInstance left, ChapCredentialsInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChapCredentialsInstance left, ChapCredentialsInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
