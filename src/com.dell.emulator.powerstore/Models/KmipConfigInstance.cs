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
    ///  Was added in version 3.0.0.0.
    /// </summary>
    [DataContract]
    public partial class KmipConfigInstance : IEquatable<KmipConfigInstance>
    { 
        /// <summary>
        /// Unique identifier for this instance.
        /// </summary>
        /// <value>Unique identifier for this instance.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Whether KMIP is enabled. At least one member (KMIP servers) must be defined to enable KMIP. 
        /// </summary>
        /// <value>Whether KMIP is enabled. At least one member (KMIP servers) must be defined to enable KMIP. </value>

        [DataMember(Name="is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Port number for establishing connection to a KMIP server (defaults to 5696). 
        /// </summary>
        /// <value>Port number for establishing connection to a KMIP server (defaults to 5696). </value>

        [Range(0, 2147483647)]
        [DataMember(Name="port")]
        public int? Port { get; set; }

        /// <summary>
        /// Timeout in seconds for establishing a connection to a KMIP server. If the system does not receive a reply from the KMIP server before the specified timeout, it stops sending requests. Default value is 5 (5 seconds). 
        /// </summary>
        /// <value>Timeout in seconds for establishing a connection to a KMIP server. If the system does not receive a reply from the KMIP server before the specified timeout, it stops sending requests. Default value is 5 (5 seconds). </value>

        [Range(0, 2147483647)]
        [DataMember(Name="server_timeout")]
        public int? ServerTimeout { get; set; }

        /// <summary>
        /// Username for accessing the KMIP server.
        /// </summary>
        /// <value>Username for accessing the KMIP server.</value>

        [DataMember(Name="username")]
        public string Username { get; set; }

        /// <summary>
        /// Array of member KMIP servers with the address and status of each.  Filtering on the fields of this embedded resource is not supported.
        /// </summary>
        /// <value>Array of member KMIP servers with the address and status of each.  Filtering on the fields of this embedded resource is not supported.</value>

        [DataMember(Name="servers")]
        public List<KmipConfigMemberInstance> Servers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmipConfigInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  ServerTimeout: ").Append(ServerTimeout).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((KmipConfigInstance)obj);
        }

        /// <summary>
        /// Returns true if KmipConfigInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of KmipConfigInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmipConfigInstance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    IsEnabled == other.IsEnabled ||
                    IsEnabled != null &&
                    IsEnabled.Equals(other.IsEnabled)
                ) && 
                (
                    Port == other.Port ||
                    Port != null &&
                    Port.Equals(other.Port)
                ) && 
                (
                    ServerTimeout == other.ServerTimeout ||
                    ServerTimeout != null &&
                    ServerTimeout.Equals(other.ServerTimeout)
                ) && 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) && 
                (
                    Servers == other.Servers ||
                    Servers != null &&
                    Servers.SequenceEqual(other.Servers)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (IsEnabled != null)
                    hashCode = hashCode * 59 + IsEnabled.GetHashCode();
                    if (Port != null)
                    hashCode = hashCode * 59 + Port.GetHashCode();
                    if (ServerTimeout != null)
                    hashCode = hashCode * 59 + ServerTimeout.GetHashCode();
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                    if (Servers != null)
                    hashCode = hashCode * 59 + Servers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(KmipConfigInstance left, KmipConfigInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(KmipConfigInstance left, KmipConfigInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
