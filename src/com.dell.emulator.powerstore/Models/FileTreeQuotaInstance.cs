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
    /// Properties of a file tree quota. Values was added in 2.0.0.0: grace_period. This resource type has queriable associations from file_system, file_user_quota
    /// </summary>
    [DataContract]
    public partial class FileTreeQuotaInstance : IEquatable<FileTreeQuotaInstance>
    { 
        /// <summary>
        /// Unique identifier of the tree quota.
        /// </summary>
        /// <value>Unique identifier of the tree quota.</value>

        [DataMember(Name="id")]
        public string Id { get; private set; }

        /// <summary>
        /// Unique identifier of the associated file system.
        /// </summary>
        /// <value>Unique identifier of the associated file system.</value>

        [DataMember(Name="file_system_id")]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Path relative to the root of the associated filesystem.
        /// </summary>
        /// <value>Path relative to the root of the associated filesystem.</value>

        [StringLength(1024, MinimumLength=1)]
        [DataMember(Name="path")]
        public string Path { get; set; }

        /// <summary>
        /// Description of the tree quota.
        /// </summary>
        /// <value>Description of the tree quota.</value>

        [StringLength(256, MinimumLength=0)]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether user quota are enabled on this tree quota. The tree quota itself is enforced regardless of this parameter. 
        /// </summary>
        /// <value>Whether user quota are enabled on this tree quota. The tree quota itself is enforced regardless of this parameter. </value>

        [DataMember(Name="is_user_quotas_enforced")]
        public bool? IsUserQuotasEnforced { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>

        [DataMember(Name="state")]
        public FileQuotaStateEnum? State { get; set; }

        /// <summary>
        /// Hard limit of the tree quota, in bytes. No hard limit when set to 0. This value can be used to compute amount of space that is consumed without limiting the space.
        /// </summary>
        /// <value>Hard limit of the tree quota, in bytes. No hard limit when set to 0. This value can be used to compute amount of space that is consumed without limiting the space.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="hard_limit")]
        public long? HardLimit { get; set; }

        /// <summary>
        /// Soft limit of the tree quota, in bytes. No hard limit when set to 0.
        /// </summary>
        /// <value>Soft limit of the tree quota, in bytes. No hard limit when set to 0.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="soft_limit")]
        public long? SoftLimit { get; set; }

        /// <summary>
        /// Remaining grace period, in seconds, after the soft limit is exceeded: * 0 - Grace period has already expired * -1 - No grace period in-progress, or infinite grace period set The grace period of user quotas is set in the file system quota config. 
        /// </summary>
        /// <value>Remaining grace period, in seconds, after the soft limit is exceeded: * 0 - Grace period has already expired * -1 - No grace period in-progress, or infinite grace period set The grace period of user quotas is set in the file system quota config. </value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="remaining_grace_period")]
        public long? RemainingGracePeriod { get; set; }

        /// <summary>
        /// Size already used on the tree quota, in bytes.
        /// </summary>
        /// <value>Size already used on the tree quota, in bytes.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="size_used")]
        public long? SizeUsed { get; set; }

        /// <summary>
        /// Grace period of soft limit (seconds). This will override the default grace period set at filesystem level.  * -1: Infinite grace period (Windows policy).  *  0: Use default grace period of 1 week (default).  * Positive: Grace period after which the soft limit is treated as a hard limit (seconds).  Was added in version 2.0.0.0.
        /// </summary>
        /// <value>Grace period of soft limit (seconds). This will override the default grace period set at filesystem level.  * -1: Infinite grace period (Windows policy).  *  0: Use default grace period of 1 week (default).  * Positive: Grace period after which the soft limit is treated as a hard limit (seconds).  Was added in version 2.0.0.0.</value>

        [Range(-1, 2147483647)]
        [DataMember(Name="grace_period")]
        public int? GracePeriod { get; set; }

        /// <summary>
        /// Localized message string corresponding to state
        /// </summary>
        /// <value>Localized message string corresponding to state</value>

        [DataMember(Name="state_l10n")]
        public string StateL10n { get; set; }

        /// <summary>
        /// This is the embeddable reference form of file_system_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of file_system_id attribute.</value>

        [DataMember(Name="file_system")]
        public FileSystemInstance FileSystem { get; set; }

        /// <summary>
        /// This is the inverse of the resource type file_user_quota association.
        /// </summary>
        /// <value>This is the inverse of the resource type file_user_quota association.</value>

        [DataMember(Name="file_user_tree_quotas")]
        public List<FileUserQuotaInstance> FileUserTreeQuotas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileTreeQuotaInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FileSystemId: ").Append(FileSystemId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsUserQuotasEnforced: ").Append(IsUserQuotasEnforced).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  HardLimit: ").Append(HardLimit).Append("\n");
            sb.Append("  SoftLimit: ").Append(SoftLimit).Append("\n");
            sb.Append("  RemainingGracePeriod: ").Append(RemainingGracePeriod).Append("\n");
            sb.Append("  SizeUsed: ").Append(SizeUsed).Append("\n");
            sb.Append("  GracePeriod: ").Append(GracePeriod).Append("\n");
            sb.Append("  StateL10n: ").Append(StateL10n).Append("\n");
            sb.Append("  FileSystem: ").Append(FileSystem).Append("\n");
            sb.Append("  FileUserTreeQuotas: ").Append(FileUserTreeQuotas).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FileTreeQuotaInstance)obj);
        }

        /// <summary>
        /// Returns true if FileTreeQuotaInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of FileTreeQuotaInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileTreeQuotaInstance other)
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
                    FileSystemId == other.FileSystemId ||
                    FileSystemId != null &&
                    FileSystemId.Equals(other.FileSystemId)
                ) && 
                (
                    Path == other.Path ||
                    Path != null &&
                    Path.Equals(other.Path)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IsUserQuotasEnforced == other.IsUserQuotasEnforced ||
                    IsUserQuotasEnforced != null &&
                    IsUserQuotasEnforced.Equals(other.IsUserQuotasEnforced)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    HardLimit == other.HardLimit ||
                    HardLimit != null &&
                    HardLimit.Equals(other.HardLimit)
                ) && 
                (
                    SoftLimit == other.SoftLimit ||
                    SoftLimit != null &&
                    SoftLimit.Equals(other.SoftLimit)
                ) && 
                (
                    RemainingGracePeriod == other.RemainingGracePeriod ||
                    RemainingGracePeriod != null &&
                    RemainingGracePeriod.Equals(other.RemainingGracePeriod)
                ) && 
                (
                    SizeUsed == other.SizeUsed ||
                    SizeUsed != null &&
                    SizeUsed.Equals(other.SizeUsed)
                ) && 
                (
                    GracePeriod == other.GracePeriod ||
                    GracePeriod != null &&
                    GracePeriod.Equals(other.GracePeriod)
                ) && 
                (
                    StateL10n == other.StateL10n ||
                    StateL10n != null &&
                    StateL10n.Equals(other.StateL10n)
                ) && 
                (
                    FileSystem == other.FileSystem ||
                    FileSystem != null &&
                    FileSystem.Equals(other.FileSystem)
                ) && 
                (
                    FileUserTreeQuotas == other.FileUserTreeQuotas ||
                    FileUserTreeQuotas != null &&
                    FileUserTreeQuotas.SequenceEqual(other.FileUserTreeQuotas)
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
                    if (FileSystemId != null)
                    hashCode = hashCode * 59 + FileSystemId.GetHashCode();
                    if (Path != null)
                    hashCode = hashCode * 59 + Path.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (IsUserQuotasEnforced != null)
                    hashCode = hashCode * 59 + IsUserQuotasEnforced.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (HardLimit != null)
                    hashCode = hashCode * 59 + HardLimit.GetHashCode();
                    if (SoftLimit != null)
                    hashCode = hashCode * 59 + SoftLimit.GetHashCode();
                    if (RemainingGracePeriod != null)
                    hashCode = hashCode * 59 + RemainingGracePeriod.GetHashCode();
                    if (SizeUsed != null)
                    hashCode = hashCode * 59 + SizeUsed.GetHashCode();
                    if (GracePeriod != null)
                    hashCode = hashCode * 59 + GracePeriod.GetHashCode();
                    if (StateL10n != null)
                    hashCode = hashCode * 59 + StateL10n.GetHashCode();
                    if (FileSystem != null)
                    hashCode = hashCode * 59 + FileSystem.GetHashCode();
                    if (FileUserTreeQuotas != null)
                    hashCode = hashCode * 59 + FileUserTreeQuotas.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FileTreeQuotaInstance left, FileTreeQuotaInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FileTreeQuotaInstance left, FileTreeQuotaInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
