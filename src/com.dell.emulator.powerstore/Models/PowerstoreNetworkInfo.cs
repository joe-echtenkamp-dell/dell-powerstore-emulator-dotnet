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
    /// PowerStore storage network information as is from the local or remote PowerStore cluster.  Was added in version 3.5.0.0.
    /// </summary>
    [DataContract]
    public partial class PowerstoreNetworkInfo : IEquatable<PowerstoreNetworkInfo>
    { 
        /// <summary>
        /// Unique identifier of the network. 
        /// </summary>
        /// <value>Unique identifier of the network. </value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// User-defined name of the network.   This property supports case-insensitive filtering.
        /// </summary>
        /// <value>User-defined name of the network.   This property supports case-insensitive filtering.</value>

        [StringLength(128, MinimumLength=1)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// VLAN identifier 
        /// </summary>
        /// <value>VLAN identifier </value>

        [Range(0, 4094)]
        [DataMember(Name="vlan_id")]
        public int? VlanId { get; set; }

        /// <summary>
        /// Network gateway in IPv4 or IPv6 format, corresponding to the network&#39;s IP version. 
        /// </summary>
        /// <value>Network gateway in IPv4 or IPv6 format, corresponding to the network&#39;s IP version. </value>

        [DataMember(Name="gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Maximum Transmission Unit (MTU) packet size set on network interfaces, in bytes. 
        /// </summary>
        /// <value>Maximum Transmission Unit (MTU) packet size set on network interfaces, in bytes. </value>

        [Range(1280, 9000)]
        [DataMember(Name="mtu")]
        public int? Mtu { get; set; }

        /// <summary>
        /// Network prefix length, used for both IPv4 and IPv6. 
        /// </summary>
        /// <value>Network prefix length, used for both IPv4 and IPv6. </value>

        [Range(1, 127)]
        [DataMember(Name="prefix_length")]
        public int? PrefixLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerstoreNetworkInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VlanId: ").Append(VlanId).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  Mtu: ").Append(Mtu).Append("\n");
            sb.Append("  PrefixLength: ").Append(PrefixLength).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PowerstoreNetworkInfo)obj);
        }

        /// <summary>
        /// Returns true if PowerstoreNetworkInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PowerstoreNetworkInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerstoreNetworkInfo other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    VlanId == other.VlanId ||
                    VlanId != null &&
                    VlanId.Equals(other.VlanId)
                ) && 
                (
                    Gateway == other.Gateway ||
                    Gateway != null &&
                    Gateway.Equals(other.Gateway)
                ) && 
                (
                    Mtu == other.Mtu ||
                    Mtu != null &&
                    Mtu.Equals(other.Mtu)
                ) && 
                (
                    PrefixLength == other.PrefixLength ||
                    PrefixLength != null &&
                    PrefixLength.Equals(other.PrefixLength)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (VlanId != null)
                    hashCode = hashCode * 59 + VlanId.GetHashCode();
                    if (Gateway != null)
                    hashCode = hashCode * 59 + Gateway.GetHashCode();
                    if (Mtu != null)
                    hashCode = hashCode * 59 + Mtu.GetHashCode();
                    if (PrefixLength != null)
                    hashCode = hashCode * 59 + PrefixLength.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PowerstoreNetworkInfo left, PowerstoreNetworkInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PowerstoreNetworkInfo left, PowerstoreNetworkInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
