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
    /// Summary of cluster level space metric data for a specific period of time, beginning with timestamp, including the maximum and final values for that period. Current support is for a time period of one hour and one day.
    /// </summary>
    [DataContract]
    public partial class BaseSpaceMetricsByClusterRollup : IEquatable<BaseSpaceMetricsByClusterRollup>
    { 
        /// <summary>
        /// Identifier of the cluster.
        /// </summary>
        /// <value>Identifier of the cluster.</value>

        [DataMember(Name="cluster_id")]
        public string ClusterId { get; set; }

        /// <summary>
        /// End of sample period.
        /// </summary>
        /// <value>End of sample period.</value>

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Last logical total space during the period.
        /// </summary>
        /// <value>Last logical total space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_logical_provisioned")]
        public long? LastLogicalProvisioned { get; set; }

        /// <summary>
        /// Last logical used space during the period.
        /// </summary>
        /// <value>Last logical used space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_logical_used")]
        public long? LastLogicalUsed { get; set; }

        /// <summary>
        /// Last logical used space for block volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Last logical used space for block volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_logical_used_volume")]
        public long? LastLogicalUsedVolume { get; set; }

        /// <summary>
        /// Last logical used space for file systems during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Last logical used space for file systems during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_logical_used_file_system")]
        public long? LastLogicalUsedFileSystem { get; set; }

        /// <summary>
        /// Last logical used space for virtual volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Last logical used space for virtual volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_logical_used_vvol")]
        public long? LastLogicalUsedVvol { get; set; }

        /// <summary>
        /// Last shared logical used space for block volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Last shared logical used space for block volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_shared_logical_used_volume")]
        public long? LastSharedLogicalUsedVolume { get; set; }

        /// <summary>
        /// Last shared logical used space for file systems during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Last shared logical used space for file systems during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_shared_logical_used_file_system")]
        public long? LastSharedLogicalUsedFileSystem { get; set; }

        /// <summary>
        /// Last shared logical used space for virtual volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Last shared logical used space for virtual volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_shared_logical_used_vvol")]
        public long? LastSharedLogicalUsedVvol { get; set; }

        /// <summary>
        /// Last physical total space during the period.
        /// </summary>
        /// <value>Last physical total space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_physical_total")]
        public long? LastPhysicalTotal { get; set; }

        /// <summary>
        /// Last physical used space during the period.
        /// </summary>
        /// <value>Last physical used space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_physical_used")]
        public long? LastPhysicalUsed { get; set; }

        /// <summary>
        /// Last physical used space for data during the period.
        /// </summary>
        /// <value>Last physical used space for data during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_data_physical_used")]
        public long? LastDataPhysicalUsed { get; set; }

        /// <summary>
        /// Last efficiency ratio during the period.
        /// </summary>
        /// <value>Last efficiency ratio during the period.</value>

        [DataMember(Name="last_efficiency_ratio")]
        public float? LastEfficiencyRatio { get; set; }

        /// <summary>
        /// Last data reduction space during the period.
        /// </summary>
        /// <value>Last data reduction space during the period.</value>

        [DataMember(Name="last_data_reduction")]
        public float? LastDataReduction { get; set; }

        /// <summary>
        /// Last snapshot savings space during the period.
        /// </summary>
        /// <value>Last snapshot savings space during the period.</value>

        [DataMember(Name="last_snapshot_savings")]
        public float? LastSnapshotSavings { get; set; }

        /// <summary>
        /// Last thin savings ratio during the period.
        /// </summary>
        /// <value>Last thin savings ratio during the period.</value>

        [DataMember(Name="last_thin_savings")]
        public float? LastThinSavings { get; set; }

        /// <summary>
        /// Last shared logical used during the period.
        /// </summary>
        /// <value>Last shared logical used during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_shared_logical_used")]
        public long? LastSharedLogicalUsed { get; set; }

        /// <summary>
        /// Last system free space during the period. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Last system free space during the period. Was added in version 3.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_system_free_space")]
        public long? LastSystemFreeSpace { get; set; }

        /// <summary>
        /// Last amount of data that cannot be compressed or deduped during the period. A null value indicates insufficient data to calculate the unreducible data. Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Last amount of data that cannot be compressed or deduped during the period. A null value indicates insufficient data to calculate the unreducible data. Was added in version 4.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="last_unreducible_data")]
        public long? LastUnreducibleData { get; set; }

        /// <summary>
        /// Last reducible data reduction ratio during the period. Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Last reducible data reduction ratio during the period. Was added in version 4.0.0.0.</value>

        [DataMember(Name="last_reducible_data_reduction")]
        public float? LastReducibleDataReduction { get; set; }

        /// <summary>
        /// Maximum logical total space during the period.
        /// </summary>
        /// <value>Maximum logical total space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_logical_provisioned")]
        public long? MaxLogicalProvisioned { get; set; }

        /// <summary>
        /// Maximum logical used space during the period.
        /// </summary>
        /// <value>Maximum logical used space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_logical_used")]
        public long? MaxLogicalUsed { get; set; }

        /// <summary>
        /// Maximum logical used space for block volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Maximum logical used space for block volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_logical_used_volume")]
        public long? MaxLogicalUsedVolume { get; set; }

        /// <summary>
        /// Maximum logical used space for file systems during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Maximum logical used space for file systems during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_logical_used_file_system")]
        public long? MaxLogicalUsedFileSystem { get; set; }

        /// <summary>
        /// Maximum logical used space for virtual volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Maximum logical used space for virtual volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_logical_used_vvol")]
        public long? MaxLogicalUsedVvol { get; set; }

        /// <summary>
        /// Maximum shared logical used space for block volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Maximum shared logical used space for block volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_shared_logical_used_volume")]
        public long? MaxSharedLogicalUsedVolume { get; set; }

        /// <summary>
        /// Maximum shared logical used space for file systems during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Maximum shared logical used space for file systems during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_shared_logical_used_file_system")]
        public long? MaxSharedLogicalUsedFileSystem { get; set; }

        /// <summary>
        /// Maximum shared logical used space for virtual volumes during the period. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Maximum shared logical used space for virtual volumes during the period. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_shared_logical_used_vvol")]
        public long? MaxSharedLogicalUsedVvol { get; set; }

        /// <summary>
        /// Maximum physical total space during the period.
        /// </summary>
        /// <value>Maximum physical total space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_physical_total")]
        public long? MaxPhysicalTotal { get; set; }

        /// <summary>
        /// Maximum physical used space during the period.
        /// </summary>
        /// <value>Maximum physical used space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_physical_used")]
        public long? MaxPhysicalUsed { get; set; }

        /// <summary>
        /// Maximum physical used space for data during the period.
        /// </summary>
        /// <value>Maximum physical used space for data during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_data_physical_used")]
        public long? MaxDataPhysicalUsed { get; set; }

        /// <summary>
        /// Maximum efficiency ratio during the period.
        /// </summary>
        /// <value>Maximum efficiency ratio during the period.</value>

        [DataMember(Name="max_efficiency_ratio")]
        public float? MaxEfficiencyRatio { get; set; }

        /// <summary>
        /// Maximum data reduction space during the period.
        /// </summary>
        /// <value>Maximum data reduction space during the period.</value>

        [DataMember(Name="max_data_reduction")]
        public float? MaxDataReduction { get; set; }

        /// <summary>
        /// Maximum snapshot savings space during the period.
        /// </summary>
        /// <value>Maximum snapshot savings space during the period.</value>

        [DataMember(Name="max_snapshot_savings")]
        public float? MaxSnapshotSavings { get; set; }

        /// <summary>
        /// Maximum thin savings ratio during the period.
        /// </summary>
        /// <value>Maximum thin savings ratio during the period.</value>

        [DataMember(Name="max_thin_savings")]
        public float? MaxThinSavings { get; set; }

        /// <summary>
        /// Maximum shared logical used during the period.
        /// </summary>
        /// <value>Maximum shared logical used during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_shared_logical_used")]
        public long? MaxSharedLogicalUsed { get; set; }

        /// <summary>
        /// Maximum system free space during the period. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Maximum system free space during the period. Was added in version 3.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_system_free_space")]
        public long? MaxSystemFreeSpace { get; set; }

        /// <summary>
        /// Maximum amount of data that cannot be compressed or deduped during the period. A null value indicates insufficient data to calculate the unreducible data. Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Maximum amount of data that cannot be compressed or deduped during the period. A null value indicates insufficient data to calculate the unreducible data. Was added in version 4.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="max_unreducible_data")]
        public long? MaxUnreducibleData { get; set; }

        /// <summary>
        /// Max reducible data reduction ratio during the period. Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Max reducible data reduction ratio during the period. Was added in version 4.0.0.0.</value>

        [DataMember(Name="max_reducible_data_reduction")]
        public float? MaxReducibleDataReduction { get; set; }

        /// <summary>
        /// Number of times the metrics are repeated.
        /// </summary>
        /// <value>Number of times the metrics are repeated.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="repeat_count")]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseSpaceMetricsByClusterRollup {\n");
            sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  LastLogicalProvisioned: ").Append(LastLogicalProvisioned).Append("\n");
            sb.Append("  LastLogicalUsed: ").Append(LastLogicalUsed).Append("\n");
            sb.Append("  LastLogicalUsedVolume: ").Append(LastLogicalUsedVolume).Append("\n");
            sb.Append("  LastLogicalUsedFileSystem: ").Append(LastLogicalUsedFileSystem).Append("\n");
            sb.Append("  LastLogicalUsedVvol: ").Append(LastLogicalUsedVvol).Append("\n");
            sb.Append("  LastSharedLogicalUsedVolume: ").Append(LastSharedLogicalUsedVolume).Append("\n");
            sb.Append("  LastSharedLogicalUsedFileSystem: ").Append(LastSharedLogicalUsedFileSystem).Append("\n");
            sb.Append("  LastSharedLogicalUsedVvol: ").Append(LastSharedLogicalUsedVvol).Append("\n");
            sb.Append("  LastPhysicalTotal: ").Append(LastPhysicalTotal).Append("\n");
            sb.Append("  LastPhysicalUsed: ").Append(LastPhysicalUsed).Append("\n");
            sb.Append("  LastDataPhysicalUsed: ").Append(LastDataPhysicalUsed).Append("\n");
            sb.Append("  LastEfficiencyRatio: ").Append(LastEfficiencyRatio).Append("\n");
            sb.Append("  LastDataReduction: ").Append(LastDataReduction).Append("\n");
            sb.Append("  LastSnapshotSavings: ").Append(LastSnapshotSavings).Append("\n");
            sb.Append("  LastThinSavings: ").Append(LastThinSavings).Append("\n");
            sb.Append("  LastSharedLogicalUsed: ").Append(LastSharedLogicalUsed).Append("\n");
            sb.Append("  LastSystemFreeSpace: ").Append(LastSystemFreeSpace).Append("\n");
            sb.Append("  LastUnreducibleData: ").Append(LastUnreducibleData).Append("\n");
            sb.Append("  LastReducibleDataReduction: ").Append(LastReducibleDataReduction).Append("\n");
            sb.Append("  MaxLogicalProvisioned: ").Append(MaxLogicalProvisioned).Append("\n");
            sb.Append("  MaxLogicalUsed: ").Append(MaxLogicalUsed).Append("\n");
            sb.Append("  MaxLogicalUsedVolume: ").Append(MaxLogicalUsedVolume).Append("\n");
            sb.Append("  MaxLogicalUsedFileSystem: ").Append(MaxLogicalUsedFileSystem).Append("\n");
            sb.Append("  MaxLogicalUsedVvol: ").Append(MaxLogicalUsedVvol).Append("\n");
            sb.Append("  MaxSharedLogicalUsedVolume: ").Append(MaxSharedLogicalUsedVolume).Append("\n");
            sb.Append("  MaxSharedLogicalUsedFileSystem: ").Append(MaxSharedLogicalUsedFileSystem).Append("\n");
            sb.Append("  MaxSharedLogicalUsedVvol: ").Append(MaxSharedLogicalUsedVvol).Append("\n");
            sb.Append("  MaxPhysicalTotal: ").Append(MaxPhysicalTotal).Append("\n");
            sb.Append("  MaxPhysicalUsed: ").Append(MaxPhysicalUsed).Append("\n");
            sb.Append("  MaxDataPhysicalUsed: ").Append(MaxDataPhysicalUsed).Append("\n");
            sb.Append("  MaxEfficiencyRatio: ").Append(MaxEfficiencyRatio).Append("\n");
            sb.Append("  MaxDataReduction: ").Append(MaxDataReduction).Append("\n");
            sb.Append("  MaxSnapshotSavings: ").Append(MaxSnapshotSavings).Append("\n");
            sb.Append("  MaxThinSavings: ").Append(MaxThinSavings).Append("\n");
            sb.Append("  MaxSharedLogicalUsed: ").Append(MaxSharedLogicalUsed).Append("\n");
            sb.Append("  MaxSystemFreeSpace: ").Append(MaxSystemFreeSpace).Append("\n");
            sb.Append("  MaxUnreducibleData: ").Append(MaxUnreducibleData).Append("\n");
            sb.Append("  MaxReducibleDataReduction: ").Append(MaxReducibleDataReduction).Append("\n");
            sb.Append("  RepeatCount: ").Append(RepeatCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BaseSpaceMetricsByClusterRollup)obj);
        }

        /// <summary>
        /// Returns true if BaseSpaceMetricsByClusterRollup instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseSpaceMetricsByClusterRollup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseSpaceMetricsByClusterRollup other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClusterId == other.ClusterId ||
                    ClusterId != null &&
                    ClusterId.Equals(other.ClusterId)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    LastLogicalProvisioned == other.LastLogicalProvisioned ||
                    LastLogicalProvisioned != null &&
                    LastLogicalProvisioned.Equals(other.LastLogicalProvisioned)
                ) && 
                (
                    LastLogicalUsed == other.LastLogicalUsed ||
                    LastLogicalUsed != null &&
                    LastLogicalUsed.Equals(other.LastLogicalUsed)
                ) && 
                (
                    LastLogicalUsedVolume == other.LastLogicalUsedVolume ||
                    LastLogicalUsedVolume != null &&
                    LastLogicalUsedVolume.Equals(other.LastLogicalUsedVolume)
                ) && 
                (
                    LastLogicalUsedFileSystem == other.LastLogicalUsedFileSystem ||
                    LastLogicalUsedFileSystem != null &&
                    LastLogicalUsedFileSystem.Equals(other.LastLogicalUsedFileSystem)
                ) && 
                (
                    LastLogicalUsedVvol == other.LastLogicalUsedVvol ||
                    LastLogicalUsedVvol != null &&
                    LastLogicalUsedVvol.Equals(other.LastLogicalUsedVvol)
                ) && 
                (
                    LastSharedLogicalUsedVolume == other.LastSharedLogicalUsedVolume ||
                    LastSharedLogicalUsedVolume != null &&
                    LastSharedLogicalUsedVolume.Equals(other.LastSharedLogicalUsedVolume)
                ) && 
                (
                    LastSharedLogicalUsedFileSystem == other.LastSharedLogicalUsedFileSystem ||
                    LastSharedLogicalUsedFileSystem != null &&
                    LastSharedLogicalUsedFileSystem.Equals(other.LastSharedLogicalUsedFileSystem)
                ) && 
                (
                    LastSharedLogicalUsedVvol == other.LastSharedLogicalUsedVvol ||
                    LastSharedLogicalUsedVvol != null &&
                    LastSharedLogicalUsedVvol.Equals(other.LastSharedLogicalUsedVvol)
                ) && 
                (
                    LastPhysicalTotal == other.LastPhysicalTotal ||
                    LastPhysicalTotal != null &&
                    LastPhysicalTotal.Equals(other.LastPhysicalTotal)
                ) && 
                (
                    LastPhysicalUsed == other.LastPhysicalUsed ||
                    LastPhysicalUsed != null &&
                    LastPhysicalUsed.Equals(other.LastPhysicalUsed)
                ) && 
                (
                    LastDataPhysicalUsed == other.LastDataPhysicalUsed ||
                    LastDataPhysicalUsed != null &&
                    LastDataPhysicalUsed.Equals(other.LastDataPhysicalUsed)
                ) && 
                (
                    LastEfficiencyRatio == other.LastEfficiencyRatio ||
                    LastEfficiencyRatio != null &&
                    LastEfficiencyRatio.Equals(other.LastEfficiencyRatio)
                ) && 
                (
                    LastDataReduction == other.LastDataReduction ||
                    LastDataReduction != null &&
                    LastDataReduction.Equals(other.LastDataReduction)
                ) && 
                (
                    LastSnapshotSavings == other.LastSnapshotSavings ||
                    LastSnapshotSavings != null &&
                    LastSnapshotSavings.Equals(other.LastSnapshotSavings)
                ) && 
                (
                    LastThinSavings == other.LastThinSavings ||
                    LastThinSavings != null &&
                    LastThinSavings.Equals(other.LastThinSavings)
                ) && 
                (
                    LastSharedLogicalUsed == other.LastSharedLogicalUsed ||
                    LastSharedLogicalUsed != null &&
                    LastSharedLogicalUsed.Equals(other.LastSharedLogicalUsed)
                ) && 
                (
                    LastSystemFreeSpace == other.LastSystemFreeSpace ||
                    LastSystemFreeSpace != null &&
                    LastSystemFreeSpace.Equals(other.LastSystemFreeSpace)
                ) && 
                (
                    LastUnreducibleData == other.LastUnreducibleData ||
                    LastUnreducibleData != null &&
                    LastUnreducibleData.Equals(other.LastUnreducibleData)
                ) && 
                (
                    LastReducibleDataReduction == other.LastReducibleDataReduction ||
                    LastReducibleDataReduction != null &&
                    LastReducibleDataReduction.Equals(other.LastReducibleDataReduction)
                ) && 
                (
                    MaxLogicalProvisioned == other.MaxLogicalProvisioned ||
                    MaxLogicalProvisioned != null &&
                    MaxLogicalProvisioned.Equals(other.MaxLogicalProvisioned)
                ) && 
                (
                    MaxLogicalUsed == other.MaxLogicalUsed ||
                    MaxLogicalUsed != null &&
                    MaxLogicalUsed.Equals(other.MaxLogicalUsed)
                ) && 
                (
                    MaxLogicalUsedVolume == other.MaxLogicalUsedVolume ||
                    MaxLogicalUsedVolume != null &&
                    MaxLogicalUsedVolume.Equals(other.MaxLogicalUsedVolume)
                ) && 
                (
                    MaxLogicalUsedFileSystem == other.MaxLogicalUsedFileSystem ||
                    MaxLogicalUsedFileSystem != null &&
                    MaxLogicalUsedFileSystem.Equals(other.MaxLogicalUsedFileSystem)
                ) && 
                (
                    MaxLogicalUsedVvol == other.MaxLogicalUsedVvol ||
                    MaxLogicalUsedVvol != null &&
                    MaxLogicalUsedVvol.Equals(other.MaxLogicalUsedVvol)
                ) && 
                (
                    MaxSharedLogicalUsedVolume == other.MaxSharedLogicalUsedVolume ||
                    MaxSharedLogicalUsedVolume != null &&
                    MaxSharedLogicalUsedVolume.Equals(other.MaxSharedLogicalUsedVolume)
                ) && 
                (
                    MaxSharedLogicalUsedFileSystem == other.MaxSharedLogicalUsedFileSystem ||
                    MaxSharedLogicalUsedFileSystem != null &&
                    MaxSharedLogicalUsedFileSystem.Equals(other.MaxSharedLogicalUsedFileSystem)
                ) && 
                (
                    MaxSharedLogicalUsedVvol == other.MaxSharedLogicalUsedVvol ||
                    MaxSharedLogicalUsedVvol != null &&
                    MaxSharedLogicalUsedVvol.Equals(other.MaxSharedLogicalUsedVvol)
                ) && 
                (
                    MaxPhysicalTotal == other.MaxPhysicalTotal ||
                    MaxPhysicalTotal != null &&
                    MaxPhysicalTotal.Equals(other.MaxPhysicalTotal)
                ) && 
                (
                    MaxPhysicalUsed == other.MaxPhysicalUsed ||
                    MaxPhysicalUsed != null &&
                    MaxPhysicalUsed.Equals(other.MaxPhysicalUsed)
                ) && 
                (
                    MaxDataPhysicalUsed == other.MaxDataPhysicalUsed ||
                    MaxDataPhysicalUsed != null &&
                    MaxDataPhysicalUsed.Equals(other.MaxDataPhysicalUsed)
                ) && 
                (
                    MaxEfficiencyRatio == other.MaxEfficiencyRatio ||
                    MaxEfficiencyRatio != null &&
                    MaxEfficiencyRatio.Equals(other.MaxEfficiencyRatio)
                ) && 
                (
                    MaxDataReduction == other.MaxDataReduction ||
                    MaxDataReduction != null &&
                    MaxDataReduction.Equals(other.MaxDataReduction)
                ) && 
                (
                    MaxSnapshotSavings == other.MaxSnapshotSavings ||
                    MaxSnapshotSavings != null &&
                    MaxSnapshotSavings.Equals(other.MaxSnapshotSavings)
                ) && 
                (
                    MaxThinSavings == other.MaxThinSavings ||
                    MaxThinSavings != null &&
                    MaxThinSavings.Equals(other.MaxThinSavings)
                ) && 
                (
                    MaxSharedLogicalUsed == other.MaxSharedLogicalUsed ||
                    MaxSharedLogicalUsed != null &&
                    MaxSharedLogicalUsed.Equals(other.MaxSharedLogicalUsed)
                ) && 
                (
                    MaxSystemFreeSpace == other.MaxSystemFreeSpace ||
                    MaxSystemFreeSpace != null &&
                    MaxSystemFreeSpace.Equals(other.MaxSystemFreeSpace)
                ) && 
                (
                    MaxUnreducibleData == other.MaxUnreducibleData ||
                    MaxUnreducibleData != null &&
                    MaxUnreducibleData.Equals(other.MaxUnreducibleData)
                ) && 
                (
                    MaxReducibleDataReduction == other.MaxReducibleDataReduction ||
                    MaxReducibleDataReduction != null &&
                    MaxReducibleDataReduction.Equals(other.MaxReducibleDataReduction)
                ) && 
                (
                    RepeatCount == other.RepeatCount ||
                    RepeatCount != null &&
                    RepeatCount.Equals(other.RepeatCount)
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
                    if (ClusterId != null)
                    hashCode = hashCode * 59 + ClusterId.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (LastLogicalProvisioned != null)
                    hashCode = hashCode * 59 + LastLogicalProvisioned.GetHashCode();
                    if (LastLogicalUsed != null)
                    hashCode = hashCode * 59 + LastLogicalUsed.GetHashCode();
                    if (LastLogicalUsedVolume != null)
                    hashCode = hashCode * 59 + LastLogicalUsedVolume.GetHashCode();
                    if (LastLogicalUsedFileSystem != null)
                    hashCode = hashCode * 59 + LastLogicalUsedFileSystem.GetHashCode();
                    if (LastLogicalUsedVvol != null)
                    hashCode = hashCode * 59 + LastLogicalUsedVvol.GetHashCode();
                    if (LastSharedLogicalUsedVolume != null)
                    hashCode = hashCode * 59 + LastSharedLogicalUsedVolume.GetHashCode();
                    if (LastSharedLogicalUsedFileSystem != null)
                    hashCode = hashCode * 59 + LastSharedLogicalUsedFileSystem.GetHashCode();
                    if (LastSharedLogicalUsedVvol != null)
                    hashCode = hashCode * 59 + LastSharedLogicalUsedVvol.GetHashCode();
                    if (LastPhysicalTotal != null)
                    hashCode = hashCode * 59 + LastPhysicalTotal.GetHashCode();
                    if (LastPhysicalUsed != null)
                    hashCode = hashCode * 59 + LastPhysicalUsed.GetHashCode();
                    if (LastDataPhysicalUsed != null)
                    hashCode = hashCode * 59 + LastDataPhysicalUsed.GetHashCode();
                    if (LastEfficiencyRatio != null)
                    hashCode = hashCode * 59 + LastEfficiencyRatio.GetHashCode();
                    if (LastDataReduction != null)
                    hashCode = hashCode * 59 + LastDataReduction.GetHashCode();
                    if (LastSnapshotSavings != null)
                    hashCode = hashCode * 59 + LastSnapshotSavings.GetHashCode();
                    if (LastThinSavings != null)
                    hashCode = hashCode * 59 + LastThinSavings.GetHashCode();
                    if (LastSharedLogicalUsed != null)
                    hashCode = hashCode * 59 + LastSharedLogicalUsed.GetHashCode();
                    if (LastSystemFreeSpace != null)
                    hashCode = hashCode * 59 + LastSystemFreeSpace.GetHashCode();
                    if (LastUnreducibleData != null)
                    hashCode = hashCode * 59 + LastUnreducibleData.GetHashCode();
                    if (LastReducibleDataReduction != null)
                    hashCode = hashCode * 59 + LastReducibleDataReduction.GetHashCode();
                    if (MaxLogicalProvisioned != null)
                    hashCode = hashCode * 59 + MaxLogicalProvisioned.GetHashCode();
                    if (MaxLogicalUsed != null)
                    hashCode = hashCode * 59 + MaxLogicalUsed.GetHashCode();
                    if (MaxLogicalUsedVolume != null)
                    hashCode = hashCode * 59 + MaxLogicalUsedVolume.GetHashCode();
                    if (MaxLogicalUsedFileSystem != null)
                    hashCode = hashCode * 59 + MaxLogicalUsedFileSystem.GetHashCode();
                    if (MaxLogicalUsedVvol != null)
                    hashCode = hashCode * 59 + MaxLogicalUsedVvol.GetHashCode();
                    if (MaxSharedLogicalUsedVolume != null)
                    hashCode = hashCode * 59 + MaxSharedLogicalUsedVolume.GetHashCode();
                    if (MaxSharedLogicalUsedFileSystem != null)
                    hashCode = hashCode * 59 + MaxSharedLogicalUsedFileSystem.GetHashCode();
                    if (MaxSharedLogicalUsedVvol != null)
                    hashCode = hashCode * 59 + MaxSharedLogicalUsedVvol.GetHashCode();
                    if (MaxPhysicalTotal != null)
                    hashCode = hashCode * 59 + MaxPhysicalTotal.GetHashCode();
                    if (MaxPhysicalUsed != null)
                    hashCode = hashCode * 59 + MaxPhysicalUsed.GetHashCode();
                    if (MaxDataPhysicalUsed != null)
                    hashCode = hashCode * 59 + MaxDataPhysicalUsed.GetHashCode();
                    if (MaxEfficiencyRatio != null)
                    hashCode = hashCode * 59 + MaxEfficiencyRatio.GetHashCode();
                    if (MaxDataReduction != null)
                    hashCode = hashCode * 59 + MaxDataReduction.GetHashCode();
                    if (MaxSnapshotSavings != null)
                    hashCode = hashCode * 59 + MaxSnapshotSavings.GetHashCode();
                    if (MaxThinSavings != null)
                    hashCode = hashCode * 59 + MaxThinSavings.GetHashCode();
                    if (MaxSharedLogicalUsed != null)
                    hashCode = hashCode * 59 + MaxSharedLogicalUsed.GetHashCode();
                    if (MaxSystemFreeSpace != null)
                    hashCode = hashCode * 59 + MaxSystemFreeSpace.GetHashCode();
                    if (MaxUnreducibleData != null)
                    hashCode = hashCode * 59 + MaxUnreducibleData.GetHashCode();
                    if (MaxReducibleDataReduction != null)
                    hashCode = hashCode * 59 + MaxReducibleDataReduction.GetHashCode();
                    if (RepeatCount != null)
                    hashCode = hashCode * 59 + RepeatCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BaseSpaceMetricsByClusterRollup left, BaseSpaceMetricsByClusterRollup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseSpaceMetricsByClusterRollup left, BaseSpaceMetricsByClusterRollup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
