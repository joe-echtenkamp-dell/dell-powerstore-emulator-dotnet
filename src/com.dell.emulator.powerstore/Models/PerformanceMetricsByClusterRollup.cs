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
    /// Summary of cluster level performance metric data for various rollup intervals beginning with timestamp, including the average and maximum values for that period.
    /// </summary>
    [DataContract]
    public partial class PerformanceMetricsByClusterRollup : MetricsGenerateResponse, IEquatable<PerformanceMetricsByClusterRollup>
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
        /// Weighted average read latency in microseconds.
        /// </summary>
        /// <value>Weighted average read latency in microseconds.</value>

        [DataMember(Name="avg_read_latency")]
        public float? AvgReadLatency { get; set; }

        /// <summary>
        /// Weighted average write latency in microseconds.
        /// </summary>
        /// <value>Weighted average write latency in microseconds.</value>

        [DataMember(Name="avg_write_latency")]
        public float? AvgWriteLatency { get; set; }

        /// <summary>
        /// Weighted average mirror write latency in microseconds.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Weighted average mirror write latency in microseconds.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="avg_mirror_write_latency")]
        public float? AvgMirrorWriteLatency { get; set; }

        /// <summary>
        /// Weighted additional latency incurred on the source in order to do the remote mirror writes in microseconds. This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Weighted additional latency incurred on the source in order to do the remote mirror writes in microseconds. This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="avg_mirror_overhead_latency")]
        public float? AvgMirrorOverheadLatency { get; set; }

        /// <summary>
        /// Weighted average latency in microseconds.
        /// </summary>
        /// <value>Weighted average latency in microseconds.</value>

        [DataMember(Name="avg_latency")]
        public float? AvgLatency { get; set; }

        /// <summary>
        /// Weighted average read size in bytes.
        /// </summary>
        /// <value>Weighted average read size in bytes.</value>

        [DataMember(Name="avg_read_size")]
        public float? AvgReadSize { get; set; }

        /// <summary>
        /// Weighted average write size in bytes.
        /// </summary>
        /// <value>Weighted average write size in bytes.</value>

        [DataMember(Name="avg_write_size")]
        public float? AvgWriteSize { get; set; }

        /// <summary>
        /// Average size of read and write operations in bytes.
        /// </summary>
        /// <value>Average size of read and write operations in bytes.</value>

        [DataMember(Name="avg_io_size")]
        public float? AvgIoSize { get; set; }

        /// <summary>
        /// Average reads per second.
        /// </summary>
        /// <value>Average reads per second.</value>

        [DataMember(Name="avg_read_iops")]
        public float? AvgReadIops { get; set; }

        /// <summary>
        /// Average writes per second.
        /// </summary>
        /// <value>Average writes per second.</value>

        [DataMember(Name="avg_write_iops")]
        public float? AvgWriteIops { get; set; }

        /// <summary>
        /// Average mirror write operations per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Average mirror write operations per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="avg_mirror_write_iops")]
        public float? AvgMirrorWriteIops { get; set; }

        /// <summary>
        /// Average total input and output operations per second.
        /// </summary>
        /// <value>Average total input and output operations per second.</value>

        [DataMember(Name="avg_total_iops")]
        public decimal? AvgTotalIops { get; set; }

        /// <summary>
        /// Weighted average  read bandwidth in bytes per second.
        /// </summary>
        /// <value>Weighted average  read bandwidth in bytes per second.</value>

        [DataMember(Name="avg_read_bandwidth")]
        public float? AvgReadBandwidth { get; set; }

        /// <summary>
        /// Weighted average write bandwidth in bytes per second.
        /// </summary>
        /// <value>Weighted average write bandwidth in bytes per second.</value>

        [DataMember(Name="avg_write_bandwidth")]
        public float? AvgWriteBandwidth { get; set; }

        /// <summary>
        /// Weighted average mirror write rate in byte per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Weighted average mirror write rate in byte per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="avg_mirror_write_bandwidth")]
        public float? AvgMirrorWriteBandwidth { get; set; }

        /// <summary>
        /// Weighted average total bandwidth in bytes per second.
        /// </summary>
        /// <value>Weighted average total bandwidth in bytes per second.</value>

        [DataMember(Name="avg_total_bandwidth")]
        public float? AvgTotalBandwidth { get; set; }

        /// <summary>
        /// Maximum read latency in microseconds.
        /// </summary>
        /// <value>Maximum read latency in microseconds.</value>

        [DataMember(Name="max_avg_read_latency")]
        public float? MaxAvgReadLatency { get; set; }

        /// <summary>
        /// Maximum of average write latency in microseconds.
        /// </summary>
        /// <value>Maximum of average write latency in microseconds.</value>

        [DataMember(Name="max_avg_write_latency")]
        public float? MaxAvgWriteLatency { get; set; }

        /// <summary>
        /// Maximum of average mirror write latency in microseconds.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Maximum of average mirror write latency in microseconds.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="max_avg_mirror_write_latency")]
        public float? MaxAvgMirrorWriteLatency { get; set; }

        /// <summary>
        /// Maximum of average additional latency incurred on the source in order to do the remote mirror writes in microseconds. This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Maximum of average additional latency incurred on the source in order to do the remote mirror writes in microseconds. This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="max_avg_mirror_overhead_latency")]
        public float? MaxAvgMirrorOverheadLatency { get; set; }

        /// <summary>
        /// Maximum of average latency in microseconds.
        /// </summary>
        /// <value>Maximum of average latency in microseconds.</value>

        [DataMember(Name="max_avg_latency")]
        public float? MaxAvgLatency { get; set; }

        /// <summary>
        /// Maximum of average read size in bytes.
        /// </summary>
        /// <value>Maximum of average read size in bytes.</value>

        [DataMember(Name="max_avg_read_size")]
        public float? MaxAvgReadSize { get; set; }

        /// <summary>
        /// Maximum of average write size in bytes.
        /// </summary>
        /// <value>Maximum of average write size in bytes.</value>

        [DataMember(Name="max_avg_write_size")]
        public float? MaxAvgWriteSize { get; set; }

        /// <summary>
        /// Maximum average size of input and output operations in bytes.
        /// </summary>
        /// <value>Maximum average size of input and output operations in bytes.</value>

        [DataMember(Name="max_avg_io_size")]
        public float? MaxAvgIoSize { get; set; }

        /// <summary>
        /// Maximum reads per second.
        /// </summary>
        /// <value>Maximum reads per second.</value>

        [DataMember(Name="max_read_iops")]
        public float? MaxReadIops { get; set; }

        /// <summary>
        /// Maximum writes per second.
        /// </summary>
        /// <value>Maximum writes per second.</value>

        [DataMember(Name="max_write_iops")]
        public float? MaxWriteIops { get; set; }

        /// <summary>
        /// Maximum mirror write operations per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Maximum mirror write operations per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="max_mirror_write_iops")]
        public float? MaxMirrorWriteIops { get; set; }

        /// <summary>
        /// Maximum totals per second.
        /// </summary>
        /// <value>Maximum totals per second.</value>

        [DataMember(Name="max_total_iops")]
        public decimal? MaxTotalIops { get; set; }

        /// <summary>
        /// Maximum read bandwidth in bytes per second.
        /// </summary>
        /// <value>Maximum read bandwidth in bytes per second.</value>

        [DataMember(Name="max_read_bandwidth")]
        public float? MaxReadBandwidth { get; set; }

        /// <summary>
        /// Maximum write bandwidth in bytes per second.
        /// </summary>
        /// <value>Maximum write bandwidth in bytes per second.</value>

        [DataMember(Name="max_write_bandwidth")]
        public float? MaxWriteBandwidth { get; set; }

        /// <summary>
        /// Maximum mirror write rate in byte per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Maximum mirror write rate in byte per second.  This applies to metro volumes in the active-active state. Was added in version 3.0.0.0.</value>

        [DataMember(Name="max_mirror_write_bandwidth")]
        public float? MaxMirrorWriteBandwidth { get; set; }

        /// <summary>
        /// Maximum total bandwidth in bytes per second.
        /// </summary>
        /// <value>Maximum total bandwidth in bytes per second.</value>

        [DataMember(Name="max_total_bandwidth")]
        public float? MaxTotalBandwidth { get; set; }

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
            sb.Append("class PerformanceMetricsByClusterRollup {\n");
            sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  AvgReadLatency: ").Append(AvgReadLatency).Append("\n");
            sb.Append("  AvgWriteLatency: ").Append(AvgWriteLatency).Append("\n");
            sb.Append("  AvgMirrorWriteLatency: ").Append(AvgMirrorWriteLatency).Append("\n");
            sb.Append("  AvgMirrorOverheadLatency: ").Append(AvgMirrorOverheadLatency).Append("\n");
            sb.Append("  AvgLatency: ").Append(AvgLatency).Append("\n");
            sb.Append("  AvgReadSize: ").Append(AvgReadSize).Append("\n");
            sb.Append("  AvgWriteSize: ").Append(AvgWriteSize).Append("\n");
            sb.Append("  AvgIoSize: ").Append(AvgIoSize).Append("\n");
            sb.Append("  AvgReadIops: ").Append(AvgReadIops).Append("\n");
            sb.Append("  AvgWriteIops: ").Append(AvgWriteIops).Append("\n");
            sb.Append("  AvgMirrorWriteIops: ").Append(AvgMirrorWriteIops).Append("\n");
            sb.Append("  AvgTotalIops: ").Append(AvgTotalIops).Append("\n");
            sb.Append("  AvgReadBandwidth: ").Append(AvgReadBandwidth).Append("\n");
            sb.Append("  AvgWriteBandwidth: ").Append(AvgWriteBandwidth).Append("\n");
            sb.Append("  AvgMirrorWriteBandwidth: ").Append(AvgMirrorWriteBandwidth).Append("\n");
            sb.Append("  AvgTotalBandwidth: ").Append(AvgTotalBandwidth).Append("\n");
            sb.Append("  MaxAvgReadLatency: ").Append(MaxAvgReadLatency).Append("\n");
            sb.Append("  MaxAvgWriteLatency: ").Append(MaxAvgWriteLatency).Append("\n");
            sb.Append("  MaxAvgMirrorWriteLatency: ").Append(MaxAvgMirrorWriteLatency).Append("\n");
            sb.Append("  MaxAvgMirrorOverheadLatency: ").Append(MaxAvgMirrorOverheadLatency).Append("\n");
            sb.Append("  MaxAvgLatency: ").Append(MaxAvgLatency).Append("\n");
            sb.Append("  MaxAvgReadSize: ").Append(MaxAvgReadSize).Append("\n");
            sb.Append("  MaxAvgWriteSize: ").Append(MaxAvgWriteSize).Append("\n");
            sb.Append("  MaxAvgIoSize: ").Append(MaxAvgIoSize).Append("\n");
            sb.Append("  MaxReadIops: ").Append(MaxReadIops).Append("\n");
            sb.Append("  MaxWriteIops: ").Append(MaxWriteIops).Append("\n");
            sb.Append("  MaxMirrorWriteIops: ").Append(MaxMirrorWriteIops).Append("\n");
            sb.Append("  MaxTotalIops: ").Append(MaxTotalIops).Append("\n");
            sb.Append("  MaxReadBandwidth: ").Append(MaxReadBandwidth).Append("\n");
            sb.Append("  MaxWriteBandwidth: ").Append(MaxWriteBandwidth).Append("\n");
            sb.Append("  MaxMirrorWriteBandwidth: ").Append(MaxMirrorWriteBandwidth).Append("\n");
            sb.Append("  MaxTotalBandwidth: ").Append(MaxTotalBandwidth).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PerformanceMetricsByClusterRollup)obj);
        }

        /// <summary>
        /// Returns true if PerformanceMetricsByClusterRollup instances are equal
        /// </summary>
        /// <param name="other">Instance of PerformanceMetricsByClusterRollup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceMetricsByClusterRollup other)
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
                    AvgReadLatency == other.AvgReadLatency ||
                    AvgReadLatency != null &&
                    AvgReadLatency.Equals(other.AvgReadLatency)
                ) && 
                (
                    AvgWriteLatency == other.AvgWriteLatency ||
                    AvgWriteLatency != null &&
                    AvgWriteLatency.Equals(other.AvgWriteLatency)
                ) && 
                (
                    AvgMirrorWriteLatency == other.AvgMirrorWriteLatency ||
                    AvgMirrorWriteLatency != null &&
                    AvgMirrorWriteLatency.Equals(other.AvgMirrorWriteLatency)
                ) && 
                (
                    AvgMirrorOverheadLatency == other.AvgMirrorOverheadLatency ||
                    AvgMirrorOverheadLatency != null &&
                    AvgMirrorOverheadLatency.Equals(other.AvgMirrorOverheadLatency)
                ) && 
                (
                    AvgLatency == other.AvgLatency ||
                    AvgLatency != null &&
                    AvgLatency.Equals(other.AvgLatency)
                ) && 
                (
                    AvgReadSize == other.AvgReadSize ||
                    AvgReadSize != null &&
                    AvgReadSize.Equals(other.AvgReadSize)
                ) && 
                (
                    AvgWriteSize == other.AvgWriteSize ||
                    AvgWriteSize != null &&
                    AvgWriteSize.Equals(other.AvgWriteSize)
                ) && 
                (
                    AvgIoSize == other.AvgIoSize ||
                    AvgIoSize != null &&
                    AvgIoSize.Equals(other.AvgIoSize)
                ) && 
                (
                    AvgReadIops == other.AvgReadIops ||
                    AvgReadIops != null &&
                    AvgReadIops.Equals(other.AvgReadIops)
                ) && 
                (
                    AvgWriteIops == other.AvgWriteIops ||
                    AvgWriteIops != null &&
                    AvgWriteIops.Equals(other.AvgWriteIops)
                ) && 
                (
                    AvgMirrorWriteIops == other.AvgMirrorWriteIops ||
                    AvgMirrorWriteIops != null &&
                    AvgMirrorWriteIops.Equals(other.AvgMirrorWriteIops)
                ) && 
                (
                    AvgTotalIops == other.AvgTotalIops ||
                    AvgTotalIops != null &&
                    AvgTotalIops.Equals(other.AvgTotalIops)
                ) && 
                (
                    AvgReadBandwidth == other.AvgReadBandwidth ||
                    AvgReadBandwidth != null &&
                    AvgReadBandwidth.Equals(other.AvgReadBandwidth)
                ) && 
                (
                    AvgWriteBandwidth == other.AvgWriteBandwidth ||
                    AvgWriteBandwidth != null &&
                    AvgWriteBandwidth.Equals(other.AvgWriteBandwidth)
                ) && 
                (
                    AvgMirrorWriteBandwidth == other.AvgMirrorWriteBandwidth ||
                    AvgMirrorWriteBandwidth != null &&
                    AvgMirrorWriteBandwidth.Equals(other.AvgMirrorWriteBandwidth)
                ) && 
                (
                    AvgTotalBandwidth == other.AvgTotalBandwidth ||
                    AvgTotalBandwidth != null &&
                    AvgTotalBandwidth.Equals(other.AvgTotalBandwidth)
                ) && 
                (
                    MaxAvgReadLatency == other.MaxAvgReadLatency ||
                    MaxAvgReadLatency != null &&
                    MaxAvgReadLatency.Equals(other.MaxAvgReadLatency)
                ) && 
                (
                    MaxAvgWriteLatency == other.MaxAvgWriteLatency ||
                    MaxAvgWriteLatency != null &&
                    MaxAvgWriteLatency.Equals(other.MaxAvgWriteLatency)
                ) && 
                (
                    MaxAvgMirrorWriteLatency == other.MaxAvgMirrorWriteLatency ||
                    MaxAvgMirrorWriteLatency != null &&
                    MaxAvgMirrorWriteLatency.Equals(other.MaxAvgMirrorWriteLatency)
                ) && 
                (
                    MaxAvgMirrorOverheadLatency == other.MaxAvgMirrorOverheadLatency ||
                    MaxAvgMirrorOverheadLatency != null &&
                    MaxAvgMirrorOverheadLatency.Equals(other.MaxAvgMirrorOverheadLatency)
                ) && 
                (
                    MaxAvgLatency == other.MaxAvgLatency ||
                    MaxAvgLatency != null &&
                    MaxAvgLatency.Equals(other.MaxAvgLatency)
                ) && 
                (
                    MaxAvgReadSize == other.MaxAvgReadSize ||
                    MaxAvgReadSize != null &&
                    MaxAvgReadSize.Equals(other.MaxAvgReadSize)
                ) && 
                (
                    MaxAvgWriteSize == other.MaxAvgWriteSize ||
                    MaxAvgWriteSize != null &&
                    MaxAvgWriteSize.Equals(other.MaxAvgWriteSize)
                ) && 
                (
                    MaxAvgIoSize == other.MaxAvgIoSize ||
                    MaxAvgIoSize != null &&
                    MaxAvgIoSize.Equals(other.MaxAvgIoSize)
                ) && 
                (
                    MaxReadIops == other.MaxReadIops ||
                    MaxReadIops != null &&
                    MaxReadIops.Equals(other.MaxReadIops)
                ) && 
                (
                    MaxWriteIops == other.MaxWriteIops ||
                    MaxWriteIops != null &&
                    MaxWriteIops.Equals(other.MaxWriteIops)
                ) && 
                (
                    MaxMirrorWriteIops == other.MaxMirrorWriteIops ||
                    MaxMirrorWriteIops != null &&
                    MaxMirrorWriteIops.Equals(other.MaxMirrorWriteIops)
                ) && 
                (
                    MaxTotalIops == other.MaxTotalIops ||
                    MaxTotalIops != null &&
                    MaxTotalIops.Equals(other.MaxTotalIops)
                ) && 
                (
                    MaxReadBandwidth == other.MaxReadBandwidth ||
                    MaxReadBandwidth != null &&
                    MaxReadBandwidth.Equals(other.MaxReadBandwidth)
                ) && 
                (
                    MaxWriteBandwidth == other.MaxWriteBandwidth ||
                    MaxWriteBandwidth != null &&
                    MaxWriteBandwidth.Equals(other.MaxWriteBandwidth)
                ) && 
                (
                    MaxMirrorWriteBandwidth == other.MaxMirrorWriteBandwidth ||
                    MaxMirrorWriteBandwidth != null &&
                    MaxMirrorWriteBandwidth.Equals(other.MaxMirrorWriteBandwidth)
                ) && 
                (
                    MaxTotalBandwidth == other.MaxTotalBandwidth ||
                    MaxTotalBandwidth != null &&
                    MaxTotalBandwidth.Equals(other.MaxTotalBandwidth)
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
                    if (AvgReadLatency != null)
                    hashCode = hashCode * 59 + AvgReadLatency.GetHashCode();
                    if (AvgWriteLatency != null)
                    hashCode = hashCode * 59 + AvgWriteLatency.GetHashCode();
                    if (AvgMirrorWriteLatency != null)
                    hashCode = hashCode * 59 + AvgMirrorWriteLatency.GetHashCode();
                    if (AvgMirrorOverheadLatency != null)
                    hashCode = hashCode * 59 + AvgMirrorOverheadLatency.GetHashCode();
                    if (AvgLatency != null)
                    hashCode = hashCode * 59 + AvgLatency.GetHashCode();
                    if (AvgReadSize != null)
                    hashCode = hashCode * 59 + AvgReadSize.GetHashCode();
                    if (AvgWriteSize != null)
                    hashCode = hashCode * 59 + AvgWriteSize.GetHashCode();
                    if (AvgIoSize != null)
                    hashCode = hashCode * 59 + AvgIoSize.GetHashCode();
                    if (AvgReadIops != null)
                    hashCode = hashCode * 59 + AvgReadIops.GetHashCode();
                    if (AvgWriteIops != null)
                    hashCode = hashCode * 59 + AvgWriteIops.GetHashCode();
                    if (AvgMirrorWriteIops != null)
                    hashCode = hashCode * 59 + AvgMirrorWriteIops.GetHashCode();
                    if (AvgTotalIops != null)
                    hashCode = hashCode * 59 + AvgTotalIops.GetHashCode();
                    if (AvgReadBandwidth != null)
                    hashCode = hashCode * 59 + AvgReadBandwidth.GetHashCode();
                    if (AvgWriteBandwidth != null)
                    hashCode = hashCode * 59 + AvgWriteBandwidth.GetHashCode();
                    if (AvgMirrorWriteBandwidth != null)
                    hashCode = hashCode * 59 + AvgMirrorWriteBandwidth.GetHashCode();
                    if (AvgTotalBandwidth != null)
                    hashCode = hashCode * 59 + AvgTotalBandwidth.GetHashCode();
                    if (MaxAvgReadLatency != null)
                    hashCode = hashCode * 59 + MaxAvgReadLatency.GetHashCode();
                    if (MaxAvgWriteLatency != null)
                    hashCode = hashCode * 59 + MaxAvgWriteLatency.GetHashCode();
                    if (MaxAvgMirrorWriteLatency != null)
                    hashCode = hashCode * 59 + MaxAvgMirrorWriteLatency.GetHashCode();
                    if (MaxAvgMirrorOverheadLatency != null)
                    hashCode = hashCode * 59 + MaxAvgMirrorOverheadLatency.GetHashCode();
                    if (MaxAvgLatency != null)
                    hashCode = hashCode * 59 + MaxAvgLatency.GetHashCode();
                    if (MaxAvgReadSize != null)
                    hashCode = hashCode * 59 + MaxAvgReadSize.GetHashCode();
                    if (MaxAvgWriteSize != null)
                    hashCode = hashCode * 59 + MaxAvgWriteSize.GetHashCode();
                    if (MaxAvgIoSize != null)
                    hashCode = hashCode * 59 + MaxAvgIoSize.GetHashCode();
                    if (MaxReadIops != null)
                    hashCode = hashCode * 59 + MaxReadIops.GetHashCode();
                    if (MaxWriteIops != null)
                    hashCode = hashCode * 59 + MaxWriteIops.GetHashCode();
                    if (MaxMirrorWriteIops != null)
                    hashCode = hashCode * 59 + MaxMirrorWriteIops.GetHashCode();
                    if (MaxTotalIops != null)
                    hashCode = hashCode * 59 + MaxTotalIops.GetHashCode();
                    if (MaxReadBandwidth != null)
                    hashCode = hashCode * 59 + MaxReadBandwidth.GetHashCode();
                    if (MaxWriteBandwidth != null)
                    hashCode = hashCode * 59 + MaxWriteBandwidth.GetHashCode();
                    if (MaxMirrorWriteBandwidth != null)
                    hashCode = hashCode * 59 + MaxMirrorWriteBandwidth.GetHashCode();
                    if (MaxTotalBandwidth != null)
                    hashCode = hashCode * 59 + MaxTotalBandwidth.GetHashCode();
                    if (RepeatCount != null)
                    hashCode = hashCode * 59 + RepeatCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PerformanceMetricsByClusterRollup left, PerformanceMetricsByClusterRollup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PerformanceMetricsByClusterRollup left, PerformanceMetricsByClusterRollup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
