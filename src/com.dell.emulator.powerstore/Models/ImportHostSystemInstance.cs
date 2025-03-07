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
    /// Details about an import host system. This resource type has queriable association from host
    /// </summary>
    [DataContract]
    public partial class ImportHostSystemInstance : IEquatable<ImportHostSystemInstance>
    { 
        /// <summary>
        /// Unique identifier of the import host system.
        /// </summary>
        /// <value>Unique identifier of the import host system.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Hostname or IPv4 address of the import host system.
        /// </summary>
        /// <value>Hostname or IPv4 address of the import host system.</value>

        [DataMember(Name="agent_address")]
        public string AgentAddress { get; set; }

        /// <summary>
        /// Gets or Sets AgentType
        /// </summary>

        [DataMember(Name="agent_type")]
        public HostAgentTypeEnum? AgentType { get; set; }

        /// <summary>
        /// TCP port on the import host system.
        /// </summary>
        /// <value>TCP port on the import host system.</value>

        [Range(0, 2147483647)]
        [DataMember(Name="agent_port")]
        public int? AgentPort { get; set; }

        /// <summary>
        /// Version of the import host system.
        /// </summary>
        /// <value>Version of the import host system.</value>

        [DataMember(Name="agent_version")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// API version of the import host system.
        /// </summary>
        /// <value>API version of the import host system.</value>

        [DataMember(Name="agent_api_version")]
        public string AgentApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets OsType
        /// </summary>

        [DataMember(Name="os_type")]
        public HAOSTypeEnum? OsType { get; set; }

        /// <summary>
        /// Operating system version of the import host system.
        /// </summary>
        /// <value>Operating system version of the import host system.</value>

        [DataMember(Name="os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets AgentStatus
        /// </summary>

        [DataMember(Name="agent_status")]
        public HostAgentStatusEnum? AgentStatus { get; set; }

        /// <summary>
        /// Username for the import host system.
        /// </summary>
        /// <value>Username for the import host system.</value>

        [DataMember(Name="user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Time when the import host system was last updated.
        /// </summary>
        /// <value>Time when the import host system was last updated.</value>

        [DataMember(Name="last_update_time")]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Localized message string corresponding to agent_type
        /// </summary>
        /// <value>Localized message string corresponding to agent_type</value>

        [DataMember(Name="agent_type_l10n")]
        public string AgentTypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to os_type
        /// </summary>
        /// <value>Localized message string corresponding to os_type</value>

        [DataMember(Name="os_type_l10n")]
        public string OsTypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to agent_status
        /// </summary>
        /// <value>Localized message string corresponding to agent_status</value>

        [DataMember(Name="agent_status_l10n")]
        public string AgentStatusL10n { get; set; }

        /// <summary>
        /// This is the inverse of the resource type host association.
        /// </summary>
        /// <value>This is the inverse of the resource type host association.</value>

        [DataMember(Name="hosts")]
        public List<HostInstance> Hosts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportHostSystemInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AgentAddress: ").Append(AgentAddress).Append("\n");
            sb.Append("  AgentType: ").Append(AgentType).Append("\n");
            sb.Append("  AgentPort: ").Append(AgentPort).Append("\n");
            sb.Append("  AgentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  AgentApiVersion: ").Append(AgentApiVersion).Append("\n");
            sb.Append("  OsType: ").Append(OsType).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  AgentStatus: ").Append(AgentStatus).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  AgentTypeL10n: ").Append(AgentTypeL10n).Append("\n");
            sb.Append("  OsTypeL10n: ").Append(OsTypeL10n).Append("\n");
            sb.Append("  AgentStatusL10n: ").Append(AgentStatusL10n).Append("\n");
            sb.Append("  Hosts: ").Append(Hosts).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportHostSystemInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportHostSystemInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportHostSystemInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportHostSystemInstance other)
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
                    AgentAddress == other.AgentAddress ||
                    AgentAddress != null &&
                    AgentAddress.Equals(other.AgentAddress)
                ) && 
                (
                    AgentType == other.AgentType ||
                    AgentType != null &&
                    AgentType.Equals(other.AgentType)
                ) && 
                (
                    AgentPort == other.AgentPort ||
                    AgentPort != null &&
                    AgentPort.Equals(other.AgentPort)
                ) && 
                (
                    AgentVersion == other.AgentVersion ||
                    AgentVersion != null &&
                    AgentVersion.Equals(other.AgentVersion)
                ) && 
                (
                    AgentApiVersion == other.AgentApiVersion ||
                    AgentApiVersion != null &&
                    AgentApiVersion.Equals(other.AgentApiVersion)
                ) && 
                (
                    OsType == other.OsType ||
                    OsType != null &&
                    OsType.Equals(other.OsType)
                ) && 
                (
                    OsVersion == other.OsVersion ||
                    OsVersion != null &&
                    OsVersion.Equals(other.OsVersion)
                ) && 
                (
                    AgentStatus == other.AgentStatus ||
                    AgentStatus != null &&
                    AgentStatus.Equals(other.AgentStatus)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    LastUpdateTime == other.LastUpdateTime ||
                    LastUpdateTime != null &&
                    LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    AgentTypeL10n == other.AgentTypeL10n ||
                    AgentTypeL10n != null &&
                    AgentTypeL10n.Equals(other.AgentTypeL10n)
                ) && 
                (
                    OsTypeL10n == other.OsTypeL10n ||
                    OsTypeL10n != null &&
                    OsTypeL10n.Equals(other.OsTypeL10n)
                ) && 
                (
                    AgentStatusL10n == other.AgentStatusL10n ||
                    AgentStatusL10n != null &&
                    AgentStatusL10n.Equals(other.AgentStatusL10n)
                ) && 
                (
                    Hosts == other.Hosts ||
                    Hosts != null &&
                    Hosts.SequenceEqual(other.Hosts)
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
                    if (AgentAddress != null)
                    hashCode = hashCode * 59 + AgentAddress.GetHashCode();
                    if (AgentType != null)
                    hashCode = hashCode * 59 + AgentType.GetHashCode();
                    if (AgentPort != null)
                    hashCode = hashCode * 59 + AgentPort.GetHashCode();
                    if (AgentVersion != null)
                    hashCode = hashCode * 59 + AgentVersion.GetHashCode();
                    if (AgentApiVersion != null)
                    hashCode = hashCode * 59 + AgentApiVersion.GetHashCode();
                    if (OsType != null)
                    hashCode = hashCode * 59 + OsType.GetHashCode();
                    if (OsVersion != null)
                    hashCode = hashCode * 59 + OsVersion.GetHashCode();
                    if (AgentStatus != null)
                    hashCode = hashCode * 59 + AgentStatus.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (LastUpdateTime != null)
                    hashCode = hashCode * 59 + LastUpdateTime.GetHashCode();
                    if (AgentTypeL10n != null)
                    hashCode = hashCode * 59 + AgentTypeL10n.GetHashCode();
                    if (OsTypeL10n != null)
                    hashCode = hashCode * 59 + OsTypeL10n.GetHashCode();
                    if (AgentStatusL10n != null)
                    hashCode = hashCode * 59 + AgentStatusL10n.GetHashCode();
                    if (Hosts != null)
                    hashCode = hashCode * 59 + Hosts.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportHostSystemInstance left, ImportHostSystemInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportHostSystemInstance left, ImportHostSystemInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
