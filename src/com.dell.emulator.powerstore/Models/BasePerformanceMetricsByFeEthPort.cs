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
    /// Performance metrics for the frontend ethernet port collected at twenty second interval.
    /// </summary>
    [DataContract]
    public partial class BasePerformanceMetricsByFeEthPort : IEquatable<BasePerformanceMetricsByFeEthPort>
    { 
        /// <summary>
        /// Reference to the associated frontend ethernet port (eth_port) on which these metrics were recorded.
        /// </summary>
        /// <value>Reference to the associated frontend ethernet port (eth_port) on which these metrics were recorded.</value>

        [DataMember(Name="fe_port_id")]
        public string FePortId { get; set; }

        /// <summary>
        /// Reference to the node the port belongs to.
        /// </summary>
        /// <value>Reference to the node the port belongs to.</value>

        [DataMember(Name="node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// Reference to the associated appliance on which these metrics were recorded.
        /// </summary>
        /// <value>Reference to the associated appliance on which these metrics were recorded.</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// End of sample period.
        /// </summary>
        /// <value>End of sample period.</value>

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The total bytes received per second.
        /// </summary>
        /// <value>The total bytes received per second.</value>

        [DataMember(Name="bytes_rx_ps")]
        public float? BytesRxPs { get; set; }

        /// <summary>
        /// The total bytes transmitted per second.
        /// </summary>
        /// <value>The total bytes transmitted per second.</value>

        [DataMember(Name="bytes_tx_ps")]
        public float? BytesTxPs { get; set; }

        /// <summary>
        /// The number of packets received per second.
        /// </summary>
        /// <value>The number of packets received per second.</value>

        [DataMember(Name="pkt_rx_ps")]
        public float? PktRxPs { get; set; }

        /// <summary>
        /// The number of packets transmitted per second.
        /// </summary>
        /// <value>The number of packets transmitted per second.</value>

        [DataMember(Name="pkt_tx_ps")]
        public float? PktTxPs { get; set; }

        /// <summary>
        /// The number of packets discarded per second due to lack of buffer space.
        /// </summary>
        /// <value>The number of packets discarded per second due to lack of buffer space.</value>

        [DataMember(Name="pkt_rx_no_buffer_error_ps")]
        public float? PktRxNoBufferErrorPs { get; set; }

        /// <summary>
        /// The number of packets received with CRC error (and thus dropped) per second.
        /// </summary>
        /// <value>The number of packets received with CRC error (and thus dropped) per second.</value>

        [DataMember(Name="pkt_rx_crc_error_ps")]
        public float? PktRxCrcErrorPs { get; set; }

        /// <summary>
        /// The number of packets that failed to be transmitted per second due to error.
        /// </summary>
        /// <value>The number of packets that failed to be transmitted per second due to error.</value>

        [DataMember(Name="pkt_tx_error_ps")]
        public float? PktTxErrorPs { get; set; }

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
            sb.Append("class BasePerformanceMetricsByFeEthPort {\n");
            sb.Append("  FePortId: ").Append(FePortId).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  BytesRxPs: ").Append(BytesRxPs).Append("\n");
            sb.Append("  BytesTxPs: ").Append(BytesTxPs).Append("\n");
            sb.Append("  PktRxPs: ").Append(PktRxPs).Append("\n");
            sb.Append("  PktTxPs: ").Append(PktTxPs).Append("\n");
            sb.Append("  PktRxNoBufferErrorPs: ").Append(PktRxNoBufferErrorPs).Append("\n");
            sb.Append("  PktRxCrcErrorPs: ").Append(PktRxCrcErrorPs).Append("\n");
            sb.Append("  PktTxErrorPs: ").Append(PktTxErrorPs).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BasePerformanceMetricsByFeEthPort)obj);
        }

        /// <summary>
        /// Returns true if BasePerformanceMetricsByFeEthPort instances are equal
        /// </summary>
        /// <param name="other">Instance of BasePerformanceMetricsByFeEthPort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasePerformanceMetricsByFeEthPort other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FePortId == other.FePortId ||
                    FePortId != null &&
                    FePortId.Equals(other.FePortId)
                ) && 
                (
                    NodeId == other.NodeId ||
                    NodeId != null &&
                    NodeId.Equals(other.NodeId)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    BytesRxPs == other.BytesRxPs ||
                    BytesRxPs != null &&
                    BytesRxPs.Equals(other.BytesRxPs)
                ) && 
                (
                    BytesTxPs == other.BytesTxPs ||
                    BytesTxPs != null &&
                    BytesTxPs.Equals(other.BytesTxPs)
                ) && 
                (
                    PktRxPs == other.PktRxPs ||
                    PktRxPs != null &&
                    PktRxPs.Equals(other.PktRxPs)
                ) && 
                (
                    PktTxPs == other.PktTxPs ||
                    PktTxPs != null &&
                    PktTxPs.Equals(other.PktTxPs)
                ) && 
                (
                    PktRxNoBufferErrorPs == other.PktRxNoBufferErrorPs ||
                    PktRxNoBufferErrorPs != null &&
                    PktRxNoBufferErrorPs.Equals(other.PktRxNoBufferErrorPs)
                ) && 
                (
                    PktRxCrcErrorPs == other.PktRxCrcErrorPs ||
                    PktRxCrcErrorPs != null &&
                    PktRxCrcErrorPs.Equals(other.PktRxCrcErrorPs)
                ) && 
                (
                    PktTxErrorPs == other.PktTxErrorPs ||
                    PktTxErrorPs != null &&
                    PktTxErrorPs.Equals(other.PktTxErrorPs)
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
                    if (FePortId != null)
                    hashCode = hashCode * 59 + FePortId.GetHashCode();
                    if (NodeId != null)
                    hashCode = hashCode * 59 + NodeId.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (BytesRxPs != null)
                    hashCode = hashCode * 59 + BytesRxPs.GetHashCode();
                    if (BytesTxPs != null)
                    hashCode = hashCode * 59 + BytesTxPs.GetHashCode();
                    if (PktRxPs != null)
                    hashCode = hashCode * 59 + PktRxPs.GetHashCode();
                    if (PktTxPs != null)
                    hashCode = hashCode * 59 + PktTxPs.GetHashCode();
                    if (PktRxNoBufferErrorPs != null)
                    hashCode = hashCode * 59 + PktRxNoBufferErrorPs.GetHashCode();
                    if (PktRxCrcErrorPs != null)
                    hashCode = hashCode * 59 + PktRxCrcErrorPs.GetHashCode();
                    if (PktTxErrorPs != null)
                    hashCode = hashCode * 59 + PktTxErrorPs.GetHashCode();
                    if (RepeatCount != null)
                    hashCode = hashCode * 59 + RepeatCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BasePerformanceMetricsByFeEthPort left, BasePerformanceMetricsByFeEthPort right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BasePerformanceMetricsByFeEthPort left, BasePerformanceMetricsByFeEthPort right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
