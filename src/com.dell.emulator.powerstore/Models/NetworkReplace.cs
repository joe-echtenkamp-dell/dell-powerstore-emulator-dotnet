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
    public partial class NetworkReplace : IEquatable<NetworkReplace>
    { 
        /// <summary>
        /// VLAN identifier.
        /// </summary>
        /// <value>VLAN identifier.</value>
        [Required]
        
        [Range(0, 4094)]
        [DataMember(Name="vlan_id")]
        public int? VlanId { get; set; }

        /// <summary>
        /// Network gateway in IPv4 or IPv6 format, corresponding to the network&#39;s IP version. Specify empty string to remove the gateway. 
        /// </summary>
        /// <value>Network gateway in IPv4 or IPv6 format, corresponding to the network&#39;s IP version. Specify empty string to remove the gateway. </value>
        [Required]
        
        [DataMember(Name="gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Network prefix length. (Used for both IPv4 and IPv6).
        /// </summary>
        /// <value>Network prefix length. (Used for both IPv4 and IPv6).</value>
        [Required]
        
        [Range(1, 127)]
        [DataMember(Name="prefix_length")]
        public int? PrefixLength { get; set; }

        /// <summary>
        /// New cluster management IP address in IPv4 or IPv6 format, corresponding to the network&#39;s IP version.
        /// </summary>
        /// <value>New cluster management IP address in IPv4 or IPv6 format, corresponding to the network&#39;s IP version.</value>
        [Required]
        
        [MinLength(1)]
        [DataMember(Name="cluster_mgmt_address")]
        public string ClusterMgmtAddress { get; set; }

        /// <summary>
        /// Gets or Sets VasaProviderCredentials
        /// </summary>

        [DataMember(Name="vasa_provider_credentials")]
        public NetworkReplaceVasaProviderCredentials VasaProviderCredentials { get; set; }

        /// <summary>
        /// Gets or Sets EsxiCredentials
        /// </summary>

        [DataMember(Name="esxi_credentials")]
        public EsxiCredentials EsxiCredentials { get; set; }

        /// <summary>
        /// Maximum Transmission Unit (MTU) packet size set on network interfaces, in bytes.
        /// </summary>
        /// <value>Maximum Transmission Unit (MTU) packet size set on network interfaces, in bytes.</value>
        [Required]
        
        [Range(1280, 9000)]
        [DataMember(Name="mtu")]
        public int? Mtu { get; set; }

        /// <summary>
        /// List of new IP addresses in IPv4 or IPv6 format.
        /// </summary>
        /// <value>List of new IP addresses in IPv4 or IPv6 format.</value>
        [Required]
        
        [DataMember(Name="ip_pool_addresses")]
        public List<string> IpPoolAddresses { get; set; }

        /// <summary>
        /// List of new DNS server IP addresses in IPv4 or IPv6 format.
        /// </summary>
        /// <value>List of new DNS server IP addresses in IPv4 or IPv6 format.</value>
        [Required]
        
        [DataMember(Name="dns_addresses")]
        public List<string> DnsAddresses { get; set; }

        /// <summary>
        /// List of new NTP server FQDNs or IP addresses in IPv4 or IPv6 format.
        /// </summary>
        /// <value>List of new NTP server FQDNs or IP addresses in IPv4 or IPv6 format.</value>
        [Required]
        
        [DataMember(Name="ntp_addresses")]
        public List<string> NtpAddresses { get; set; }

        /// <summary>
        /// New vCenter FQDNs or IP address in IPv4 or IPv6 format. Required only when reconfiguring PowerStoreX cluster.
        /// </summary>
        /// <value>New vCenter FQDNs or IP address in IPv4 or IPv6 format. Required only when reconfiguring PowerStoreX cluster.</value>

        [MinLength(1)]
        [DataMember(Name="vcenter_address")]
        public string VcenterAddress { get; set; }

        /// <summary>
        /// Gets or Sets SmtpConfig
        /// </summary>

        [DataMember(Name="smtp_config")]
        public NetworkReplaceSmtpConfig SmtpConfig { get; set; }

        /// <summary>
        /// List of new physical switches settings. If this property is omitted, physical switches configuration will not be modified.
        /// </summary>
        /// <value>List of new physical switches settings. If this property is omitted, physical switches configuration will not be modified.</value>

        [DataMember(Name="physical_switches")]
        public List<NetworkReplacePhysicalSwitch> PhysicalSwitches { get; set; }

        /// <summary>
        /// Indicates whether to suppress network validation errors. The option is intended to suppress false errors caused by network environment constraints.  Normally the command will fail with an error when: - some of system network ports are in degraded state or have cabling issues, - system top-of-rack switches have configuration issues leading to network unreachability, - network IP addresses have duplicates in the network environment, - or network gateway is unreachable.  When force is true, the command will proceed instead.  Caution: Only use this option when you are certain your requested settings are correct and you understand why they are failing at this time, and you want to apply the settings anyway. Improper network settings can make the system unreachable for data and management. 
        /// </summary>
        /// <value>Indicates whether to suppress network validation errors. The option is intended to suppress false errors caused by network environment constraints.  Normally the command will fail with an error when: - some of system network ports are in degraded state or have cabling issues, - system top-of-rack switches have configuration issues leading to network unreachability, - network IP addresses have duplicates in the network environment, - or network gateway is unreachable.  When force is true, the command will proceed instead.  Caution: Only use this option when you are certain your requested settings are correct and you understand why they are failing at this time, and you want to apply the settings anyway. Improper network settings can make the system unreachable for data and management. </value>

        [DataMember(Name="force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkReplace {\n");
            sb.Append("  VlanId: ").Append(VlanId).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  PrefixLength: ").Append(PrefixLength).Append("\n");
            sb.Append("  ClusterMgmtAddress: ").Append(ClusterMgmtAddress).Append("\n");
            sb.Append("  VasaProviderCredentials: ").Append(VasaProviderCredentials).Append("\n");
            sb.Append("  EsxiCredentials: ").Append(EsxiCredentials).Append("\n");
            sb.Append("  Mtu: ").Append(Mtu).Append("\n");
            sb.Append("  IpPoolAddresses: ").Append(IpPoolAddresses).Append("\n");
            sb.Append("  DnsAddresses: ").Append(DnsAddresses).Append("\n");
            sb.Append("  NtpAddresses: ").Append(NtpAddresses).Append("\n");
            sb.Append("  VcenterAddress: ").Append(VcenterAddress).Append("\n");
            sb.Append("  SmtpConfig: ").Append(SmtpConfig).Append("\n");
            sb.Append("  PhysicalSwitches: ").Append(PhysicalSwitches).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NetworkReplace)obj);
        }

        /// <summary>
        /// Returns true if NetworkReplace instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkReplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkReplace other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    PrefixLength == other.PrefixLength ||
                    PrefixLength != null &&
                    PrefixLength.Equals(other.PrefixLength)
                ) && 
                (
                    ClusterMgmtAddress == other.ClusterMgmtAddress ||
                    ClusterMgmtAddress != null &&
                    ClusterMgmtAddress.Equals(other.ClusterMgmtAddress)
                ) && 
                (
                    VasaProviderCredentials == other.VasaProviderCredentials ||
                    VasaProviderCredentials != null &&
                    VasaProviderCredentials.Equals(other.VasaProviderCredentials)
                ) && 
                (
                    EsxiCredentials == other.EsxiCredentials ||
                    EsxiCredentials != null &&
                    EsxiCredentials.Equals(other.EsxiCredentials)
                ) && 
                (
                    Mtu == other.Mtu ||
                    Mtu != null &&
                    Mtu.Equals(other.Mtu)
                ) && 
                (
                    IpPoolAddresses == other.IpPoolAddresses ||
                    IpPoolAddresses != null &&
                    IpPoolAddresses.SequenceEqual(other.IpPoolAddresses)
                ) && 
                (
                    DnsAddresses == other.DnsAddresses ||
                    DnsAddresses != null &&
                    DnsAddresses.SequenceEqual(other.DnsAddresses)
                ) && 
                (
                    NtpAddresses == other.NtpAddresses ||
                    NtpAddresses != null &&
                    NtpAddresses.SequenceEqual(other.NtpAddresses)
                ) && 
                (
                    VcenterAddress == other.VcenterAddress ||
                    VcenterAddress != null &&
                    VcenterAddress.Equals(other.VcenterAddress)
                ) && 
                (
                    SmtpConfig == other.SmtpConfig ||
                    SmtpConfig != null &&
                    SmtpConfig.Equals(other.SmtpConfig)
                ) && 
                (
                    PhysicalSwitches == other.PhysicalSwitches ||
                    PhysicalSwitches != null &&
                    PhysicalSwitches.SequenceEqual(other.PhysicalSwitches)
                ) && 
                (
                    Force == other.Force ||
                    Force != null &&
                    Force.Equals(other.Force)
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
                    if (VlanId != null)
                    hashCode = hashCode * 59 + VlanId.GetHashCode();
                    if (Gateway != null)
                    hashCode = hashCode * 59 + Gateway.GetHashCode();
                    if (PrefixLength != null)
                    hashCode = hashCode * 59 + PrefixLength.GetHashCode();
                    if (ClusterMgmtAddress != null)
                    hashCode = hashCode * 59 + ClusterMgmtAddress.GetHashCode();
                    if (VasaProviderCredentials != null)
                    hashCode = hashCode * 59 + VasaProviderCredentials.GetHashCode();
                    if (EsxiCredentials != null)
                    hashCode = hashCode * 59 + EsxiCredentials.GetHashCode();
                    if (Mtu != null)
                    hashCode = hashCode * 59 + Mtu.GetHashCode();
                    if (IpPoolAddresses != null)
                    hashCode = hashCode * 59 + IpPoolAddresses.GetHashCode();
                    if (DnsAddresses != null)
                    hashCode = hashCode * 59 + DnsAddresses.GetHashCode();
                    if (NtpAddresses != null)
                    hashCode = hashCode * 59 + NtpAddresses.GetHashCode();
                    if (VcenterAddress != null)
                    hashCode = hashCode * 59 + VcenterAddress.GetHashCode();
                    if (SmtpConfig != null)
                    hashCode = hashCode * 59 + SmtpConfig.GetHashCode();
                    if (PhysicalSwitches != null)
                    hashCode = hashCode * 59 + PhysicalSwitches.GetHashCode();
                    if (Force != null)
                    hashCode = hashCode * 59 + Force.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NetworkReplace left, NetworkReplace right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NetworkReplace left, NetworkReplace right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
