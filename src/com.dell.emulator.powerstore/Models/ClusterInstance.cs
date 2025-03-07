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
    /// Properties of a cluster. Values was added in 2.0.0.0: primary_appliance_id. Values was deprecated in 2.0.0.0: master_appliance_id.
    /// </summary>
    [DataContract]
    public partial class ClusterInstance : IEquatable<ClusterInstance>
    { 
        /// <summary>
        /// The unique identifier of the cluster.
        /// </summary>
        /// <value>The unique identifier of the cluster.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// The global unique identifier of the cluster.
        /// </summary>
        /// <value>The global unique identifier of the cluster.</value>

        [DataMember(Name="global_id")]
        public string GlobalId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        /// <value>The name of the cluster.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The floating management IP address for the cluster in IPv4 or IPv6 format.
        /// </summary>
        /// <value>The floating management IP address for the cluster in IPv4 or IPv6 format.</value>

        [DataMember(Name="management_address")]
        public string ManagementAddress { get; set; }

        /// <summary>
        /// The floating storage discovery IP address for the cluster in IPv4 or IPv6 format. If multiple storage discovery addresses are configured, this property will be set to &#39;null&#39;. In this case the storage network of interest should be used to retrieve the discovery address. 
        /// </summary>
        /// <value>The floating storage discovery IP address for the cluster in IPv4 or IPv6 format. If multiple storage discovery addresses are configured, this property will be set to &#39;null&#39;. In this case the storage network of interest should be used to retrieve the discovery address. </value>

        [DataMember(Name="storage_discovery_address")]
        public string StorageDiscoveryAddress { get; set; }

        /// <summary>
        /// The unique identifier of the appliance acting as primary. Was deprecated in version 2.0.0.0.
        /// </summary>
        /// <value>The unique identifier of the appliance acting as primary. Was deprecated in version 2.0.0.0.</value>

        [DataMember(Name="master_appliance_id")]
        public string MasterApplianceId { get; set; }

        /// <summary>
        /// The unique identifier of the appliance acting as primary. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>The unique identifier of the appliance acting as primary. Was added in version 2.0.0.0.</value>

        [DataMember(Name="primary_appliance_id")]
        public string PrimaryApplianceId { get; set; }

        /// <summary>
        /// Number of appliances configured in this cluster.
        /// </summary>
        /// <value>Number of appliances configured in this cluster.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="appliance_count")]
        public int? ApplianceCount { get; set; }

        /// <summary>
        /// The physical ethernet port (eth_port resource) MTU setting is global for all ports in the cluster. This is the default MTU setting for IP traffic, and the upper limit on network-specific MTU settings (network resource), where this can be overridden for some specific kinds of traffic (management, data, and vMotion). 
        /// </summary>
        /// <value>The physical ethernet port (eth_port resource) MTU setting is global for all ports in the cluster. This is the default MTU setting for IP traffic, and the upper limit on network-specific MTU settings (network resource), where this can be overridden for some specific kinds of traffic (management, data, and vMotion). </value>

        [Range(0, 2147483647)]
        [DataMember(Name="physical_mtu")]
        public int? PhysicalMtu { get; set; }

        /// <summary>
        /// Whether or not Data at Rest Encryption is enabled on the cluster.
        /// </summary>
        /// <value>Whether or not Data at Rest Encryption is enabled on the cluster.</value>

        [DataMember(Name="is_encryption_enabled")]
        public bool? IsEncryptionEnabled { get; set; }

        /// <summary>
        /// The behavioral version of the software version API, and it is used to ensure the compatibility across potentially different software versions. 
        /// </summary>
        /// <value>The behavioral version of the software version API, and it is used to ensure the compatibility across potentially different software versions. </value>

        [Range(0, 2147483647)]
        [DataMember(Name="compatibility_level")]
        public int? CompatibilityLevel { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>

        [DataMember(Name="state")]
        public ClusterStateEnum? State { get; set; }

        /// <summary>
        /// Localized string corresponding to state.
        /// </summary>
        /// <value>Localized string corresponding to state.</value>

        [DataMember(Name="state_l10n")]
        public string StateL10n { get; set; }

        /// <summary>
        /// Current clock time for the system. System time and all the system reported times are in UTC (GMT+0:00) format. The system time is controlled via NTP. It cannot be set directly.  Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Current clock time for the system. System time and all the system reported times are in UTC (GMT+0:00) format. The system time is controlled via NTP. It cannot be set directly.  Was added in version 2.0.0.0.</value>

        [DataMember(Name="system_time")]
        public DateTime? SystemTime { get; set; }

        /// <summary>
        /// NVMe Subsystem NQN for cluster. It cannot be set directly. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>NVMe Subsystem NQN for cluster. It cannot be set directly. Was added in version 3.0.0.0.</value>

        [DataMember(Name="nvm_subsystem_nqn")]
        public string NvmSubsystemNqn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManagementAddress: ").Append(ManagementAddress).Append("\n");
            sb.Append("  StorageDiscoveryAddress: ").Append(StorageDiscoveryAddress).Append("\n");
            sb.Append("  MasterApplianceId: ").Append(MasterApplianceId).Append("\n");
            sb.Append("  PrimaryApplianceId: ").Append(PrimaryApplianceId).Append("\n");
            sb.Append("  ApplianceCount: ").Append(ApplianceCount).Append("\n");
            sb.Append("  PhysicalMtu: ").Append(PhysicalMtu).Append("\n");
            sb.Append("  IsEncryptionEnabled: ").Append(IsEncryptionEnabled).Append("\n");
            sb.Append("  CompatibilityLevel: ").Append(CompatibilityLevel).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateL10n: ").Append(StateL10n).Append("\n");
            sb.Append("  SystemTime: ").Append(SystemTime).Append("\n");
            sb.Append("  NvmSubsystemNqn: ").Append(NvmSubsystemNqn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ClusterInstance)obj);
        }

        /// <summary>
        /// Returns true if ClusterInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ClusterInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterInstance other)
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
                    GlobalId == other.GlobalId ||
                    GlobalId != null &&
                    GlobalId.Equals(other.GlobalId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ManagementAddress == other.ManagementAddress ||
                    ManagementAddress != null &&
                    ManagementAddress.Equals(other.ManagementAddress)
                ) && 
                (
                    StorageDiscoveryAddress == other.StorageDiscoveryAddress ||
                    StorageDiscoveryAddress != null &&
                    StorageDiscoveryAddress.Equals(other.StorageDiscoveryAddress)
                ) && 
                (
                    MasterApplianceId == other.MasterApplianceId ||
                    MasterApplianceId != null &&
                    MasterApplianceId.Equals(other.MasterApplianceId)
                ) && 
                (
                    PrimaryApplianceId == other.PrimaryApplianceId ||
                    PrimaryApplianceId != null &&
                    PrimaryApplianceId.Equals(other.PrimaryApplianceId)
                ) && 
                (
                    ApplianceCount == other.ApplianceCount ||
                    ApplianceCount != null &&
                    ApplianceCount.Equals(other.ApplianceCount)
                ) && 
                (
                    PhysicalMtu == other.PhysicalMtu ||
                    PhysicalMtu != null &&
                    PhysicalMtu.Equals(other.PhysicalMtu)
                ) && 
                (
                    IsEncryptionEnabled == other.IsEncryptionEnabled ||
                    IsEncryptionEnabled != null &&
                    IsEncryptionEnabled.Equals(other.IsEncryptionEnabled)
                ) && 
                (
                    CompatibilityLevel == other.CompatibilityLevel ||
                    CompatibilityLevel != null &&
                    CompatibilityLevel.Equals(other.CompatibilityLevel)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    StateL10n == other.StateL10n ||
                    StateL10n != null &&
                    StateL10n.Equals(other.StateL10n)
                ) && 
                (
                    SystemTime == other.SystemTime ||
                    SystemTime != null &&
                    SystemTime.Equals(other.SystemTime)
                ) && 
                (
                    NvmSubsystemNqn == other.NvmSubsystemNqn ||
                    NvmSubsystemNqn != null &&
                    NvmSubsystemNqn.Equals(other.NvmSubsystemNqn)
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
                    if (GlobalId != null)
                    hashCode = hashCode * 59 + GlobalId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ManagementAddress != null)
                    hashCode = hashCode * 59 + ManagementAddress.GetHashCode();
                    if (StorageDiscoveryAddress != null)
                    hashCode = hashCode * 59 + StorageDiscoveryAddress.GetHashCode();
                    if (MasterApplianceId != null)
                    hashCode = hashCode * 59 + MasterApplianceId.GetHashCode();
                    if (PrimaryApplianceId != null)
                    hashCode = hashCode * 59 + PrimaryApplianceId.GetHashCode();
                    if (ApplianceCount != null)
                    hashCode = hashCode * 59 + ApplianceCount.GetHashCode();
                    if (PhysicalMtu != null)
                    hashCode = hashCode * 59 + PhysicalMtu.GetHashCode();
                    if (IsEncryptionEnabled != null)
                    hashCode = hashCode * 59 + IsEncryptionEnabled.GetHashCode();
                    if (CompatibilityLevel != null)
                    hashCode = hashCode * 59 + CompatibilityLevel.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (StateL10n != null)
                    hashCode = hashCode * 59 + StateL10n.GetHashCode();
                    if (SystemTime != null)
                    hashCode = hashCode * 59 + SystemTime.GetHashCode();
                    if (NvmSubsystemNqn != null)
                    hashCode = hashCode * 59 + NvmSubsystemNqn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ClusterInstance left, ClusterInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ClusterInstance left, ClusterInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
