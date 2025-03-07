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
    /// Clone volume group request.
    /// </summary>
    [DataContract]
    public partial class VolumeGroupClone : IEquatable<VolumeGroupClone>
    { 
        /// <summary>
        /// Unique name for the clone volume group.
        /// </summary>
        /// <value>Unique name for the clone volume group.</value>
        [Required]
        
        [StringLength(128, MinimumLength=1)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Description for the clone volume group.  If description is not specified, the description for the snapshot set will not be set. 
        /// </summary>
        /// <value>Description for the clone volume group.  If description is not specified, the description for the snapshot set will not be set. </value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier of the protection policy you want to assign to the clone volume group.  name:{name} can be used instead of {id}. For example: &#39;protection_policy_id&#39;:&#39;name:policy_name&#39;
        /// </summary>
        /// <value>Unique identifier of the protection policy you want to assign to the clone volume group.  name:{name} can be used instead of {id}. For example: &#39;protection_policy_id&#39;:&#39;name:policy_name&#39;</value>

        [DataMember(Name="protection_policy_id")]
        public string ProtectionPolicyId { get; set; }

        /// <summary>
        /// Unique identifier of the QoS performance policy to assign to a volume group. If an empty string or null is specified, the QoS performance policy will be removed from the volume group.  name:{name} can be used instead of {id}. For example: &#39;qos_performance_policy_id&#39;:&#39;name:policy_name&#39; Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Unique identifier of the QoS performance policy to assign to a volume group. If an empty string or null is specified, the QoS performance policy will be removed from the volume group.  name:{name} can be used instead of {id}. For example: &#39;qos_performance_policy_id&#39;:&#39;name:policy_name&#39; Was added in version 4.0.0.0.</value>

        [DataMember(Name="qos_performance_policy_id")]
        public string QosPerformancePolicyId { get; set; }

        /// <summary>
        /// A boolean flag to indicate whether the clone volume group is a destination of a replication session.  This parameter defaults to false, if not specified.  Was deprecated in version 3.5.0.0.
        /// </summary>
        /// <value>A boolean flag to indicate whether the clone volume group is a destination of a replication session.  This parameter defaults to false, if not specified.  Was deprecated in version 3.5.0.0.</value>

        [DataMember(Name="is_replication_destination")]
        public bool? IsReplicationDestination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeGroupClone {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProtectionPolicyId: ").Append(ProtectionPolicyId).Append("\n");
            sb.Append("  QosPerformancePolicyId: ").Append(QosPerformancePolicyId).Append("\n");
            sb.Append("  IsReplicationDestination: ").Append(IsReplicationDestination).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VolumeGroupClone)obj);
        }

        /// <summary>
        /// Returns true if VolumeGroupClone instances are equal
        /// </summary>
        /// <param name="other">Instance of VolumeGroupClone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeGroupClone other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ProtectionPolicyId == other.ProtectionPolicyId ||
                    ProtectionPolicyId != null &&
                    ProtectionPolicyId.Equals(other.ProtectionPolicyId)
                ) && 
                (
                    QosPerformancePolicyId == other.QosPerformancePolicyId ||
                    QosPerformancePolicyId != null &&
                    QosPerformancePolicyId.Equals(other.QosPerformancePolicyId)
                ) && 
                (
                    IsReplicationDestination == other.IsReplicationDestination ||
                    IsReplicationDestination != null &&
                    IsReplicationDestination.Equals(other.IsReplicationDestination)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ProtectionPolicyId != null)
                    hashCode = hashCode * 59 + ProtectionPolicyId.GetHashCode();
                    if (QosPerformancePolicyId != null)
                    hashCode = hashCode * 59 + QosPerformancePolicyId.GetHashCode();
                    if (IsReplicationDestination != null)
                    hashCode = hashCode * 59 + IsReplicationDestination.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VolumeGroupClone left, VolumeGroupClone right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VolumeGroupClone left, VolumeGroupClone right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
