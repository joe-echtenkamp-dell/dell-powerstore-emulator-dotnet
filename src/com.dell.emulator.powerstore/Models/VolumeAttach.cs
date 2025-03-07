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
    /// Parameters for the volume attach operation.
    /// </summary>
    [DataContract]
    public partial class VolumeAttach : IEquatable<VolumeAttach>
    { 
        /// <summary>
        /// Unique identifier of the host to be attached to the volume. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_id&#39;:&#39;name:host_name&#39;
        /// </summary>
        /// <value>Unique identifier of the host to be attached to the volume. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_id&#39;:&#39;name:host_name&#39;</value>

        [DataMember(Name="host_id")]
        public string HostId { get; set; }

        /// <summary>
        /// Unique identifier of the host group to be attached to the volume. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_group_id&#39;:&#39;name:host_group_name&#39;
        /// </summary>
        /// <value>Unique identifier of the host group to be attached to the volume. Only one of host_id or host_group_id can be supplied.  name:{name} can be used instead of {id}. For example: &#39;host_group_id&#39;:&#39;name:host_group_name&#39;</value>

        [DataMember(Name="host_group_id")]
        public string HostGroupId { get; set; }

        /// <summary>
        /// Logical unit number for the host volume access.
        /// </summary>
        /// <value>Logical unit number for the host volume access.</value>

        [Range(0, 16383)]
        [DataMember(Name="logical_unit_number")]
        public int? LogicalUnitNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeAttach {\n");
            sb.Append("  HostId: ").Append(HostId).Append("\n");
            sb.Append("  HostGroupId: ").Append(HostGroupId).Append("\n");
            sb.Append("  LogicalUnitNumber: ").Append(LogicalUnitNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VolumeAttach)obj);
        }

        /// <summary>
        /// Returns true if VolumeAttach instances are equal
        /// </summary>
        /// <param name="other">Instance of VolumeAttach to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeAttach other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    if (HostId != null)
                    hashCode = hashCode * 59 + HostId.GetHashCode();
                    if (HostGroupId != null)
                    hashCode = hashCode * 59 + HostGroupId.GetHashCode();
                    if (LogicalUnitNumber != null)
                    hashCode = hashCode * 59 + LogicalUnitNumber.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VolumeAttach left, VolumeAttach right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VolumeAttach left, VolumeAttach right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
