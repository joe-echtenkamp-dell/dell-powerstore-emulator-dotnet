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
    /// 
    /// </summary>
    [DataContract]
    public partial class NetworkReplacePhysicalSwitchConnection : IEquatable<NetworkReplacePhysicalSwitchConnection>
    { 
        /// <summary>
        /// Physical switch address in IPv4 or IPv6 or DNS hostname format.
        /// </summary>
        /// <value>Physical switch address in IPv4 or IPv6 or DNS hostname format.</value>
        [Required]
        
        [DataMember(Name="address")]
        public string Address { get; set; }

        /// <summary>
        /// Port used for connection to switch.
        /// </summary>
        /// <value>Port used for connection to switch.</value>

        [Range(0, 65535)]
        [DataMember(Name="port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or Sets ConnectMethod
        /// </summary>
        [Required]
        
        [DataMember(Name="connect_method")]
        public PhysicalSwitchConnectMethodEnum? ConnectMethod { get; set; }

        /// <summary>
        /// Username to connect a physical switch for SSH connection method.
        /// </summary>
        /// <value>Username to connect a physical switch for SSH connection method.</value>

        [DataMember(Name="username")]
        public string Username { get; set; }

        /// <summary>
        /// SSH password to connect a physical switch if SSH connect method is specified.
        /// </summary>
        /// <value>SSH password to connect a physical switch if SSH connect method is specified.</value>

        [DataMember(Name="ssh_password")]
        public string SshPassword { get; set; }

        /// <summary>
        /// SNMPv2 community string, if SNMPv2c connect method is specified.
        /// </summary>
        /// <value>SNMPv2 community string, if SNMPv2c connect method is specified.</value>

        [DataMember(Name="snmp_community_string")]
        public string SnmpCommunityString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkReplacePhysicalSwitchConnection {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  ConnectMethod: ").Append(ConnectMethod).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  SshPassword: ").Append(SshPassword).Append("\n");
            sb.Append("  SnmpCommunityString: ").Append(SnmpCommunityString).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NetworkReplacePhysicalSwitchConnection)obj);
        }

        /// <summary>
        /// Returns true if NetworkReplacePhysicalSwitchConnection instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkReplacePhysicalSwitchConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkReplacePhysicalSwitchConnection other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                ) && 
                (
                    Port == other.Port ||
                    Port != null &&
                    Port.Equals(other.Port)
                ) && 
                (
                    ConnectMethod == other.ConnectMethod ||
                    ConnectMethod != null &&
                    ConnectMethod.Equals(other.ConnectMethod)
                ) && 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) && 
                (
                    SshPassword == other.SshPassword ||
                    SshPassword != null &&
                    SshPassword.Equals(other.SshPassword)
                ) && 
                (
                    SnmpCommunityString == other.SnmpCommunityString ||
                    SnmpCommunityString != null &&
                    SnmpCommunityString.Equals(other.SnmpCommunityString)
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
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                    if (Port != null)
                    hashCode = hashCode * 59 + Port.GetHashCode();
                    if (ConnectMethod != null)
                    hashCode = hashCode * 59 + ConnectMethod.GetHashCode();
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                    if (SshPassword != null)
                    hashCode = hashCode * 59 + SshPassword.GetHashCode();
                    if (SnmpCommunityString != null)
                    hashCode = hashCode * 59 + SnmpCommunityString.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NetworkReplacePhysicalSwitchConnection left, NetworkReplacePhysicalSwitchConnection right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NetworkReplacePhysicalSwitchConnection left, NetworkReplacePhysicalSwitchConnection right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
