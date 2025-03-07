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
    /// An instance of a snapshot policy. Was added in version 3.0.0.0.
    /// </summary>
    [DataContract]
    public partial class ImportVmaxSnapshotPolicyInstance : IEquatable<ImportVmaxSnapshotPolicyInstance>
    { 
        /// <summary>
        /// The Name of the VMAX snapshot policy.
        /// </summary>
        /// <value>The Name of the VMAX snapshot policy.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The number of snapshots that will be taken before the oldest ones are no longer required.
        /// </summary>
        /// <value>The number of snapshots that will be taken before the oldest ones are no longer required.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="snapshot_count")]
        public int? SnapshotCount { get; set; }

        /// <summary>
        /// The number of minutes between each policy execution.
        /// </summary>
        /// <value>The number of minutes between each policy execution.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="interval_minutes")]
        public int? IntervalMinutes { get; set; }

        /// <summary>
        /// The number of minutes after 00:00 on Monday morning that the policy will execute.
        /// </summary>
        /// <value>The number of minutes after 00:00 on Monday morning that the policy will execute.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="offset_minutes")]
        public int? OffsetMinutes { get; set; }

        /// <summary>
        /// The name of the cloud provider associated with this policy. Only applies to cloud policies.
        /// </summary>
        /// <value>The name of the cloud provider associated with this policy. Only applies to cloud policies.</value>

        [DataMember(Name="provider_name")]
        public string ProviderName { get; set; }

        /// <summary>
        /// The number of days that snapshots will be retained in the cloud for. Only applies to cloud policies.
        /// </summary>
        /// <value>The number of days that snapshots will be retained in the cloud for. Only applies to cloud policies.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Set if the snapshot policy has been suspended.
        /// </summary>
        /// <value>Set if the snapshot policy has been suspended.</value>

        [DataMember(Name="suspended")]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Set if the snapshot policy creates secure snapshots.
        /// </summary>
        /// <value>Set if the snapshot policy creates secure snapshots.</value>

        [DataMember(Name="secure")]
        public bool? Secure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportVmaxSnapshotPolicyInstance {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SnapshotCount: ").Append(SnapshotCount).Append("\n");
            sb.Append("  IntervalMinutes: ").Append(IntervalMinutes).Append("\n");
            sb.Append("  OffsetMinutes: ").Append(OffsetMinutes).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  RetentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportVmaxSnapshotPolicyInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportVmaxSnapshotPolicyInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportVmaxSnapshotPolicyInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportVmaxSnapshotPolicyInstance other)
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
                    SnapshotCount == other.SnapshotCount ||
                    SnapshotCount != null &&
                    SnapshotCount.Equals(other.SnapshotCount)
                ) && 
                (
                    IntervalMinutes == other.IntervalMinutes ||
                    IntervalMinutes != null &&
                    IntervalMinutes.Equals(other.IntervalMinutes)
                ) && 
                (
                    OffsetMinutes == other.OffsetMinutes ||
                    OffsetMinutes != null &&
                    OffsetMinutes.Equals(other.OffsetMinutes)
                ) && 
                (
                    ProviderName == other.ProviderName ||
                    ProviderName != null &&
                    ProviderName.Equals(other.ProviderName)
                ) && 
                (
                    RetentionDays == other.RetentionDays ||
                    RetentionDays != null &&
                    RetentionDays.Equals(other.RetentionDays)
                ) && 
                (
                    Suspended == other.Suspended ||
                    Suspended != null &&
                    Suspended.Equals(other.Suspended)
                ) && 
                (
                    Secure == other.Secure ||
                    Secure != null &&
                    Secure.Equals(other.Secure)
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
                    if (SnapshotCount != null)
                    hashCode = hashCode * 59 + SnapshotCount.GetHashCode();
                    if (IntervalMinutes != null)
                    hashCode = hashCode * 59 + IntervalMinutes.GetHashCode();
                    if (OffsetMinutes != null)
                    hashCode = hashCode * 59 + OffsetMinutes.GetHashCode();
                    if (ProviderName != null)
                    hashCode = hashCode * 59 + ProviderName.GetHashCode();
                    if (RetentionDays != null)
                    hashCode = hashCode * 59 + RetentionDays.GetHashCode();
                    if (Suspended != null)
                    hashCode = hashCode * 59 + Suspended.GetHashCode();
                    if (Secure != null)
                    hashCode = hashCode * 59 + Secure.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportVmaxSnapshotPolicyInstance left, ImportVmaxSnapshotPolicyInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportVmaxSnapshotPolicyInstance left, ImportVmaxSnapshotPolicyInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
