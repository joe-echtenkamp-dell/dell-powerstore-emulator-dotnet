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
    /// Request to add members to a volume group.
    /// </summary>
    [DataContract]
    public partial class VolumeGroupAddMembers : IEquatable<VolumeGroupAddMembers>
    { 
        /// <summary>
        /// A list of primary or clone volumes to be added to the volume group. Snapshots cannot be added to a volume group. All the volumes should be on the same appliance as the current members of the volume group.  This list cannot be empty. 
        /// </summary>
        /// <value>A list of primary or clone volumes to be added to the volume group. Snapshots cannot be added to a volume group. All the volumes should be on the same appliance as the current members of the volume group.  This list cannot be empty. </value>
        [Required]
        
        [DataMember(Name="volume_ids")]
        public List<string> VolumeIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeGroupAddMembers {\n");
            sb.Append("  VolumeIds: ").Append(VolumeIds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VolumeGroupAddMembers)obj);
        }

        /// <summary>
        /// Returns true if VolumeGroupAddMembers instances are equal
        /// </summary>
        /// <param name="other">Instance of VolumeGroupAddMembers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeGroupAddMembers other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VolumeIds == other.VolumeIds ||
                    VolumeIds != null &&
                    VolumeIds.SequenceEqual(other.VolumeIds)
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
                    if (VolumeIds != null)
                    hashCode = hashCode * 59 + VolumeIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VolumeGroupAddMembers left, VolumeGroupAddMembers right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VolumeGroupAddMembers left, VolumeGroupAddMembers right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
