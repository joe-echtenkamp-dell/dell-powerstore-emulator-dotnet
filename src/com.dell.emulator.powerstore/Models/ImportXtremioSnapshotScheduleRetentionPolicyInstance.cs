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
    /// An instance of a snapshot schedule retention policy. Was added in version 1.0.2.
    /// </summary>
    [DataContract]
    public partial class ImportXtremioSnapshotScheduleRetentionPolicyInstance : IEquatable<ImportXtremioSnapshotScheduleRetentionPolicyInstance>
    { 
        /// <summary>
        /// Unique identifier of the snapshot schedule retention policy.
        /// </summary>
        /// <value>Unique identifier of the snapshot schedule retention policy.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the Retention Policy.
        /// </summary>
        /// <value>The name of the Retention Policy.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The duration of the short term period ranging from 1 to 500.
        /// </summary>
        /// <value>The duration of the short term period ranging from 1 to 500.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="short_period_duration")]
        public int? ShortPeriodDuration { get; set; }

        /// <summary>
        /// Gets or Sets ShortPeriodUnit
        /// </summary>

        [DataMember(Name="short_period_unit")]
        public XtremIODurationUnitEnum? ShortPeriodUnit { get; set; }

        /// <summary>
        /// The short term retention number of copies ranging from 1 to 500. The value of 0 indicates that this period is not in use. 
        /// </summary>
        /// <value>The short term retention number of copies ranging from 1 to 500. The value of 0 indicates that this period is not in use. </value>

        [Range(0, 500)]
        [DataMember(Name="short_retention_copies")]
        public int? ShortRetentionCopies { get; set; }

        /// <summary>
        /// The duration of the middle term period ranging from 1 to 500.
        /// </summary>
        /// <value>The duration of the middle term period ranging from 1 to 500.</value>

        [Range(1, 500)]
        [DataMember(Name="middle_period_duration")]
        public int? MiddlePeriodDuration { get; set; }

        /// <summary>
        /// Gets or Sets MiddlePeriodUnit
        /// </summary>

        [DataMember(Name="middle_period_unit")]
        public XtremIODurationUnitEnum? MiddlePeriodUnit { get; set; }

        /// <summary>
        /// The middle term retention number of copies ranging from 1 to 500. The value of 0 indicates that this period is not in use. 
        /// </summary>
        /// <value>The middle term retention number of copies ranging from 1 to 500. The value of 0 indicates that this period is not in use. </value>

        [Range(0, 500)]
        [DataMember(Name="middle_retention_copies")]
        public int? MiddleRetentionCopies { get; set; }

        /// <summary>
        /// The duration of the long term period ranging from 1 to 500.
        /// </summary>
        /// <value>The duration of the long term period ranging from 1 to 500.</value>

        [Range(1, 500)]
        [DataMember(Name="long_period_duration")]
        public int? LongPeriodDuration { get; set; }

        /// <summary>
        /// Gets or Sets LongPeriodUnit
        /// </summary>

        [DataMember(Name="long_period_unit")]
        public XtremIODurationUnitEnum? LongPeriodUnit { get; set; }

        /// <summary>
        /// The long term retention number of copies ranging from 1 to 500. The value of 0 indicates that this period is not in use. 
        /// </summary>
        /// <value>The long term retention number of copies ranging from 1 to 500. The value of 0 indicates that this period is not in use. </value>

        [Range(0, 500)]
        [DataMember(Name="long_retention_copies")]
        public int? LongRetentionCopies { get; set; }

        /// <summary>
        /// Localized message string corresponding to short_period_unit Was added in version 1.0.2.
        /// </summary>
        /// <value>Localized message string corresponding to short_period_unit Was added in version 1.0.2.</value>

        [DataMember(Name="short_period_unit_l10n")]
        public string ShortPeriodUnitL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to middle_period_unit Was added in version 1.0.2.
        /// </summary>
        /// <value>Localized message string corresponding to middle_period_unit Was added in version 1.0.2.</value>

        [DataMember(Name="middle_period_unit_l10n")]
        public string MiddlePeriodUnitL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to long_period_unit Was added in version 1.0.2.
        /// </summary>
        /// <value>Localized message string corresponding to long_period_unit Was added in version 1.0.2.</value>

        [DataMember(Name="long_period_unit_l10n")]
        public string LongPeriodUnitL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportXtremioSnapshotScheduleRetentionPolicyInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortPeriodDuration: ").Append(ShortPeriodDuration).Append("\n");
            sb.Append("  ShortPeriodUnit: ").Append(ShortPeriodUnit).Append("\n");
            sb.Append("  ShortRetentionCopies: ").Append(ShortRetentionCopies).Append("\n");
            sb.Append("  MiddlePeriodDuration: ").Append(MiddlePeriodDuration).Append("\n");
            sb.Append("  MiddlePeriodUnit: ").Append(MiddlePeriodUnit).Append("\n");
            sb.Append("  MiddleRetentionCopies: ").Append(MiddleRetentionCopies).Append("\n");
            sb.Append("  LongPeriodDuration: ").Append(LongPeriodDuration).Append("\n");
            sb.Append("  LongPeriodUnit: ").Append(LongPeriodUnit).Append("\n");
            sb.Append("  LongRetentionCopies: ").Append(LongRetentionCopies).Append("\n");
            sb.Append("  ShortPeriodUnitL10n: ").Append(ShortPeriodUnitL10n).Append("\n");
            sb.Append("  MiddlePeriodUnitL10n: ").Append(MiddlePeriodUnitL10n).Append("\n");
            sb.Append("  LongPeriodUnitL10n: ").Append(LongPeriodUnitL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportXtremioSnapshotScheduleRetentionPolicyInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportXtremioSnapshotScheduleRetentionPolicyInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportXtremioSnapshotScheduleRetentionPolicyInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportXtremioSnapshotScheduleRetentionPolicyInstance other)
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
                    ShortPeriodDuration == other.ShortPeriodDuration ||
                    ShortPeriodDuration != null &&
                    ShortPeriodDuration.Equals(other.ShortPeriodDuration)
                ) && 
                (
                    ShortPeriodUnit == other.ShortPeriodUnit ||
                    ShortPeriodUnit != null &&
                    ShortPeriodUnit.Equals(other.ShortPeriodUnit)
                ) && 
                (
                    ShortRetentionCopies == other.ShortRetentionCopies ||
                    ShortRetentionCopies != null &&
                    ShortRetentionCopies.Equals(other.ShortRetentionCopies)
                ) && 
                (
                    MiddlePeriodDuration == other.MiddlePeriodDuration ||
                    MiddlePeriodDuration != null &&
                    MiddlePeriodDuration.Equals(other.MiddlePeriodDuration)
                ) && 
                (
                    MiddlePeriodUnit == other.MiddlePeriodUnit ||
                    MiddlePeriodUnit != null &&
                    MiddlePeriodUnit.Equals(other.MiddlePeriodUnit)
                ) && 
                (
                    MiddleRetentionCopies == other.MiddleRetentionCopies ||
                    MiddleRetentionCopies != null &&
                    MiddleRetentionCopies.Equals(other.MiddleRetentionCopies)
                ) && 
                (
                    LongPeriodDuration == other.LongPeriodDuration ||
                    LongPeriodDuration != null &&
                    LongPeriodDuration.Equals(other.LongPeriodDuration)
                ) && 
                (
                    LongPeriodUnit == other.LongPeriodUnit ||
                    LongPeriodUnit != null &&
                    LongPeriodUnit.Equals(other.LongPeriodUnit)
                ) && 
                (
                    LongRetentionCopies == other.LongRetentionCopies ||
                    LongRetentionCopies != null &&
                    LongRetentionCopies.Equals(other.LongRetentionCopies)
                ) && 
                (
                    ShortPeriodUnitL10n == other.ShortPeriodUnitL10n ||
                    ShortPeriodUnitL10n != null &&
                    ShortPeriodUnitL10n.Equals(other.ShortPeriodUnitL10n)
                ) && 
                (
                    MiddlePeriodUnitL10n == other.MiddlePeriodUnitL10n ||
                    MiddlePeriodUnitL10n != null &&
                    MiddlePeriodUnitL10n.Equals(other.MiddlePeriodUnitL10n)
                ) && 
                (
                    LongPeriodUnitL10n == other.LongPeriodUnitL10n ||
                    LongPeriodUnitL10n != null &&
                    LongPeriodUnitL10n.Equals(other.LongPeriodUnitL10n)
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
                    if (ShortPeriodDuration != null)
                    hashCode = hashCode * 59 + ShortPeriodDuration.GetHashCode();
                    if (ShortPeriodUnit != null)
                    hashCode = hashCode * 59 + ShortPeriodUnit.GetHashCode();
                    if (ShortRetentionCopies != null)
                    hashCode = hashCode * 59 + ShortRetentionCopies.GetHashCode();
                    if (MiddlePeriodDuration != null)
                    hashCode = hashCode * 59 + MiddlePeriodDuration.GetHashCode();
                    if (MiddlePeriodUnit != null)
                    hashCode = hashCode * 59 + MiddlePeriodUnit.GetHashCode();
                    if (MiddleRetentionCopies != null)
                    hashCode = hashCode * 59 + MiddleRetentionCopies.GetHashCode();
                    if (LongPeriodDuration != null)
                    hashCode = hashCode * 59 + LongPeriodDuration.GetHashCode();
                    if (LongPeriodUnit != null)
                    hashCode = hashCode * 59 + LongPeriodUnit.GetHashCode();
                    if (LongRetentionCopies != null)
                    hashCode = hashCode * 59 + LongRetentionCopies.GetHashCode();
                    if (ShortPeriodUnitL10n != null)
                    hashCode = hashCode * 59 + ShortPeriodUnitL10n.GetHashCode();
                    if (MiddlePeriodUnitL10n != null)
                    hashCode = hashCode * 59 + MiddlePeriodUnitL10n.GetHashCode();
                    if (LongPeriodUnitL10n != null)
                    hashCode = hashCode * 59 + LongPeriodUnitL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportXtremioSnapshotScheduleRetentionPolicyInstance left, ImportXtremioSnapshotScheduleRetentionPolicyInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportXtremioSnapshotScheduleRetentionPolicyInstance left, ImportXtremioSnapshotScheduleRetentionPolicyInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
