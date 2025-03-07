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
    /// Summary of host group level performance metric data for various rollup intervals beginning with timestamp, including the average and maximum values for that period. Was added in version 3.0.0.0.
    /// </summary>
    [DataContract]
    public partial class BasePerformanceMetricsByHgRollup : IEquatable<BasePerformanceMetricsByHgRollup>
    { 
        /// <summary>
        /// Reference to the associated host group for which these metrics were recorded.
        /// </summary>
        /// <value>Reference to the associated host group for which these metrics were recorded.</value>

        [DataMember(Name="hg_id")]
        public string HgId { get; set; }

        /// <summary>
        /// End of sample period.
        /// </summary>
        /// <value>End of sample period.</value>

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

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
        /// Average total input and output operations per second.
        /// </summary>
        /// <value>Average total input and output operations per second.</value>

        [DataMember(Name="avg_total_iops")]
        public decimal? AvgTotalIops { get; set; }

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
        /// Weighted average latency in microseconds.
        /// </summary>
        /// <value>Weighted average latency in microseconds.</value>

        [DataMember(Name="avg_latency")]
        public float? AvgLatency { get; set; }

        /// <summary>
        /// Weighted average read bandwidth in bytes per second.
        /// </summary>
        /// <value>Weighted average read bandwidth in bytes per second.</value>

        [DataMember(Name="avg_read_bandwidth")]
        public float? AvgReadBandwidth { get; set; }

        /// <summary>
        /// Weighted average write bandwidth in bytes per second.
        /// </summary>
        /// <value>Weighted average write bandwidth in bytes per second.</value>

        [DataMember(Name="avg_write_bandwidth")]
        public float? AvgWriteBandwidth { get; set; }

        /// <summary>
        /// Weighted average total bandwidth in bytes per second.
        /// </summary>
        /// <value>Weighted average total bandwidth in bytes per second.</value>

        [DataMember(Name="avg_total_bandwidth")]
        public float? AvgTotalBandwidth { get; set; }

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
        /// Maximum totals per second.
        /// </summary>
        /// <value>Maximum totals per second.</value>

        [DataMember(Name="max_total_iops")]
        public decimal? MaxTotalIops { get; set; }

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
        /// Maximum of average latency in microseconds.
        /// </summary>
        /// <value>Maximum of average latency in microseconds.</value>

        [DataMember(Name="max_avg_latency")]
        public float? MaxAvgLatency { get; set; }

        /// <summary>
        /// Maximum read bandwidth in bytes per second.
        /// </summary>
        /// <value>Maximum read bandwidth in bytes per second.</value>

        [DataMember(Name="max_read_bandwidth")]
        public float? MaxReadBandwidth { get; set; }

        /// <summary>
        /// Maximum write bandwith in bytes per second.
        /// </summary>
        /// <value>Maximum write bandwith in bytes per second.</value>

        [DataMember(Name="max_write_bandwidth")]
        public float? MaxWriteBandwidth { get; set; }

        /// <summary>
        /// Maximum total bandwidth in bytes per second.
        /// </summary>
        /// <value>Maximum total bandwidth in bytes per second.</value>

        [DataMember(Name="max_total_bandwidth")]
        public float? MaxTotalBandwidth { get; set; }

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
            sb.Append("class BasePerformanceMetricsByHgRollup {\n");
            sb.Append("  HgId: ").Append(HgId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  AvgReadIops: ").Append(AvgReadIops).Append("\n");
            sb.Append("  AvgWriteIops: ").Append(AvgWriteIops).Append("\n");
            sb.Append("  AvgTotalIops: ").Append(AvgTotalIops).Append("\n");
            sb.Append("  AvgReadLatency: ").Append(AvgReadLatency).Append("\n");
            sb.Append("  AvgWriteLatency: ").Append(AvgWriteLatency).Append("\n");
            sb.Append("  AvgLatency: ").Append(AvgLatency).Append("\n");
            sb.Append("  AvgReadBandwidth: ").Append(AvgReadBandwidth).Append("\n");
            sb.Append("  AvgWriteBandwidth: ").Append(AvgWriteBandwidth).Append("\n");
            sb.Append("  AvgTotalBandwidth: ").Append(AvgTotalBandwidth).Append("\n");
            sb.Append("  AvgReadSize: ").Append(AvgReadSize).Append("\n");
            sb.Append("  AvgWriteSize: ").Append(AvgWriteSize).Append("\n");
            sb.Append("  AvgIoSize: ").Append(AvgIoSize).Append("\n");
            sb.Append("  MaxReadIops: ").Append(MaxReadIops).Append("\n");
            sb.Append("  MaxWriteIops: ").Append(MaxWriteIops).Append("\n");
            sb.Append("  MaxTotalIops: ").Append(MaxTotalIops).Append("\n");
            sb.Append("  MaxAvgReadLatency: ").Append(MaxAvgReadLatency).Append("\n");
            sb.Append("  MaxAvgWriteLatency: ").Append(MaxAvgWriteLatency).Append("\n");
            sb.Append("  MaxAvgLatency: ").Append(MaxAvgLatency).Append("\n");
            sb.Append("  MaxReadBandwidth: ").Append(MaxReadBandwidth).Append("\n");
            sb.Append("  MaxWriteBandwidth: ").Append(MaxWriteBandwidth).Append("\n");
            sb.Append("  MaxTotalBandwidth: ").Append(MaxTotalBandwidth).Append("\n");
            sb.Append("  MaxAvgReadSize: ").Append(MaxAvgReadSize).Append("\n");
            sb.Append("  MaxAvgWriteSize: ").Append(MaxAvgWriteSize).Append("\n");
            sb.Append("  MaxAvgIoSize: ").Append(MaxAvgIoSize).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BasePerformanceMetricsByHgRollup)obj);
        }

        /// <summary>
        /// Returns true if BasePerformanceMetricsByHgRollup instances are equal
        /// </summary>
        /// <param name="other">Instance of BasePerformanceMetricsByHgRollup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasePerformanceMetricsByHgRollup other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HgId == other.HgId ||
                    HgId != null &&
                    HgId.Equals(other.HgId)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
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
                    AvgTotalIops == other.AvgTotalIops ||
                    AvgTotalIops != null &&
                    AvgTotalIops.Equals(other.AvgTotalIops)
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
                    AvgLatency == other.AvgLatency ||
                    AvgLatency != null &&
                    AvgLatency.Equals(other.AvgLatency)
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
                    AvgTotalBandwidth == other.AvgTotalBandwidth ||
                    AvgTotalBandwidth != null &&
                    AvgTotalBandwidth.Equals(other.AvgTotalBandwidth)
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
                    MaxTotalIops == other.MaxTotalIops ||
                    MaxTotalIops != null &&
                    MaxTotalIops.Equals(other.MaxTotalIops)
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
                    MaxAvgLatency == other.MaxAvgLatency ||
                    MaxAvgLatency != null &&
                    MaxAvgLatency.Equals(other.MaxAvgLatency)
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
                    MaxTotalBandwidth == other.MaxTotalBandwidth ||
                    MaxTotalBandwidth != null &&
                    MaxTotalBandwidth.Equals(other.MaxTotalBandwidth)
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
                    if (HgId != null)
                    hashCode = hashCode * 59 + HgId.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (AvgReadIops != null)
                    hashCode = hashCode * 59 + AvgReadIops.GetHashCode();
                    if (AvgWriteIops != null)
                    hashCode = hashCode * 59 + AvgWriteIops.GetHashCode();
                    if (AvgTotalIops != null)
                    hashCode = hashCode * 59 + AvgTotalIops.GetHashCode();
                    if (AvgReadLatency != null)
                    hashCode = hashCode * 59 + AvgReadLatency.GetHashCode();
                    if (AvgWriteLatency != null)
                    hashCode = hashCode * 59 + AvgWriteLatency.GetHashCode();
                    if (AvgLatency != null)
                    hashCode = hashCode * 59 + AvgLatency.GetHashCode();
                    if (AvgReadBandwidth != null)
                    hashCode = hashCode * 59 + AvgReadBandwidth.GetHashCode();
                    if (AvgWriteBandwidth != null)
                    hashCode = hashCode * 59 + AvgWriteBandwidth.GetHashCode();
                    if (AvgTotalBandwidth != null)
                    hashCode = hashCode * 59 + AvgTotalBandwidth.GetHashCode();
                    if (AvgReadSize != null)
                    hashCode = hashCode * 59 + AvgReadSize.GetHashCode();
                    if (AvgWriteSize != null)
                    hashCode = hashCode * 59 + AvgWriteSize.GetHashCode();
                    if (AvgIoSize != null)
                    hashCode = hashCode * 59 + AvgIoSize.GetHashCode();
                    if (MaxReadIops != null)
                    hashCode = hashCode * 59 + MaxReadIops.GetHashCode();
                    if (MaxWriteIops != null)
                    hashCode = hashCode * 59 + MaxWriteIops.GetHashCode();
                    if (MaxTotalIops != null)
                    hashCode = hashCode * 59 + MaxTotalIops.GetHashCode();
                    if (MaxAvgReadLatency != null)
                    hashCode = hashCode * 59 + MaxAvgReadLatency.GetHashCode();
                    if (MaxAvgWriteLatency != null)
                    hashCode = hashCode * 59 + MaxAvgWriteLatency.GetHashCode();
                    if (MaxAvgLatency != null)
                    hashCode = hashCode * 59 + MaxAvgLatency.GetHashCode();
                    if (MaxReadBandwidth != null)
                    hashCode = hashCode * 59 + MaxReadBandwidth.GetHashCode();
                    if (MaxWriteBandwidth != null)
                    hashCode = hashCode * 59 + MaxWriteBandwidth.GetHashCode();
                    if (MaxTotalBandwidth != null)
                    hashCode = hashCode * 59 + MaxTotalBandwidth.GetHashCode();
                    if (MaxAvgReadSize != null)
                    hashCode = hashCode * 59 + MaxAvgReadSize.GetHashCode();
                    if (MaxAvgWriteSize != null)
                    hashCode = hashCode * 59 + MaxAvgWriteSize.GetHashCode();
                    if (MaxAvgIoSize != null)
                    hashCode = hashCode * 59 + MaxAvgIoSize.GetHashCode();
                    if (RepeatCount != null)
                    hashCode = hashCode * 59 + RepeatCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BasePerformanceMetricsByHgRollup left, BasePerformanceMetricsByHgRollup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BasePerformanceMetricsByHgRollup left, BasePerformanceMetricsByHgRollup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
