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
    public partial class MigrationRecommendationInstance : IEquatable<MigrationRecommendationInstance>
    { 
        /// <summary>
        /// Unique ID of recommendation.
        /// </summary>
        /// <value>Unique ID of recommendation.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Time at which recommendation was created.
        /// </summary>
        /// <value>Time at which recommendation was created.</value>

        [DataMember(Name="created_timestamp")]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>

        [DataMember(Name="state")]
        public MigrationRecommendationStateEnum? State { get; set; }

        /// <summary>
        /// Unitless value describing estimated cost to migrate all volumes for this recommendation relative to other recommendations.
        /// </summary>
        /// <value>Unitless value describing estimated cost to migrate all volumes for this recommendation relative to other recommendations.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="estimated_cost")]
        public long? EstimatedCost { get; set; }

        /// <summary>
        /// Type of request that generated a migration recommendation. Evacuate_Appliance - A recommendation to evacuate space by auto selecting storage objects from an appliance using specified size. 
        /// </summary>
        /// <value>Type of request that generated a migration recommendation. Evacuate_Appliance - A recommendation to evacuate space by auto selecting storage objects from an appliance using specified size. </value>

        [DataMember(Name="type")]
        public MigrationRecommendationTypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets RequestParameters
        /// </summary>

        [DataMember(Name="request_parameters")]
        public MigrationRecommendationCreate RequestParameters { get; set; }

        /// <summary>
        /// Time at which migration sessions were created for the recommendation.  Null if migration sessions have not been created.
        /// </summary>
        /// <value>Time at which migration sessions were created for the recommendation.  Null if migration sessions have not been created.</value>

        [DataMember(Name="sessions_created_timestamp")]
        public DateTime? SessionsCreatedTimestamp { get; set; }

        /// <summary>
        /// Time at which all migration sessions for the recommendation were complete. Null if migration sessions have not been created/started or if any migration pursuant to the recommendation is still ongoing. 
        /// </summary>
        /// <value>Time at which all migration sessions for the recommendation were complete. Null if migration sessions have not been created/started or if any migration pursuant to the recommendation is still ongoing. </value>

        [DataMember(Name="sessions_completed_timestamp")]
        public DateTime? SessionsCompletedTimestamp { get; set; }

        /// <summary>
        /// IDs of hosts that must be rescanned after migration sessions are created but before migration sessions are started.
        /// </summary>
        /// <value>IDs of hosts that must be rescanned after migration sessions are created but before migration sessions are started.</value>

        [DataMember(Name="rescan_host_list")]
        public List<string> RescanHostList { get; set; }

        /// <summary>
        /// Filtering on the fields of this embedded resource is not supported.
        /// </summary>
        /// <value>Filtering on the fields of this embedded resource is not supported.</value>

        [DataMember(Name="migration_actions")]
        public List<MigrationRecommendationAction> MigrationActions { get; set; }

        /// <summary>
        /// Localized message string corresponding to state
        /// </summary>
        /// <value>Localized message string corresponding to state</value>

        [DataMember(Name="state_l10n")]
        public string StateL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to type
        /// </summary>
        /// <value>Localized message string corresponding to type</value>

        [DataMember(Name="type_l10n")]
        public string TypeL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationRecommendationInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  EstimatedCost: ").Append(EstimatedCost).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RequestParameters: ").Append(RequestParameters).Append("\n");
            sb.Append("  SessionsCreatedTimestamp: ").Append(SessionsCreatedTimestamp).Append("\n");
            sb.Append("  SessionsCompletedTimestamp: ").Append(SessionsCompletedTimestamp).Append("\n");
            sb.Append("  RescanHostList: ").Append(RescanHostList).Append("\n");
            sb.Append("  MigrationActions: ").Append(MigrationActions).Append("\n");
            sb.Append("  StateL10n: ").Append(StateL10n).Append("\n");
            sb.Append("  TypeL10n: ").Append(TypeL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MigrationRecommendationInstance)obj);
        }

        /// <summary>
        /// Returns true if MigrationRecommendationInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of MigrationRecommendationInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationRecommendationInstance other)
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
                    CreatedTimestamp == other.CreatedTimestamp ||
                    CreatedTimestamp != null &&
                    CreatedTimestamp.Equals(other.CreatedTimestamp)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    EstimatedCost == other.EstimatedCost ||
                    EstimatedCost != null &&
                    EstimatedCost.Equals(other.EstimatedCost)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    RequestParameters == other.RequestParameters ||
                    RequestParameters != null &&
                    RequestParameters.Equals(other.RequestParameters)
                ) && 
                (
                    SessionsCreatedTimestamp == other.SessionsCreatedTimestamp ||
                    SessionsCreatedTimestamp != null &&
                    SessionsCreatedTimestamp.Equals(other.SessionsCreatedTimestamp)
                ) && 
                (
                    SessionsCompletedTimestamp == other.SessionsCompletedTimestamp ||
                    SessionsCompletedTimestamp != null &&
                    SessionsCompletedTimestamp.Equals(other.SessionsCompletedTimestamp)
                ) && 
                (
                    RescanHostList == other.RescanHostList ||
                    RescanHostList != null &&
                    RescanHostList.SequenceEqual(other.RescanHostList)
                ) && 
                (
                    MigrationActions == other.MigrationActions ||
                    MigrationActions != null &&
                    MigrationActions.SequenceEqual(other.MigrationActions)
                ) && 
                (
                    StateL10n == other.StateL10n ||
                    StateL10n != null &&
                    StateL10n.Equals(other.StateL10n)
                ) && 
                (
                    TypeL10n == other.TypeL10n ||
                    TypeL10n != null &&
                    TypeL10n.Equals(other.TypeL10n)
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
                    if (CreatedTimestamp != null)
                    hashCode = hashCode * 59 + CreatedTimestamp.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (EstimatedCost != null)
                    hashCode = hashCode * 59 + EstimatedCost.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (RequestParameters != null)
                    hashCode = hashCode * 59 + RequestParameters.GetHashCode();
                    if (SessionsCreatedTimestamp != null)
                    hashCode = hashCode * 59 + SessionsCreatedTimestamp.GetHashCode();
                    if (SessionsCompletedTimestamp != null)
                    hashCode = hashCode * 59 + SessionsCompletedTimestamp.GetHashCode();
                    if (RescanHostList != null)
                    hashCode = hashCode * 59 + RescanHostList.GetHashCode();
                    if (MigrationActions != null)
                    hashCode = hashCode * 59 + MigrationActions.GetHashCode();
                    if (StateL10n != null)
                    hashCode = hashCode * 59 + StateL10n.GetHashCode();
                    if (TypeL10n != null)
                    hashCode = hashCode * 59 + TypeL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MigrationRecommendationInstance left, MigrationRecommendationInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MigrationRecommendationInstance left, MigrationRecommendationInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
