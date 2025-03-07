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
    /// Space metrics for the cluster collected at five minute interval.
    /// </summary>
    [DataContract]
    public partial class SpaceMetricsByCluster : MetricsGenerateResponse, IEquatable<SpaceMetricsByCluster>
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
        /// Total configured size of all storage ojects within the cluster. This metric includes all primaries, snaps and clones.
        /// </summary>
        /// <value>Total configured size of all storage ojects within the cluster. This metric includes all primaries, snaps and clones.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="logical_provisioned")]
        public long? LogicalProvisioned { get; set; }

        /// <summary>
        /// Amount of data in bytes written to all storage objects within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones.
        /// </summary>
        /// <value>Amount of data in bytes written to all storage objects within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="logical_used")]
        public long? LogicalUsed { get; set; }

        /// <summary>
        /// Amount of data in bytes written to all block volumes within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Amount of data in bytes written to all block volumes within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="logical_used_volume")]
        public long? LogicalUsedVolume { get; set; }

        /// <summary>
        /// Amount of data in bytes written to all file systems within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Amount of data in bytes written to all file systems within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="logical_used_file_system")]
        public long? LogicalUsedFileSystem { get; set; }

        /// <summary>
        /// Amount of data in bytes written to all virtual volumes within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Amount of data in bytes written to all virtual volumes within the cluster, without any deduplication and/or compression. This metric includes all primaries, snaps and clones. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="logical_used_vvol")]
        public long? LogicalUsedVvol { get; set; }

        /// <summary>
        /// Amount of data in bytes written to all block volumes on an appliance, without any deduplication and/or compression. This metric includes all primaries and clones. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Amount of data in bytes written to all block volumes on an appliance, without any deduplication and/or compression. This metric includes all primaries and clones. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="shared_logical_used_volume")]
        public long? SharedLogicalUsedVolume { get; set; }

        /// <summary>
        /// Amount of data in bytes written to all file systems on an appliance, without any deduplication and/or compression. This metric includes all primaries and clones. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Amount of data in bytes written to all file systems on an appliance, without any deduplication and/or compression. This metric includes all primaries and clones. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="shared_logical_used_file_system")]
        public long? SharedLogicalUsedFileSystem { get; set; }

        /// <summary>
        /// Amount of data in bytes written to all virtual volumes on an appliance, without any deduplication and/or compression. This metric includes all primaries and clones. Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Amount of data in bytes written to all virtual volumes on an appliance, without any deduplication and/or compression. This metric includes all primaries and clones. Was added in version 2.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="shared_logical_used_vvol")]
        public long? SharedLogicalUsedVvol { get; set; }

        /// <summary>
        /// The total combined space on the physical drives of the cluster available for data.
        /// </summary>
        /// <value>The total combined space on the physical drives of the cluster available for data.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="physical_total")]
        public long? PhysicalTotal { get; set; }

        /// <summary>
        /// The total physical space consumed in the cluster, accounting for all efficiency mechanisms, as well as all data protection.
        /// </summary>
        /// <value>The total physical space consumed in the cluster, accounting for all efficiency mechanisms, as well as all data protection.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="physical_used")]
        public long? PhysicalUsed { get; set; }

        /// <summary>
        /// This metric represents total amount of physical space user data occupies after deduplication and compression.
        /// </summary>
        /// <value>This metric represents total amount of physical space user data occupies after deduplication and compression.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="data_physical_used")]
        public long? DataPhysicalUsed { get; set; }

        /// <summary>
        /// The overall efficiency is computed as a ratio of the total space provisioned to physical used space. For example, ten 2 GB volumes were provisioned and 1 GB of data is written to each of them. Each of the volumes has one snapshot as well, for another ten 2 GB volumes. All volumes are thinly provisioned with deduplication and compression applied, there is 4 GB of physical space used. Overall efficiency would be (20 * 2 GB) / 4 GB or 10:1. The efficiency_ratio value will be 10 in this example.
        /// </summary>
        /// <value>The overall efficiency is computed as a ratio of the total space provisioned to physical used space. For example, ten 2 GB volumes were provisioned and 1 GB of data is written to each of them. Each of the volumes has one snapshot as well, for another ten 2 GB volumes. All volumes are thinly provisioned with deduplication and compression applied, there is 4 GB of physical space used. Overall efficiency would be (20 * 2 GB) / 4 GB or 10:1. The efficiency_ratio value will be 10 in this example.</value>

        [DataMember(Name="efficiency_ratio")]
        public float? EfficiencyRatio { get; set; }

        /// <summary>
        /// Ratio of the logical used space to data physical used space which is after deduplication and compression.
        /// </summary>
        /// <value>Ratio of the logical used space to data physical used space which is after deduplication and compression.</value>

        [DataMember(Name="data_reduction")]
        public float? DataReduction { get; set; }

        /// <summary>
        /// Ratio of the amount of space that would have been used by snapshots if space efficiency was not applied to logical space used solely by snapshots. For example, an object is provisioned as 1 GB and it has two snapshots. Each snapshot has 200 MB of data. Snapshot savings will be (1 GB + 1 GB) / (0.2 GB + 0.2 GB) or 5:1. The snapshot_savings value will be 5 in this case.
        /// </summary>
        /// <value>Ratio of the amount of space that would have been used by snapshots if space efficiency was not applied to logical space used solely by snapshots. For example, an object is provisioned as 1 GB and it has two snapshots. Each snapshot has 200 MB of data. Snapshot savings will be (1 GB + 1 GB) / (0.2 GB + 0.2 GB) or 5:1. The snapshot_savings value will be 5 in this case.</value>

        [DataMember(Name="snapshot_savings")]
        public float? SnapshotSavings { get; set; }

        /// <summary>
        /// Ratio of all the vVol provisioned to data they contain. This is the ratio of logical_provisioned to logical_used. For example, a cluster has two 2 GB objects and have written 500 MB bytes of data to them. The thin savings would be (2 * 2 GB) / (2 * 0.5 GB) or 4:1, so the thin_savings value would be 4.0.
        /// </summary>
        /// <value>Ratio of all the vVol provisioned to data they contain. This is the ratio of logical_provisioned to logical_used. For example, a cluster has two 2 GB objects and have written 500 MB bytes of data to them. The thin savings would be (2 * 2 GB) / (2 * 0.5 GB) or 4:1, so the thin_savings value would be 4.0.</value>

        [DataMember(Name="thin_savings")]
        public float? ThinSavings { get; set; }

        /// <summary>
        /// Cluster shared logical used is sum of appliances&#39; shared logical used in the cluster.
        /// </summary>
        /// <value>Cluster shared logical used is sum of appliances&#39; shared logical used in the cluster.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="shared_logical_used")]
        public long? SharedLogicalUsed { get; set; }

        /// <summary>
        /// Space formerly used by the system for internal needs that will be reused for the same purpose as additional storage is provisioned. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Space formerly used by the system for internal needs that will be reused for the same purpose as additional storage is provisioned. Was added in version 3.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="system_free_space")]
        public long? SystemFreeSpace { get; set; }

        /// <summary>
        /// Amount of data that cannot be compressed or deduped. A null value indicates insufficient data to calculate the unreducible data. Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Amount of data that cannot be compressed or deduped. A null value indicates insufficient data to calculate the unreducible data. Was added in version 4.0.0.0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="unreducible_data")]
        public long? UnreducibleData { get; set; }

        /// <summary>
        /// Ratio of the logical used space to data physical used space which is after deduplication and compression, based on reducible data only. Was added in version 4.0.0.0.
        /// </summary>
        /// <value>Ratio of the logical used space to data physical used space which is after deduplication and compression, based on reducible data only. Was added in version 4.0.0.0.</value>

        [DataMember(Name="reducible_data_reduction")]
        public float? ReducibleDataReduction { get; set; }

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
            sb.Append("class SpaceMetricsByCluster {\n");
            sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  LogicalProvisioned: ").Append(LogicalProvisioned).Append("\n");
            sb.Append("  LogicalUsed: ").Append(LogicalUsed).Append("\n");
            sb.Append("  LogicalUsedVolume: ").Append(LogicalUsedVolume).Append("\n");
            sb.Append("  LogicalUsedFileSystem: ").Append(LogicalUsedFileSystem).Append("\n");
            sb.Append("  LogicalUsedVvol: ").Append(LogicalUsedVvol).Append("\n");
            sb.Append("  SharedLogicalUsedVolume: ").Append(SharedLogicalUsedVolume).Append("\n");
            sb.Append("  SharedLogicalUsedFileSystem: ").Append(SharedLogicalUsedFileSystem).Append("\n");
            sb.Append("  SharedLogicalUsedVvol: ").Append(SharedLogicalUsedVvol).Append("\n");
            sb.Append("  PhysicalTotal: ").Append(PhysicalTotal).Append("\n");
            sb.Append("  PhysicalUsed: ").Append(PhysicalUsed).Append("\n");
            sb.Append("  DataPhysicalUsed: ").Append(DataPhysicalUsed).Append("\n");
            sb.Append("  EfficiencyRatio: ").Append(EfficiencyRatio).Append("\n");
            sb.Append("  DataReduction: ").Append(DataReduction).Append("\n");
            sb.Append("  SnapshotSavings: ").Append(SnapshotSavings).Append("\n");
            sb.Append("  ThinSavings: ").Append(ThinSavings).Append("\n");
            sb.Append("  SharedLogicalUsed: ").Append(SharedLogicalUsed).Append("\n");
            sb.Append("  SystemFreeSpace: ").Append(SystemFreeSpace).Append("\n");
            sb.Append("  UnreducibleData: ").Append(UnreducibleData).Append("\n");
            sb.Append("  ReducibleDataReduction: ").Append(ReducibleDataReduction).Append("\n");
            sb.Append("  RepeatCount: ").Append(RepeatCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((SpaceMetricsByCluster)obj);
        }

        /// <summary>
        /// Returns true if SpaceMetricsByCluster instances are equal
        /// </summary>
        /// <param name="other">Instance of SpaceMetricsByCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpaceMetricsByCluster other)
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
                    LogicalProvisioned == other.LogicalProvisioned ||
                    LogicalProvisioned != null &&
                    LogicalProvisioned.Equals(other.LogicalProvisioned)
                ) && 
                (
                    LogicalUsed == other.LogicalUsed ||
                    LogicalUsed != null &&
                    LogicalUsed.Equals(other.LogicalUsed)
                ) && 
                (
                    LogicalUsedVolume == other.LogicalUsedVolume ||
                    LogicalUsedVolume != null &&
                    LogicalUsedVolume.Equals(other.LogicalUsedVolume)
                ) && 
                (
                    LogicalUsedFileSystem == other.LogicalUsedFileSystem ||
                    LogicalUsedFileSystem != null &&
                    LogicalUsedFileSystem.Equals(other.LogicalUsedFileSystem)
                ) && 
                (
                    LogicalUsedVvol == other.LogicalUsedVvol ||
                    LogicalUsedVvol != null &&
                    LogicalUsedVvol.Equals(other.LogicalUsedVvol)
                ) && 
                (
                    SharedLogicalUsedVolume == other.SharedLogicalUsedVolume ||
                    SharedLogicalUsedVolume != null &&
                    SharedLogicalUsedVolume.Equals(other.SharedLogicalUsedVolume)
                ) && 
                (
                    SharedLogicalUsedFileSystem == other.SharedLogicalUsedFileSystem ||
                    SharedLogicalUsedFileSystem != null &&
                    SharedLogicalUsedFileSystem.Equals(other.SharedLogicalUsedFileSystem)
                ) && 
                (
                    SharedLogicalUsedVvol == other.SharedLogicalUsedVvol ||
                    SharedLogicalUsedVvol != null &&
                    SharedLogicalUsedVvol.Equals(other.SharedLogicalUsedVvol)
                ) && 
                (
                    PhysicalTotal == other.PhysicalTotal ||
                    PhysicalTotal != null &&
                    PhysicalTotal.Equals(other.PhysicalTotal)
                ) && 
                (
                    PhysicalUsed == other.PhysicalUsed ||
                    PhysicalUsed != null &&
                    PhysicalUsed.Equals(other.PhysicalUsed)
                ) && 
                (
                    DataPhysicalUsed == other.DataPhysicalUsed ||
                    DataPhysicalUsed != null &&
                    DataPhysicalUsed.Equals(other.DataPhysicalUsed)
                ) && 
                (
                    EfficiencyRatio == other.EfficiencyRatio ||
                    EfficiencyRatio != null &&
                    EfficiencyRatio.Equals(other.EfficiencyRatio)
                ) && 
                (
                    DataReduction == other.DataReduction ||
                    DataReduction != null &&
                    DataReduction.Equals(other.DataReduction)
                ) && 
                (
                    SnapshotSavings == other.SnapshotSavings ||
                    SnapshotSavings != null &&
                    SnapshotSavings.Equals(other.SnapshotSavings)
                ) && 
                (
                    ThinSavings == other.ThinSavings ||
                    ThinSavings != null &&
                    ThinSavings.Equals(other.ThinSavings)
                ) && 
                (
                    SharedLogicalUsed == other.SharedLogicalUsed ||
                    SharedLogicalUsed != null &&
                    SharedLogicalUsed.Equals(other.SharedLogicalUsed)
                ) && 
                (
                    SystemFreeSpace == other.SystemFreeSpace ||
                    SystemFreeSpace != null &&
                    SystemFreeSpace.Equals(other.SystemFreeSpace)
                ) && 
                (
                    UnreducibleData == other.UnreducibleData ||
                    UnreducibleData != null &&
                    UnreducibleData.Equals(other.UnreducibleData)
                ) && 
                (
                    ReducibleDataReduction == other.ReducibleDataReduction ||
                    ReducibleDataReduction != null &&
                    ReducibleDataReduction.Equals(other.ReducibleDataReduction)
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
                    if (LogicalProvisioned != null)
                    hashCode = hashCode * 59 + LogicalProvisioned.GetHashCode();
                    if (LogicalUsed != null)
                    hashCode = hashCode * 59 + LogicalUsed.GetHashCode();
                    if (LogicalUsedVolume != null)
                    hashCode = hashCode * 59 + LogicalUsedVolume.GetHashCode();
                    if (LogicalUsedFileSystem != null)
                    hashCode = hashCode * 59 + LogicalUsedFileSystem.GetHashCode();
                    if (LogicalUsedVvol != null)
                    hashCode = hashCode * 59 + LogicalUsedVvol.GetHashCode();
                    if (SharedLogicalUsedVolume != null)
                    hashCode = hashCode * 59 + SharedLogicalUsedVolume.GetHashCode();
                    if (SharedLogicalUsedFileSystem != null)
                    hashCode = hashCode * 59 + SharedLogicalUsedFileSystem.GetHashCode();
                    if (SharedLogicalUsedVvol != null)
                    hashCode = hashCode * 59 + SharedLogicalUsedVvol.GetHashCode();
                    if (PhysicalTotal != null)
                    hashCode = hashCode * 59 + PhysicalTotal.GetHashCode();
                    if (PhysicalUsed != null)
                    hashCode = hashCode * 59 + PhysicalUsed.GetHashCode();
                    if (DataPhysicalUsed != null)
                    hashCode = hashCode * 59 + DataPhysicalUsed.GetHashCode();
                    if (EfficiencyRatio != null)
                    hashCode = hashCode * 59 + EfficiencyRatio.GetHashCode();
                    if (DataReduction != null)
                    hashCode = hashCode * 59 + DataReduction.GetHashCode();
                    if (SnapshotSavings != null)
                    hashCode = hashCode * 59 + SnapshotSavings.GetHashCode();
                    if (ThinSavings != null)
                    hashCode = hashCode * 59 + ThinSavings.GetHashCode();
                    if (SharedLogicalUsed != null)
                    hashCode = hashCode * 59 + SharedLogicalUsed.GetHashCode();
                    if (SystemFreeSpace != null)
                    hashCode = hashCode * 59 + SystemFreeSpace.GetHashCode();
                    if (UnreducibleData != null)
                    hashCode = hashCode * 59 + UnreducibleData.GetHashCode();
                    if (ReducibleDataReduction != null)
                    hashCode = hashCode * 59 + ReducibleDataReduction.GetHashCode();
                    if (RepeatCount != null)
                    hashCode = hashCode * 59 + RepeatCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SpaceMetricsByCluster left, SpaceMetricsByCluster right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SpaceMetricsByCluster left, SpaceMetricsByCluster right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
