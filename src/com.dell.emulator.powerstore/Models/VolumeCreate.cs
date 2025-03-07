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
    /// Parameters for the volume create operation.
    /// </summary>
    [DataContract]
    public partial class VolumeCreate : IEquatable<VolumeCreate>
    { 
        /// <summary>
        /// Unique name for the volume to be created. This value must contain 128 or fewer printable Unicode characters. 
        /// </summary>
        /// <value>Unique name for the volume to be created. This value must contain 128 or fewer printable Unicode characters. </value>
        [Required]
        
        [MaxLength(128)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Size of the volume to be created, in bytes. Minimum volume size is 1MB. Maximum volume size is 256TB. Size must be a multiple of 8192. 
        /// </summary>
        /// <value>Size of the volume to be created, in bytes. Minimum volume size is 1MB. Maximum volume size is 256TB. Size must be a multiple of 8192. </value>
        [Required]
        
        [Range(1048576, 281474976710656)]
        [DataMember(Name="size")]
        public long? Size { get; set; }

        /// <summary>
        /// Unique identifier of the host to be attached to the volume. If not specified, an unmapped volume is created. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_id&#39;:&#39;name:host_name&#39;
        /// </summary>
        /// <value>Unique identifier of the host to be attached to the volume. If not specified, an unmapped volume is created. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_id&#39;:&#39;name:host_name&#39;</value>

        [DataMember(Name="host_id")]
        public string HostId { get; set; }

        /// <summary>
        /// Unique identifier of the host group to be attached to the volume. If not specified, an unmapped volume is created. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_group_id&#39;:&#39;name:host_group_name&#39;
        /// </summary>
        /// <value>Unique identifier of the host group to be attached to the volume. If not specified, an unmapped volume is created. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_group_id&#39;:&#39;name:host_group_name&#39;</value>

        [DataMember(Name="host_group_id")]
        public string HostGroupId { get; set; }

        /// <summary>
        /// Optional logical unit number when creating a  attached volume.  If no host_id or host_group_id is specified, this property is ignored. 
        /// </summary>
        /// <value>Optional logical unit number when creating a  attached volume.  If no host_id or host_group_id is specified, this property is ignored. </value>

        [Range(0, 16383)]
        [DataMember(Name="logical_unit_number")]
        public int? LogicalUnitNumber { get; set; }

        /// <summary>
        /// Description of the volume. This value must contain 128 or fewer printable Unicode characters. 
        /// </summary>
        /// <value>Description of the volume. This value must contain 128 or fewer printable Unicode characters. </value>

        [MaxLength(128)]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Identifier of the appliance on which the volume is provisioned.  name:{name} can be used instead of {id}. For example: &#39;appliance_id&#39;:&#39;name:appliance_name&#39;
        /// </summary>
        /// <value>Identifier of the appliance on which the volume is provisioned.  name:{name} can be used instead of {id}. For example: &#39;appliance_id&#39;:&#39;name:appliance_name&#39;</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Volume group to add the volume to.  If not specified, the volume is not added to a volume group.  name:{name} can be used instead of {id}. For example: &#39;volume_group_id&#39;:&#39;name:volume_group_name&#39;
        /// </summary>
        /// <value>Volume group to add the volume to.  If not specified, the volume is not added to a volume group.  name:{name} can be used instead of {id}. For example: &#39;volume_group_id&#39;:&#39;name:volume_group_name&#39;</value>

        [DataMember(Name="volume_group_id")]
        public string VolumeGroupId { get; set; }

        /// <summary>
        /// Optional minimum size for the volume, in bytes.
        /// </summary>
        /// <value>Optional minimum size for the volume, in bytes.</value>

        [Range(1048576, 281474976710656)]
        [DataMember(Name="min_size")]
        public long? MinSize { get; set; }

        /// <summary>
        /// Optional sector size, in bytes. Only 512-byte and 4096-byte sectors are supported. 
        /// </summary>
        /// <value>Optional sector size, in bytes. Only 512-byte and 4096-byte sectors are supported. </value>

        [Range(512, 4096)]
        [DataMember(Name="sector_size")]
        public int? SectorSize { get; set; }

        /// <summary>
        /// Unique identifier of the protection policy assigned to the volume. name:{name} can be used instead of {id}. For example: &#39;protection_policy_id&#39;:&#39;name:policy_name&#39;
        /// </summary>
        /// <value>Unique identifier of the protection policy assigned to the volume. name:{name} can be used instead of {id}. For example: &#39;protection_policy_id&#39;:&#39;name:policy_name&#39;</value>

        [DataMember(Name="protection_policy_id")]
        public string ProtectionPolicyId { get; set; }

        /// <summary>
        /// Unique identifier of the performance policy assigned to the volume. name:{name} can be used instead of {id}. For example: &#39;performance_policy_id&#39;:&#39;name:policy_name&#39;
        /// </summary>
        /// <value>Unique identifier of the performance policy assigned to the volume. name:{name} can be used instead of {id}. For example: &#39;performance_policy_id&#39;:&#39;name:policy_name&#39;</value>

        [DataMember(Name="performance_policy_id")]
        public string PerformancePolicyId { get; set; }

        /// <summary>
        /// Unique identifier of the QoS performance policy assigned to the volume. name:{name} can be used instead of {id}. For example: &#39;qos_performance_policy_id&#39;:&#39;name:policy_name&#39; Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Unique identifier of the QoS performance policy assigned to the volume. name:{name} can be used instead of {id}. For example: &#39;qos_performance_policy_id&#39;:&#39;name:policy_name&#39; Was added in version 4.0.0.0.</value>

        [DataMember(Name="qos_performance_policy_id")]
        public string QosPerformancePolicyId { get; set; }

        /// <summary>
        ///  Was added in version 2.1.0.0.
        /// </summary>
        /// <value> Was added in version 2.1.0.0.</value>

        [DataMember(Name="app_type")]
        public AppTypeEnum? AppType { get; set; }

        /// <summary>
        /// An optional field used to describe application type usage for a volume. This field can only be set if app_type is set to Relational_Databases_Other, Big_Data_Analytics_Other, Business_Applications_Other, Healthcare_Other, Virtualization_Other or Other. If the app_type attribute is set to anything other than one of these values, the attribute will be cleared.  Was added in version 2.1.0.0.
        /// </summary>
        /// <value>An optional field used to describe application type usage for a volume. This field can only be set if app_type is set to Relational_Databases_Other, Big_Data_Analytics_Other, Business_Applications_Other, Healthcare_Other, Virtualization_Other or Other. If the app_type attribute is set to anything other than one of these values, the attribute will be cleared.  Was added in version 2.1.0.0.</value>

        [MaxLength(32)]
        [DataMember(Name="app_type_other")]
        public string AppTypeOther { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  HostId: ").Append(HostId).Append("\n");
            sb.Append("  HostGroupId: ").Append(HostGroupId).Append("\n");
            sb.Append("  LogicalUnitNumber: ").Append(LogicalUnitNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  VolumeGroupId: ").Append(VolumeGroupId).Append("\n");
            sb.Append("  MinSize: ").Append(MinSize).Append("\n");
            sb.Append("  SectorSize: ").Append(SectorSize).Append("\n");
            sb.Append("  ProtectionPolicyId: ").Append(ProtectionPolicyId).Append("\n");
            sb.Append("  PerformancePolicyId: ").Append(PerformancePolicyId).Append("\n");
            sb.Append("  QosPerformancePolicyId: ").Append(QosPerformancePolicyId).Append("\n");
            sb.Append("  AppType: ").Append(AppType).Append("\n");
            sb.Append("  AppTypeOther: ").Append(AppTypeOther).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VolumeCreate)obj);
        }

        /// <summary>
        /// Returns true if VolumeCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of VolumeCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeCreate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    HostId == other.HostId ||
                    HostId != null &&
                    HostId.Equals(other.HostId)
                ) && 
                (
                    HostGroupId == other.HostGroupId ||
                    HostGroupId != null &&
                    HostGroupId.Equals(other.HostGroupId)
                ) && 
                (
                    LogicalUnitNumber == other.LogicalUnitNumber ||
                    LogicalUnitNumber != null &&
                    LogicalUnitNumber.Equals(other.LogicalUnitNumber)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    VolumeGroupId == other.VolumeGroupId ||
                    VolumeGroupId != null &&
                    VolumeGroupId.Equals(other.VolumeGroupId)
                ) && 
                (
                    MinSize == other.MinSize ||
                    MinSize != null &&
                    MinSize.Equals(other.MinSize)
                ) && 
                (
                    SectorSize == other.SectorSize ||
                    SectorSize != null &&
                    SectorSize.Equals(other.SectorSize)
                ) && 
                (
                    ProtectionPolicyId == other.ProtectionPolicyId ||
                    ProtectionPolicyId != null &&
                    ProtectionPolicyId.Equals(other.ProtectionPolicyId)
                ) && 
                (
                    PerformancePolicyId == other.PerformancePolicyId ||
                    PerformancePolicyId != null &&
                    PerformancePolicyId.Equals(other.PerformancePolicyId)
                ) && 
                (
                    QosPerformancePolicyId == other.QosPerformancePolicyId ||
                    QosPerformancePolicyId != null &&
                    QosPerformancePolicyId.Equals(other.QosPerformancePolicyId)
                ) && 
                (
                    AppType == other.AppType ||
                    AppType != null &&
                    AppType.Equals(other.AppType)
                ) && 
                (
                    AppTypeOther == other.AppTypeOther ||
                    AppTypeOther != null &&
                    AppTypeOther.Equals(other.AppTypeOther)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                    if (HostId != null)
                    hashCode = hashCode * 59 + HostId.GetHashCode();
                    if (HostGroupId != null)
                    hashCode = hashCode * 59 + HostGroupId.GetHashCode();
                    if (LogicalUnitNumber != null)
                    hashCode = hashCode * 59 + LogicalUnitNumber.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (VolumeGroupId != null)
                    hashCode = hashCode * 59 + VolumeGroupId.GetHashCode();
                    if (MinSize != null)
                    hashCode = hashCode * 59 + MinSize.GetHashCode();
                    if (SectorSize != null)
                    hashCode = hashCode * 59 + SectorSize.GetHashCode();
                    if (ProtectionPolicyId != null)
                    hashCode = hashCode * 59 + ProtectionPolicyId.GetHashCode();
                    if (PerformancePolicyId != null)
                    hashCode = hashCode * 59 + PerformancePolicyId.GetHashCode();
                    if (QosPerformancePolicyId != null)
                    hashCode = hashCode * 59 + QosPerformancePolicyId.GetHashCode();
                    if (AppType != null)
                    hashCode = hashCode * 59 + AppType.GetHashCode();
                    if (AppTypeOther != null)
                    hashCode = hashCode * 59 + AppTypeOther.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VolumeCreate left, VolumeCreate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VolumeCreate left, VolumeCreate right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
