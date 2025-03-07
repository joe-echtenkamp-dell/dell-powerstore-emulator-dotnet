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
    /// 
    /// </summary>
    [DataContract]
    public partial class ApplianceTimeToFullResponse : IEquatable<ApplianceTimeToFullResponse>
    { 
        /// <summary>
        /// Unique ID of appliance.
        /// </summary>
        /// <value>Unique ID of appliance.</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Timestamp of the end of the capacity forecast. If time to full estimates are null, the relevant forecast does not reach full capacity before it ends.  In this case the end of the forecast can be used as a minimum for time to full. 
        /// </summary>
        /// <value>Timestamp of the end of the capacity forecast. If time to full estimates are null, the relevant forecast does not reach full capacity before it ends.  In this case the end of the forecast can be used as a minimum for time to full. </value>

        [DataMember(Name="end_of_forecast")]
        public DateTime? EndOfForecast { get; set; }

        /// <summary>
        /// Estimated date-time at which the forecast value will reach full capacity.
        /// </summary>
        /// <value>Estimated date-time at which the forecast value will reach full capacity.</value>

        [DataMember(Name="time_to_full")]
        public DateTime? TimeToFull { get; set; }

        /// <summary>
        /// Pessimistic date-time for time to full based on the upper bound of the forecast 95% confidence interval.
        /// </summary>
        /// <value>Pessimistic date-time for time to full based on the upper bound of the forecast 95% confidence interval.</value>

        [DataMember(Name="time_to_full_pessimistic")]
        public DateTime? TimeToFullPessimistic { get; set; }

        /// <summary>
        /// Optimistic date-time for time to full based on the lower bound of the forecast 95% confidence interval.
        /// </summary>
        /// <value>Optimistic date-time for time to full based on the lower bound of the forecast 95% confidence interval.</value>

        [DataMember(Name="time_to_full_optimistic")]
        public DateTime? TimeToFullOptimistic { get; set; }

        /// <summary>
        /// Gets or Sets TimeToFullStatus
        /// </summary>

        [DataMember(Name="time_to_full_status")]
        public ForecastTimeToFullStatusEnum? TimeToFullStatus { get; set; }

        /// <summary>
        /// Localized message string corresponding to time_to_full_status
        /// </summary>
        /// <value>Localized message string corresponding to time_to_full_status</value>

        [DataMember(Name="time_to_full_status_l10n")]
        public string TimeToFullStatusL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplianceTimeToFullResponse {\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  EndOfForecast: ").Append(EndOfForecast).Append("\n");
            sb.Append("  TimeToFull: ").Append(TimeToFull).Append("\n");
            sb.Append("  TimeToFullPessimistic: ").Append(TimeToFullPessimistic).Append("\n");
            sb.Append("  TimeToFullOptimistic: ").Append(TimeToFullOptimistic).Append("\n");
            sb.Append("  TimeToFullStatus: ").Append(TimeToFullStatus).Append("\n");
            sb.Append("  TimeToFullStatusL10n: ").Append(TimeToFullStatusL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ApplianceTimeToFullResponse)obj);
        }

        /// <summary>
        /// Returns true if ApplianceTimeToFullResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplianceTimeToFullResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplianceTimeToFullResponse other)
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
                    EndOfForecast == other.EndOfForecast ||
                    EndOfForecast != null &&
                    EndOfForecast.Equals(other.EndOfForecast)
                ) && 
                (
                    TimeToFull == other.TimeToFull ||
                    TimeToFull != null &&
                    TimeToFull.Equals(other.TimeToFull)
                ) && 
                (
                    TimeToFullPessimistic == other.TimeToFullPessimistic ||
                    TimeToFullPessimistic != null &&
                    TimeToFullPessimistic.Equals(other.TimeToFullPessimistic)
                ) && 
                (
                    TimeToFullOptimistic == other.TimeToFullOptimistic ||
                    TimeToFullOptimistic != null &&
                    TimeToFullOptimistic.Equals(other.TimeToFullOptimistic)
                ) && 
                (
                    TimeToFullStatus == other.TimeToFullStatus ||
                    TimeToFullStatus != null &&
                    TimeToFullStatus.Equals(other.TimeToFullStatus)
                ) && 
                (
                    TimeToFullStatusL10n == other.TimeToFullStatusL10n ||
                    TimeToFullStatusL10n != null &&
                    TimeToFullStatusL10n.Equals(other.TimeToFullStatusL10n)
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
                    if (EndOfForecast != null)
                    hashCode = hashCode * 59 + EndOfForecast.GetHashCode();
                    if (TimeToFull != null)
                    hashCode = hashCode * 59 + TimeToFull.GetHashCode();
                    if (TimeToFullPessimistic != null)
                    hashCode = hashCode * 59 + TimeToFullPessimistic.GetHashCode();
                    if (TimeToFullOptimistic != null)
                    hashCode = hashCode * 59 + TimeToFullOptimistic.GetHashCode();
                    if (TimeToFullStatus != null)
                    hashCode = hashCode * 59 + TimeToFullStatus.GetHashCode();
                    if (TimeToFullStatusL10n != null)
                    hashCode = hashCode * 59 + TimeToFullStatusL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApplianceTimeToFullResponse left, ApplianceTimeToFullResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApplianceTimeToFullResponse left, ApplianceTimeToFullResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
