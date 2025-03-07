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
    /// Modify a replication rule.   If the replication rule is associated with a policy that is currently applied to a storage resource, the modified rule is immediately applied to the associated storage resource.  However, changing the remote_system_id is not allowed if the replication rule is included in a policy that is currently applied to a storage resource.   To change the remote_system_id in this case, please follow one of the following procedures:    * Unassign the protection policy from the relevant storage resources, modify the replication rule, and then re-assign the protection policy to the relevant storage resources.    * Remove the replication rule from the protection policies that use it, modify the replication rule, and then add it back to the relevant protection policies.   When modifying RPO of a replication rule to Zero, the remote system must also support RPO value of Zero, meaning it has the capability of Synchronous_Block_Replication.  Zero RPO is only supported for volumes, write-order-consistent volume groups, and NAS servers. If a replication rule is used by storage resources through one or more protection policies,  RPO of a replication rule can only be modified to Zero when the system supports RPO Zero for all current associated storage resources.  Modification of the &#39;rpo&#39; value to or from Zero (sync replication) is not allowed when the rule is in use by a policy assigned to a NAS server. Create a new replication rule and protection policy instead. 
    /// </summary>
    [DataContract]
    public partial class ReplicationRuleModify : IEquatable<ReplicationRuleModify>
    { 
        /// <summary>
        /// Name of the replication rule.
        /// </summary>
        /// <value>Name of the replication rule.</value>

        [StringLength(128, MinimumLength=1)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Rpo
        /// </summary>

        [DataMember(Name="rpo")]
        public RPOEnum? Rpo { get; set; }

        /// <summary>
        /// Unique identifier of the remote system to which this replication rule will replicate the associated storage resources.  name:{name} can be used instead of {id}. For example: &#39;remote_system_id&#39;:&#39;name:remote_system_name&#39;
        /// </summary>
        /// <value>Unique identifier of the remote system to which this replication rule will replicate the associated storage resources.  name:{name} can be used instead of {id}. For example: &#39;remote_system_id&#39;:&#39;name:remote_system_name&#39;</value>

        [DataMember(Name="remote_system_id")]
        public string RemoteSystemId { get; set; }

        /// <summary>
        /// Number of minutes the system will wait before generating a compliance alert when a replication session does not meet the RPO. 
        /// </summary>
        /// <value>Number of minutes the system will wait before generating a compliance alert when a replication session does not meet the RPO. </value>

        [Range(0, 1440)]
        [DataMember(Name="alert_threshold")]
        public int? AlertThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplicationRuleModify {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rpo: ").Append(Rpo).Append("\n");
            sb.Append("  RemoteSystemId: ").Append(RemoteSystemId).Append("\n");
            sb.Append("  AlertThreshold: ").Append(AlertThreshold).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ReplicationRuleModify)obj);
        }

        /// <summary>
        /// Returns true if ReplicationRuleModify instances are equal
        /// </summary>
        /// <param name="other">Instance of ReplicationRuleModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicationRuleModify other)
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
                    Rpo == other.Rpo ||
                    Rpo != null &&
                    Rpo.Equals(other.Rpo)
                ) && 
                (
                    RemoteSystemId == other.RemoteSystemId ||
                    RemoteSystemId != null &&
                    RemoteSystemId.Equals(other.RemoteSystemId)
                ) && 
                (
                    AlertThreshold == other.AlertThreshold ||
                    AlertThreshold != null &&
                    AlertThreshold.Equals(other.AlertThreshold)
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
                    if (Rpo != null)
                    hashCode = hashCode * 59 + Rpo.GetHashCode();
                    if (RemoteSystemId != null)
                    hashCode = hashCode * 59 + RemoteSystemId.GetHashCode();
                    if (AlertThreshold != null)
                    hashCode = hashCode * 59 + AlertThreshold.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ReplicationRuleModify left, ReplicationRuleModify right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ReplicationRuleModify left, ReplicationRuleModify right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
