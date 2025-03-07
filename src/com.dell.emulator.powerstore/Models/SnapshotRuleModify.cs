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
    /// Modify a snapshot rule. If the snapshot rule is associated with a policy that is currently applied to a storage resource, the modified rule is immediately applied to the associated storage resource. 
    /// </summary>
    [DataContract]
    public partial class SnapshotRuleModify : IEquatable<SnapshotRuleModify>
    { 
        /// <summary>
        /// Snapshot rule name.
        /// </summary>
        /// <value>Snapshot rule name.</value>

        [StringLength(128, MinimumLength=1)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier for the PowerProtect DD remote system. If present, the associated volume/volume group is backed up to specified PowerProtect DD remote system, else a local snapshot is taken. This attribute can be modified only if existing value is non null and the associated policy is not attached to a volume or a volume group. The rule intended to take snapshots locally cannot be converted to take snapshots on a PowerProtect DD remote system and vice versa.  name:{name} can be used instead of {id}. For example: &#39;remote_system_id&#39;:&#39;name:remote_system_name&#39; Was added in version 3.5.0.0.
        /// </summary>
        /// <value>Unique identifier for the PowerProtect DD remote system. If present, the associated volume/volume group is backed up to specified PowerProtect DD remote system, else a local snapshot is taken. This attribute can be modified only if existing value is non null and the associated policy is not attached to a volume or a volume group. The rule intended to take snapshots locally cannot be converted to take snapshots on a PowerProtect DD remote system and vice versa.  name:{name} can be used instead of {id}. For example: &#39;remote_system_id&#39;:&#39;name:remote_system_name&#39; Was added in version 3.5.0.0.</value>

        [DataMember(Name="remote_system_id")]
        public string RemoteSystemId { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>

        [DataMember(Name="interval")]
        public SnapRuleIntervalEnum? Interval { get; set; }

        /// <summary>
        /// Time of the day to take a daily snapshot, with format \&quot;hh:mm\&quot; using a 24 hour clock. Either the interval parameter or the time_of_day parameter will be set, but not both. 
        /// </summary>
        /// <value>Time of the day to take a daily snapshot, with format \&quot;hh:mm\&quot; using a 24 hour clock. Either the interval parameter or the time_of_day parameter will be set, but not both. </value>

        [DataMember(Name="time_of_day")]
        public string TimeOfDay { get; set; }

        /// <summary>
        ///  Was added in version 2.0.0.0.
        /// </summary>
        /// <value> Was added in version 2.0.0.0.</value>

        [DataMember(Name="timezone")]
        public TimeZoneEnum? Timezone { get; set; }

        /// <summary>
        /// Days of the week when the snapshot rule should be applied. Days are determined based on the UTC time zone, unless the time_of_day and timezone properties are set. 
        /// </summary>
        /// <value>Days of the week when the snapshot rule should be applied. Days are determined based on the UTC time zone, unless the time_of_day and timezone properties are set. </value>

        [DataMember(Name="days_of_week")]
        public List<DaysOfWeekEnum> DaysOfWeek { get; set; }

        /// <summary>
        /// Desired snapshot retention period in hours. The system will retain snapshots for this time period. The maximum retention is 70 years for remote snapshot rules and 1 year for local snapshot rules. 
        /// </summary>
        /// <value>Desired snapshot retention period in hours. The system will retain snapshots for this time period. The maximum retention is 70 years for remote snapshot rules and 1 year for local snapshot rules. </value>

        [Range(1, 613200)]
        [DataMember(Name="desired_retention")]
        public int? DesiredRetention { get; set; }

        /// <summary>
        /// The access type for file snapshots created by this snapshot rule. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>The access type for file snapshots created by this snapshot rule. Was added in version 3.0.0.0.</value>

        [DataMember(Name="nas_access_type")]
        public NASAccessTypeEnum? NasAccessType { get; set; }

        /// <summary>
        /// Secure snapshots are created by the rule if this flag is true. The snapshots cannot be deleted until the expiration time, and the expiration time cannot be reduced. Secure snapshots will only be created for block volume and volume group storage resources. Snapshots already created by this rule will not have their is_secure attribute modified.  Was added in version 3.5.0.0.
        /// </summary>
        /// <value>Secure snapshots are created by the rule if this flag is true. The snapshots cannot be deleted until the expiration time, and the expiration time cannot be reduced. Secure snapshots will only be created for block volume and volume group storage resources. Snapshots already created by this rule will not have their is_secure attribute modified.  Was added in version 3.5.0.0.</value>

        [DataMember(Name="is_secure")]
        public bool? IsSecure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotRuleModify {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RemoteSystemId: ").Append(RemoteSystemId).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  TimeOfDay: ").Append(TimeOfDay).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("  DesiredRetention: ").Append(DesiredRetention).Append("\n");
            sb.Append("  NasAccessType: ").Append(NasAccessType).Append("\n");
            sb.Append("  IsSecure: ").Append(IsSecure).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SnapshotRuleModify)obj);
        }

        /// <summary>
        /// Returns true if SnapshotRuleModify instances are equal
        /// </summary>
        /// <param name="other">Instance of SnapshotRuleModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotRuleModify other)
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
                    RemoteSystemId == other.RemoteSystemId ||
                    RemoteSystemId != null &&
                    RemoteSystemId.Equals(other.RemoteSystemId)
                ) && 
                (
                    Interval == other.Interval ||
                    Interval != null &&
                    Interval.Equals(other.Interval)
                ) && 
                (
                    TimeOfDay == other.TimeOfDay ||
                    TimeOfDay != null &&
                    TimeOfDay.Equals(other.TimeOfDay)
                ) && 
                (
                    Timezone == other.Timezone ||
                    Timezone != null &&
                    Timezone.Equals(other.Timezone)
                ) && 
                (
                    DaysOfWeek == other.DaysOfWeek ||
                    DaysOfWeek != null &&
                    DaysOfWeek.SequenceEqual(other.DaysOfWeek)
                ) && 
                (
                    DesiredRetention == other.DesiredRetention ||
                    DesiredRetention != null &&
                    DesiredRetention.Equals(other.DesiredRetention)
                ) && 
                (
                    NasAccessType == other.NasAccessType ||
                    NasAccessType != null &&
                    NasAccessType.Equals(other.NasAccessType)
                ) && 
                (
                    IsSecure == other.IsSecure ||
                    IsSecure != null &&
                    IsSecure.Equals(other.IsSecure)
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
                    if (RemoteSystemId != null)
                    hashCode = hashCode * 59 + RemoteSystemId.GetHashCode();
                    if (Interval != null)
                    hashCode = hashCode * 59 + Interval.GetHashCode();
                    if (TimeOfDay != null)
                    hashCode = hashCode * 59 + TimeOfDay.GetHashCode();
                    if (Timezone != null)
                    hashCode = hashCode * 59 + Timezone.GetHashCode();
                    if (DaysOfWeek != null)
                    hashCode = hashCode * 59 + DaysOfWeek.GetHashCode();
                    if (DesiredRetention != null)
                    hashCode = hashCode * 59 + DesiredRetention.GetHashCode();
                    if (NasAccessType != null)
                    hashCode = hashCode * 59 + NasAccessType.GetHashCode();
                    if (IsSecure != null)
                    hashCode = hashCode * 59 + IsSecure.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SnapshotRuleModify left, SnapshotRuleModify right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SnapshotRuleModify left, SnapshotRuleModify right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
