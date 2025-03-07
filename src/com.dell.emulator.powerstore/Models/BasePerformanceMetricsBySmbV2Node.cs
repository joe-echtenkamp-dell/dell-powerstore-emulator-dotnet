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
    /// Performance metrics for the smb v1 node collected at twenty second interval.
    /// </summary>
    [DataContract]
    public partial class BasePerformanceMetricsBySmbV2Node : IEquatable<BasePerformanceMetricsBySmbV2Node>
    { 
        /// <summary>
        /// Unique identifier of the appliance. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Unique identifier of the appliance. Was added in version 3.0.0.0.</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Unique identifier of the node.
        /// </summary>
        /// <value>Unique identifier of the node.</value>

        [DataMember(Name="node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// End of sample period.
        /// </summary>
        /// <value>End of sample period.</value>

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Number of consecutive sampling periods during which there were no changes in the metrics values. If the value is omitted from the response, it is 1 (no additional repeats). 
        /// </summary>
        /// <value>Number of consecutive sampling periods during which there were no changes in the metrics values. If the value is omitted from the response, it is 1 (no additional repeats). </value>

        [Range(0, 2147483647)]
        [DataMember(Name="repeat_count")]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Total read operations per second.
        /// </summary>
        /// <value>Total read operations per second.</value>

        [DataMember(Name="read_iops")]
        public float? ReadIops { get; set; }

        /// <summary>
        /// Total write operations per second.
        /// </summary>
        /// <value>Total write operations per second.</value>

        [DataMember(Name="write_iops")]
        public float? WriteIops { get; set; }

        /// <summary>
        /// Total read and write operations per second.
        /// </summary>
        /// <value>Total read and write operations per second.</value>

        [DataMember(Name="total_iops")]
        public float? TotalIops { get; set; }

        /// <summary>
        /// Total calls.
        /// </summary>
        /// <value>Total calls.</value>

        [DataMember(Name="total_calls")]
        public float? TotalCalls { get; set; }

        /// <summary>
        /// Average read latency in microseconds.
        /// </summary>
        /// <value>Average read latency in microseconds.</value>

        [DataMember(Name="avg_read_latency")]
        public float? AvgReadLatency { get; set; }

        /// <summary>
        /// Average write latency in microseconds.
        /// </summary>
        /// <value>Average write latency in microseconds.</value>

        [DataMember(Name="avg_write_latency")]
        public float? AvgWriteLatency { get; set; }

        /// <summary>
        /// Average read and write latency in microseconds.
        /// </summary>
        /// <value>Average read and write latency in microseconds.</value>

        [DataMember(Name="avg_latency")]
        public float? AvgLatency { get; set; }

        /// <summary>
        /// Average read size in bytes.
        /// </summary>
        /// <value>Average read size in bytes.</value>

        [DataMember(Name="avg_read_size")]
        public float? AvgReadSize { get; set; }

        /// <summary>
        /// Average write size in bytes.
        /// </summary>
        /// <value>Average write size in bytes.</value>

        [DataMember(Name="avg_write_size")]
        public float? AvgWriteSize { get; set; }

        /// <summary>
        /// Average read and write size in bytes.
        /// </summary>
        /// <value>Average read and write size in bytes.</value>

        [DataMember(Name="avg_io_size")]
        public float? AvgIoSize { get; set; }

        /// <summary>
        /// Current TCP Connections. Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Current TCP Connections. Was added in version 3.0.0.0.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="current_tcp_connections")]
        public int? CurrentTcpConnections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasePerformanceMetricsBySmbV2Node {\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  RepeatCount: ").Append(RepeatCount).Append("\n");
            sb.Append("  ReadIops: ").Append(ReadIops).Append("\n");
            sb.Append("  WriteIops: ").Append(WriteIops).Append("\n");
            sb.Append("  TotalIops: ").Append(TotalIops).Append("\n");
            sb.Append("  TotalCalls: ").Append(TotalCalls).Append("\n");
            sb.Append("  AvgReadLatency: ").Append(AvgReadLatency).Append("\n");
            sb.Append("  AvgWriteLatency: ").Append(AvgWriteLatency).Append("\n");
            sb.Append("  AvgLatency: ").Append(AvgLatency).Append("\n");
            sb.Append("  AvgReadSize: ").Append(AvgReadSize).Append("\n");
            sb.Append("  AvgWriteSize: ").Append(AvgWriteSize).Append("\n");
            sb.Append("  AvgIoSize: ").Append(AvgIoSize).Append("\n");
            sb.Append("  CurrentTcpConnections: ").Append(CurrentTcpConnections).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BasePerformanceMetricsBySmbV2Node)obj);
        }

        /// <summary>
        /// Returns true if BasePerformanceMetricsBySmbV2Node instances are equal
        /// </summary>
        /// <param name="other">Instance of BasePerformanceMetricsBySmbV2Node to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasePerformanceMetricsBySmbV2Node other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    NodeId == other.NodeId ||
                    NodeId != null &&
                    NodeId.Equals(other.NodeId)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    RepeatCount == other.RepeatCount ||
                    RepeatCount != null &&
                    RepeatCount.Equals(other.RepeatCount)
                ) && 
                (
                    ReadIops == other.ReadIops ||
                    ReadIops != null &&
                    ReadIops.Equals(other.ReadIops)
                ) && 
                (
                    WriteIops == other.WriteIops ||
                    WriteIops != null &&
                    WriteIops.Equals(other.WriteIops)
                ) && 
                (
                    TotalIops == other.TotalIops ||
                    TotalIops != null &&
                    TotalIops.Equals(other.TotalIops)
                ) && 
                (
                    TotalCalls == other.TotalCalls ||
                    TotalCalls != null &&
                    TotalCalls.Equals(other.TotalCalls)
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
                    CurrentTcpConnections == other.CurrentTcpConnections ||
                    CurrentTcpConnections != null &&
                    CurrentTcpConnections.Equals(other.CurrentTcpConnections)
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
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (NodeId != null)
                    hashCode = hashCode * 59 + NodeId.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (RepeatCount != null)
                    hashCode = hashCode * 59 + RepeatCount.GetHashCode();
                    if (ReadIops != null)
                    hashCode = hashCode * 59 + ReadIops.GetHashCode();
                    if (WriteIops != null)
                    hashCode = hashCode * 59 + WriteIops.GetHashCode();
                    if (TotalIops != null)
                    hashCode = hashCode * 59 + TotalIops.GetHashCode();
                    if (TotalCalls != null)
                    hashCode = hashCode * 59 + TotalCalls.GetHashCode();
                    if (AvgReadLatency != null)
                    hashCode = hashCode * 59 + AvgReadLatency.GetHashCode();
                    if (AvgWriteLatency != null)
                    hashCode = hashCode * 59 + AvgWriteLatency.GetHashCode();
                    if (AvgLatency != null)
                    hashCode = hashCode * 59 + AvgLatency.GetHashCode();
                    if (AvgReadSize != null)
                    hashCode = hashCode * 59 + AvgReadSize.GetHashCode();
                    if (AvgWriteSize != null)
                    hashCode = hashCode * 59 + AvgWriteSize.GetHashCode();
                    if (AvgIoSize != null)
                    hashCode = hashCode * 59 + AvgIoSize.GetHashCode();
                    if (CurrentTcpConnections != null)
                    hashCode = hashCode * 59 + CurrentTcpConnections.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BasePerformanceMetricsBySmbV2Node left, BasePerformanceMetricsBySmbV2Node right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BasePerformanceMetricsBySmbV2Node left, BasePerformanceMetricsBySmbV2Node right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
