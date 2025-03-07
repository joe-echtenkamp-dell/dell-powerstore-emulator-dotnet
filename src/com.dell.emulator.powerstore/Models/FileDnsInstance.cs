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
    /// This resource type has queriable association from nas_server
    /// </summary>
    [DataContract]
    public partial class FileDnsInstance : IEquatable<FileDnsInstance>
    { 
        /// <summary>
        /// Unique identifier of the DNS server.
        /// </summary>
        /// <value>Unique identifier of the DNS server.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier of the associated NAS Server instance that uses this DNS object. Only one DNS object per NAS Server is supported.
        /// </summary>
        /// <value>Unique identifier of the associated NAS Server instance that uses this DNS object. Only one DNS object per NAS Server is supported.</value>

        [DataMember(Name="nas_server_id")]
        public string NasServerId { get; set; }

        /// <summary>
        /// Name of the DNS domain, where the NAS Server does host names lookup when an FQDN is not specified in the request.
        /// </summary>
        /// <value>Name of the DNS domain, where the NAS Server does host names lookup when an FQDN is not specified in the request.</value>

        [DataMember(Name="domain")]
        public string Domain { get; set; }

        /// <summary>
        /// The list of DNS server IP addresses. The addresses may be IPv4 or IPv6.
        /// </summary>
        /// <value>The list of DNS server IP addresses. The addresses may be IPv4 or IPv6.</value>

        [DataMember(Name="ip_addresses")]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets Transport
        /// </summary>

        [DataMember(Name="transport")]
        public FileDNSTransportEnum? Transport { get; set; }

        /// <summary>
        /// Used in replication context when the user wants to override the settings on the destination. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Used in replication context when the user wants to override the settings on the destination. Was added in version 3.0.0.0.</value>

        [DataMember(Name="is_destination_override_enabled")]
        public bool? IsDestinationOverrideEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SourceParameters
        /// </summary>

        [DataMember(Name="source_parameters")]
        public FileDnsInstanceSourceParameters SourceParameters { get; set; }

        /// <summary>
        /// Localized message string corresponding to transport
        /// </summary>
        /// <value>Localized message string corresponding to transport</value>

        [DataMember(Name="transport_l10n")]
        public string TransportL10n { get; set; }

        /// <summary>
        /// This is the embeddable reference form of nas_server_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of nas_server_id attribute.</value>

        [DataMember(Name="nas_server")]
        public NasServerInstance NasServer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDnsInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NasServerId: ").Append(NasServerId).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  IsDestinationOverrideEnabled: ").Append(IsDestinationOverrideEnabled).Append("\n");
            sb.Append("  SourceParameters: ").Append(SourceParameters).Append("\n");
            sb.Append("  TransportL10n: ").Append(TransportL10n).Append("\n");
            sb.Append("  NasServer: ").Append(NasServer).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FileDnsInstance)obj);
        }

        /// <summary>
        /// Returns true if FileDnsInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of FileDnsInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDnsInstance other)
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
                    NasServerId == other.NasServerId ||
                    NasServerId != null &&
                    NasServerId.Equals(other.NasServerId)
                ) && 
                (
                    Domain == other.Domain ||
                    Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    IpAddresses == other.IpAddresses ||
                    IpAddresses != null &&
                    IpAddresses.SequenceEqual(other.IpAddresses)
                ) && 
                (
                    Transport == other.Transport ||
                    Transport != null &&
                    Transport.Equals(other.Transport)
                ) && 
                (
                    IsDestinationOverrideEnabled == other.IsDestinationOverrideEnabled ||
                    IsDestinationOverrideEnabled != null &&
                    IsDestinationOverrideEnabled.Equals(other.IsDestinationOverrideEnabled)
                ) && 
                (
                    SourceParameters == other.SourceParameters ||
                    SourceParameters != null &&
                    SourceParameters.Equals(other.SourceParameters)
                ) && 
                (
                    TransportL10n == other.TransportL10n ||
                    TransportL10n != null &&
                    TransportL10n.Equals(other.TransportL10n)
                ) && 
                (
                    NasServer == other.NasServer ||
                    NasServer != null &&
                    NasServer.Equals(other.NasServer)
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
                    if (NasServerId != null)
                    hashCode = hashCode * 59 + NasServerId.GetHashCode();
                    if (Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();
                    if (IpAddresses != null)
                    hashCode = hashCode * 59 + IpAddresses.GetHashCode();
                    if (Transport != null)
                    hashCode = hashCode * 59 + Transport.GetHashCode();
                    if (IsDestinationOverrideEnabled != null)
                    hashCode = hashCode * 59 + IsDestinationOverrideEnabled.GetHashCode();
                    if (SourceParameters != null)
                    hashCode = hashCode * 59 + SourceParameters.GetHashCode();
                    if (TransportL10n != null)
                    hashCode = hashCode * 59 + TransportL10n.GetHashCode();
                    if (NasServer != null)
                    hashCode = hashCode * 59 + NasServer.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FileDnsInstance left, FileDnsInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FileDnsInstance left, FileDnsInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
