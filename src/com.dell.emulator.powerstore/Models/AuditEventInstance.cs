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
    public partial class AuditEventInstance : IEquatable<AuditEventInstance>
    { 
        /// <summary>
        /// Unique identifier of the audit log entry.
        /// </summary>
        /// <value>Unique identifier of the audit log entry.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public AuditEventTypeEnum? Type { get; set; }

        /// <summary>
        /// Time the event occurred to one second precision.
        /// </summary>
        /// <value>Time the event occurred to one second precision.</value>

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Fully qualified name of the user who initiated the event to be audited. For example, domain_name/name.
        /// </summary>
        /// <value>Fully qualified name of the user who initiated the event to be audited. For example, domain_name/name.</value>

        [DataMember(Name="username")]
        public string Username { get; set; }

        /// <summary>
        /// Whether the event was successful or not.
        /// </summary>
        /// <value>Whether the event was successful or not.</value>

        [DataMember(Name="is_successful")]
        public bool? IsSuccessful { get; set; }

        /// <summary>
        /// FQDN/IP Address of the client from where the event was initiated.
        /// </summary>
        /// <value>FQDN/IP Address of the client from where the event was initiated.</value>

        [DataMember(Name="client_address")]
        public string ClientAddress { get; set; }

        /// <summary>
        /// IP Address on which the request was targeted.
        /// </summary>
        /// <value>IP Address on which the request was targeted.</value>

        [DataMember(Name="server_address")]
        public string ServerAddress { get; set; }

        /// <summary>
        /// Unique identifier of the appliance where the event occurred.
        /// </summary>
        /// <value>Unique identifier of the appliance where the event occurred.</value>

        [DataMember(Name="appliance_id")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Unique identifier of the job associated with the audit event (if any).
        /// </summary>
        /// <value>Unique identifier of the job associated with the audit event (if any).</value>

        [DataMember(Name="job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>

        [DataMember(Name="resource_type")]
        public ResourceTypeEnum? ResourceType { get; set; }

        /// <summary>
        /// Gets or Sets ResourceAction
        /// </summary>

        [DataMember(Name="resource_action")]
        public ResourceActionEnum? ResourceAction { get; set; }

        /// <summary>
        /// Unique identifier of the message for this audit_event.
        /// </summary>
        /// <value>Unique identifier of the message for this audit_event.</value>

        [DataMember(Name="message_code")]
        public string MessageCode { get; set; }

        /// <summary>
        /// Arguments (if applicable) for the audit_event message.
        /// </summary>
        /// <value>Arguments (if applicable) for the audit_event message.</value>

        [DataMember(Name="message_arguments")]
        public List<string> MessageArguments { get; set; }

        /// <summary>
        /// Localized message string corresponding to message_code.
        /// </summary>
        /// <value>Localized message string corresponding to message_code.</value>

        [DataMember(Name="message_l10n")]
        public string MessageL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to type
        /// </summary>
        /// <value>Localized message string corresponding to type</value>

        [DataMember(Name="type_l10n")]
        public string TypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to resource_type
        /// </summary>
        /// <value>Localized message string corresponding to resource_type</value>

        [DataMember(Name="resource_type_l10n")]
        public string ResourceTypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to resource_action
        /// </summary>
        /// <value>Localized message string corresponding to resource_action</value>

        [DataMember(Name="resource_action_l10n")]
        public string ResourceActionL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditEventInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  IsSuccessful: ").Append(IsSuccessful).Append("\n");
            sb.Append("  ClientAddress: ").Append(ClientAddress).Append("\n");
            sb.Append("  ServerAddress: ").Append(ServerAddress).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  ResourceAction: ").Append(ResourceAction).Append("\n");
            sb.Append("  MessageCode: ").Append(MessageCode).Append("\n");
            sb.Append("  MessageArguments: ").Append(MessageArguments).Append("\n");
            sb.Append("  MessageL10n: ").Append(MessageL10n).Append("\n");
            sb.Append("  TypeL10n: ").Append(TypeL10n).Append("\n");
            sb.Append("  ResourceTypeL10n: ").Append(ResourceTypeL10n).Append("\n");
            sb.Append("  ResourceActionL10n: ").Append(ResourceActionL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AuditEventInstance)obj);
        }

        /// <summary>
        /// Returns true if AuditEventInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditEventInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditEventInstance other)
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
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) && 
                (
                    IsSuccessful == other.IsSuccessful ||
                    IsSuccessful != null &&
                    IsSuccessful.Equals(other.IsSuccessful)
                ) && 
                (
                    ClientAddress == other.ClientAddress ||
                    ClientAddress != null &&
                    ClientAddress.Equals(other.ClientAddress)
                ) && 
                (
                    ServerAddress == other.ServerAddress ||
                    ServerAddress != null &&
                    ServerAddress.Equals(other.ServerAddress)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    JobId == other.JobId ||
                    JobId != null &&
                    JobId.Equals(other.JobId)
                ) && 
                (
                    ResourceType == other.ResourceType ||
                    ResourceType != null &&
                    ResourceType.Equals(other.ResourceType)
                ) && 
                (
                    ResourceAction == other.ResourceAction ||
                    ResourceAction != null &&
                    ResourceAction.Equals(other.ResourceAction)
                ) && 
                (
                    MessageCode == other.MessageCode ||
                    MessageCode != null &&
                    MessageCode.Equals(other.MessageCode)
                ) && 
                (
                    MessageArguments == other.MessageArguments ||
                    MessageArguments != null &&
                    MessageArguments.SequenceEqual(other.MessageArguments)
                ) && 
                (
                    MessageL10n == other.MessageL10n ||
                    MessageL10n != null &&
                    MessageL10n.Equals(other.MessageL10n)
                ) && 
                (
                    TypeL10n == other.TypeL10n ||
                    TypeL10n != null &&
                    TypeL10n.Equals(other.TypeL10n)
                ) && 
                (
                    ResourceTypeL10n == other.ResourceTypeL10n ||
                    ResourceTypeL10n != null &&
                    ResourceTypeL10n.Equals(other.ResourceTypeL10n)
                ) && 
                (
                    ResourceActionL10n == other.ResourceActionL10n ||
                    ResourceActionL10n != null &&
                    ResourceActionL10n.Equals(other.ResourceActionL10n)
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
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                    if (IsSuccessful != null)
                    hashCode = hashCode * 59 + IsSuccessful.GetHashCode();
                    if (ClientAddress != null)
                    hashCode = hashCode * 59 + ClientAddress.GetHashCode();
                    if (ServerAddress != null)
                    hashCode = hashCode * 59 + ServerAddress.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (JobId != null)
                    hashCode = hashCode * 59 + JobId.GetHashCode();
                    if (ResourceType != null)
                    hashCode = hashCode * 59 + ResourceType.GetHashCode();
                    if (ResourceAction != null)
                    hashCode = hashCode * 59 + ResourceAction.GetHashCode();
                    if (MessageCode != null)
                    hashCode = hashCode * 59 + MessageCode.GetHashCode();
                    if (MessageArguments != null)
                    hashCode = hashCode * 59 + MessageArguments.GetHashCode();
                    if (MessageL10n != null)
                    hashCode = hashCode * 59 + MessageL10n.GetHashCode();
                    if (TypeL10n != null)
                    hashCode = hashCode * 59 + TypeL10n.GetHashCode();
                    if (ResourceTypeL10n != null)
                    hashCode = hashCode * 59 + ResourceTypeL10n.GetHashCode();
                    if (ResourceActionL10n != null)
                    hashCode = hashCode * 59 + ResourceActionL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AuditEventInstance left, AuditEventInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AuditEventInstance left, AuditEventInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
