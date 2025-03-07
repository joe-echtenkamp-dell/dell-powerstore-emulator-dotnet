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
    /// Space metrics for the file system collected at five minute interval. Was added in version 3.0.0.0.
    /// </summary>
    [DataContract]
    public partial class BaseSpaceMetricsByFileSystem : IEquatable<BaseSpaceMetricsByFileSystem>
    { 
        /// <summary>
        /// Unique identifier of the appliance.
        /// </summary>
        /// <value>Unique identifier of the appliance.</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Unique identifier of the file system.
        /// </summary>
        /// <value>Unique identifier of the file system.</value>

        [DataMember(Name="file_system_id")]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Time at the beginning of sample period.
        /// </summary>
        /// <value>Time at the beginning of sample period.</value>

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Number of consecutive sampling periods during which there were no changes in the metrics values.  If the value is omitted from the response, it is 1 (no additional repeats).      &#39; 
        /// </summary>
        /// <value>Number of consecutive sampling periods during which there were no changes in the metrics values.  If the value is omitted from the response, it is 1 (no additional repeats).      &#39; </value>

        [Range(0, 2147483647)]
        [DataMember(Name="repeat_count")]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Last logical provisioned space during the period.
        /// </summary>
        /// <value>Last logical provisioned space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="logical_provisioned")]
        public long? LogicalProvisioned { get; set; }

        /// <summary>
        /// Last logical used space during the period.
        /// </summary>
        /// <value>Last logical used space during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="logical_used")]
        public long? LogicalUsed { get; set; }

        /// <summary>
        /// Last thin savings ratio during the period.
        /// </summary>
        /// <value>Last thin savings ratio during the period.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="thin_savings")]
        public long? ThinSavings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseSpaceMetricsByFileSystem {\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  FileSystemId: ").Append(FileSystemId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  RepeatCount: ").Append(RepeatCount).Append("\n");
            sb.Append("  LogicalProvisioned: ").Append(LogicalProvisioned).Append("\n");
            sb.Append("  LogicalUsed: ").Append(LogicalUsed).Append("\n");
            sb.Append("  ThinSavings: ").Append(ThinSavings).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BaseSpaceMetricsByFileSystem)obj);
        }

        /// <summary>
        /// Returns true if BaseSpaceMetricsByFileSystem instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseSpaceMetricsByFileSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseSpaceMetricsByFileSystem other)
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
                    FileSystemId == other.FileSystemId ||
                    FileSystemId != null &&
                    FileSystemId.Equals(other.FileSystemId)
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
                    ThinSavings == other.ThinSavings ||
                    ThinSavings != null &&
                    ThinSavings.Equals(other.ThinSavings)
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
                    if (FileSystemId != null)
                    hashCode = hashCode * 59 + FileSystemId.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (RepeatCount != null)
                    hashCode = hashCode * 59 + RepeatCount.GetHashCode();
                    if (LogicalProvisioned != null)
                    hashCode = hashCode * 59 + LogicalProvisioned.GetHashCode();
                    if (LogicalUsed != null)
                    hashCode = hashCode * 59 + LogicalUsed.GetHashCode();
                    if (ThinSavings != null)
                    hashCode = hashCode * 59 + ThinSavings.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BaseSpaceMetricsByFileSystem left, BaseSpaceMetricsByFileSystem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseSpaceMetricsByFileSystem left, BaseSpaceMetricsByFileSystem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
