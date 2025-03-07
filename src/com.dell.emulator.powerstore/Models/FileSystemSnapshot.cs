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
    /// Parameters for the file system snapshot operation.
    /// </summary>
    [DataContract]
    public partial class FileSystemSnapshot : IEquatable<FileSystemSnapshot>
    { 
        /// <summary>
        /// Name of the snapshot. The default name of the snapshot is the date and time when the snapshot is taken.
        /// </summary>
        /// <value>Name of the snapshot. The default name of the snapshot is the date and time when the snapshot is taken.</value>

        [StringLength(255, MinimumLength=1)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the snapshot.
        /// </summary>
        /// <value>Description of the snapshot.</value>

        [StringLength(255, MinimumLength=0)]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Time, when the snapshot will expire.
        /// </summary>
        /// <value>Time, when the snapshot will expire.</value>

        [DataMember(Name="expiration_timestamp")]
        public DateTime? ExpirationTimestamp { get; set; }

        /// <summary>
        /// Indicates whether the snapshot can be automatically deleted per threshold settings. Values are: * true - Snapshot can be automatically deleted per threshold settings. * false - Snapshot cannot be automatically deleted. 
        /// </summary>
        /// <value>Indicates whether the snapshot can be automatically deleted per threshold settings. Values are: * true - Snapshot can be automatically deleted per threshold settings. * false - Snapshot cannot be automatically deleted. </value>

        [DataMember(Name="is_auto_delete_enabled")]
        public bool? IsAutoDeleteEnabled { get; set; }

        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>

        [DataMember(Name="access_type")]
        public FileSystemSnapshotAccessTypeEnum? AccessType { get; set; }

        /// <summary>
        /// Gets or Sets AccessPolicy
        /// </summary>

        [DataMember(Name="access_policy")]
        public FileSystemAccessPolicyEnum? AccessPolicy { get; set; }

        /// <summary>
        /// Gets or Sets LockingPolicy
        /// </summary>

        [DataMember(Name="locking_policy")]
        public FileSystemLockingPolicyEnum? LockingPolicy { get; set; }

        /// <summary>
        /// Gets or Sets FolderRenamePolicy
        /// </summary>

        [DataMember(Name="folder_rename_policy")]
        public FileSystemFolderRenamePolicyEnum? FolderRenamePolicy { get; set; }

        /// <summary>
        /// Indicates whether the synchronous writes option is enabled on the file system. Values are: * true - Synchronous writes option is enabled on the file system. * false - Synchronous writes option is disabled on the file system. 
        /// </summary>
        /// <value>Indicates whether the synchronous writes option is enabled on the file system. Values are: * true - Synchronous writes option is enabled on the file system. * false - Synchronous writes option is disabled on the file system. </value>

        [DataMember(Name="is_smb_sync_writes_enabled")]
        public bool? IsSmbSyncWritesEnabled { get; set; }

        /// <summary>
        /// Indicates whether notifications of changes to a directory file structure are enabled. * true - Change directory notifications are disabled. * false - Change directory notifications are enabled. 
        /// </summary>
        /// <value>Indicates whether notifications of changes to a directory file structure are enabled. * true - Change directory notifications are disabled. * false - Change directory notifications are enabled. </value>

        [DataMember(Name="is_smb_no_notify_enabled")]
        public bool? IsSmbNoNotifyEnabled { get; set; }

        /// <summary>
        /// Indicates whether opportunistic file locking is enabled on the file system. Values are: * true - Opportunistic file locking is enabled on the file system. * false - Opportunistic file locking is disabled on the file system. 
        /// </summary>
        /// <value>Indicates whether opportunistic file locking is enabled on the file system. Values are: * true - Opportunistic file locking is enabled on the file system. * false - Opportunistic file locking is disabled on the file system. </value>

        [DataMember(Name="is_smb_op_locks_enabled")]
        public bool? IsSmbOpLocksEnabled { get; set; }

        /// <summary>
        /// Indicates whether file access notifications are enabled on the file system. Values are: * true - File access notifications are enabled on the file system. * false - File access notifications are disabled on the file system. 
        /// </summary>
        /// <value>Indicates whether file access notifications are enabled on the file system. Values are: * true - File access notifications are enabled on the file system. * false - File access notifications are disabled on the file system. </value>

        [DataMember(Name="is_smb_notify_on_access_enabled")]
        public bool? IsSmbNotifyOnAccessEnabled { get; set; }

        /// <summary>
        /// Indicates whether file writes notifications are enabled on the file system. Values are: * true - File writes notifications are enabled on the file system. * false - File writes notifications are disabled on the file system. 
        /// </summary>
        /// <value>Indicates whether file writes notifications are enabled on the file system. Values are: * true - File writes notifications are enabled on the file system. * false - File writes notifications are disabled on the file system. </value>

        [DataMember(Name="is_smb_notify_on_write_enabled")]
        public bool? IsSmbNotifyOnWriteEnabled { get; set; }

        /// <summary>
        /// Lowest directory level to which the enabled notifications apply, if any.
        /// </summary>
        /// <value>Lowest directory level to which the enabled notifications apply, if any.</value>

        [Range(1, 512)]
        [DataMember(Name="smb_notify_on_change_dir_depth")]
        public int? SmbNotifyOnChangeDirDepth { get; set; }

        /// <summary>
        /// Indicates whether asynchronous MTIME is enabled on the protocol snaps that are mounted writeable. Values are: * true - Asynchronous MTIME is enabled on the file system. * false - Asynchronous MTIME is disabled on the file system. 
        /// </summary>
        /// <value>Indicates whether asynchronous MTIME is enabled on the protocol snaps that are mounted writeable. Values are: * true - Asynchronous MTIME is enabled on the file system. * false - Asynchronous MTIME is disabled on the file system. </value>

        [DataMember(Name="is_async_MTime_enabled")]
        public bool? IsAsyncMTimeEnabled { get; set; }

        /// <summary>
        ///  Was added in version 3.0.0.0.
        /// </summary>
        /// <value> Was added in version 3.0.0.0.</value>

        [DataMember(Name="file_events_publishing_mode")]
        public FileEventsPublishingModeEnum? FileEventsPublishingMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileSystemSnapshot {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  IsAutoDeleteEnabled: ").Append(IsAutoDeleteEnabled).Append("\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  AccessPolicy: ").Append(AccessPolicy).Append("\n");
            sb.Append("  LockingPolicy: ").Append(LockingPolicy).Append("\n");
            sb.Append("  FolderRenamePolicy: ").Append(FolderRenamePolicy).Append("\n");
            sb.Append("  IsSmbSyncWritesEnabled: ").Append(IsSmbSyncWritesEnabled).Append("\n");
            sb.Append("  IsSmbNoNotifyEnabled: ").Append(IsSmbNoNotifyEnabled).Append("\n");
            sb.Append("  IsSmbOpLocksEnabled: ").Append(IsSmbOpLocksEnabled).Append("\n");
            sb.Append("  IsSmbNotifyOnAccessEnabled: ").Append(IsSmbNotifyOnAccessEnabled).Append("\n");
            sb.Append("  IsSmbNotifyOnWriteEnabled: ").Append(IsSmbNotifyOnWriteEnabled).Append("\n");
            sb.Append("  SmbNotifyOnChangeDirDepth: ").Append(SmbNotifyOnChangeDirDepth).Append("\n");
            sb.Append("  IsAsyncMTimeEnabled: ").Append(IsAsyncMTimeEnabled).Append("\n");
            sb.Append("  FileEventsPublishingMode: ").Append(FileEventsPublishingMode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FileSystemSnapshot)obj);
        }

        /// <summary>
        /// Returns true if FileSystemSnapshot instances are equal
        /// </summary>
        /// <param name="other">Instance of FileSystemSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSystemSnapshot other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ExpirationTimestamp == other.ExpirationTimestamp ||
                    ExpirationTimestamp != null &&
                    ExpirationTimestamp.Equals(other.ExpirationTimestamp)
                ) && 
                (
                    IsAutoDeleteEnabled == other.IsAutoDeleteEnabled ||
                    IsAutoDeleteEnabled != null &&
                    IsAutoDeleteEnabled.Equals(other.IsAutoDeleteEnabled)
                ) && 
                (
                    AccessType == other.AccessType ||
                    AccessType != null &&
                    AccessType.Equals(other.AccessType)
                ) && 
                (
                    AccessPolicy == other.AccessPolicy ||
                    AccessPolicy != null &&
                    AccessPolicy.Equals(other.AccessPolicy)
                ) && 
                (
                    LockingPolicy == other.LockingPolicy ||
                    LockingPolicy != null &&
                    LockingPolicy.Equals(other.LockingPolicy)
                ) && 
                (
                    FolderRenamePolicy == other.FolderRenamePolicy ||
                    FolderRenamePolicy != null &&
                    FolderRenamePolicy.Equals(other.FolderRenamePolicy)
                ) && 
                (
                    IsSmbSyncWritesEnabled == other.IsSmbSyncWritesEnabled ||
                    IsSmbSyncWritesEnabled != null &&
                    IsSmbSyncWritesEnabled.Equals(other.IsSmbSyncWritesEnabled)
                ) && 
                (
                    IsSmbNoNotifyEnabled == other.IsSmbNoNotifyEnabled ||
                    IsSmbNoNotifyEnabled != null &&
                    IsSmbNoNotifyEnabled.Equals(other.IsSmbNoNotifyEnabled)
                ) && 
                (
                    IsSmbOpLocksEnabled == other.IsSmbOpLocksEnabled ||
                    IsSmbOpLocksEnabled != null &&
                    IsSmbOpLocksEnabled.Equals(other.IsSmbOpLocksEnabled)
                ) && 
                (
                    IsSmbNotifyOnAccessEnabled == other.IsSmbNotifyOnAccessEnabled ||
                    IsSmbNotifyOnAccessEnabled != null &&
                    IsSmbNotifyOnAccessEnabled.Equals(other.IsSmbNotifyOnAccessEnabled)
                ) && 
                (
                    IsSmbNotifyOnWriteEnabled == other.IsSmbNotifyOnWriteEnabled ||
                    IsSmbNotifyOnWriteEnabled != null &&
                    IsSmbNotifyOnWriteEnabled.Equals(other.IsSmbNotifyOnWriteEnabled)
                ) && 
                (
                    SmbNotifyOnChangeDirDepth == other.SmbNotifyOnChangeDirDepth ||
                    SmbNotifyOnChangeDirDepth != null &&
                    SmbNotifyOnChangeDirDepth.Equals(other.SmbNotifyOnChangeDirDepth)
                ) && 
                (
                    IsAsyncMTimeEnabled == other.IsAsyncMTimeEnabled ||
                    IsAsyncMTimeEnabled != null &&
                    IsAsyncMTimeEnabled.Equals(other.IsAsyncMTimeEnabled)
                ) && 
                (
                    FileEventsPublishingMode == other.FileEventsPublishingMode ||
                    FileEventsPublishingMode != null &&
                    FileEventsPublishingMode.Equals(other.FileEventsPublishingMode)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ExpirationTimestamp != null)
                    hashCode = hashCode * 59 + ExpirationTimestamp.GetHashCode();
                    if (IsAutoDeleteEnabled != null)
                    hashCode = hashCode * 59 + IsAutoDeleteEnabled.GetHashCode();
                    if (AccessType != null)
                    hashCode = hashCode * 59 + AccessType.GetHashCode();
                    if (AccessPolicy != null)
                    hashCode = hashCode * 59 + AccessPolicy.GetHashCode();
                    if (LockingPolicy != null)
                    hashCode = hashCode * 59 + LockingPolicy.GetHashCode();
                    if (FolderRenamePolicy != null)
                    hashCode = hashCode * 59 + FolderRenamePolicy.GetHashCode();
                    if (IsSmbSyncWritesEnabled != null)
                    hashCode = hashCode * 59 + IsSmbSyncWritesEnabled.GetHashCode();
                    if (IsSmbNoNotifyEnabled != null)
                    hashCode = hashCode * 59 + IsSmbNoNotifyEnabled.GetHashCode();
                    if (IsSmbOpLocksEnabled != null)
                    hashCode = hashCode * 59 + IsSmbOpLocksEnabled.GetHashCode();
                    if (IsSmbNotifyOnAccessEnabled != null)
                    hashCode = hashCode * 59 + IsSmbNotifyOnAccessEnabled.GetHashCode();
                    if (IsSmbNotifyOnWriteEnabled != null)
                    hashCode = hashCode * 59 + IsSmbNotifyOnWriteEnabled.GetHashCode();
                    if (SmbNotifyOnChangeDirDepth != null)
                    hashCode = hashCode * 59 + SmbNotifyOnChangeDirDepth.GetHashCode();
                    if (IsAsyncMTimeEnabled != null)
                    hashCode = hashCode * 59 + IsAsyncMTimeEnabled.GetHashCode();
                    if (FileEventsPublishingMode != null)
                    hashCode = hashCode * 59 + FileEventsPublishingMode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FileSystemSnapshot left, FileSystemSnapshot right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FileSystemSnapshot left, FileSystemSnapshot right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
