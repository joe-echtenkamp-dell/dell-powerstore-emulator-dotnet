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
    /// Details about an import host volume.
    /// </summary>
    [DataContract]
    public partial class ImportHostVolumeInstance : IEquatable<ImportHostVolumeInstance>
    { 
        /// <summary>
        /// Unique identifier of the import host volume.
        /// </summary>
        /// <value>Unique identifier of the import host volume.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier of the import host system.
        /// </summary>
        /// <value>Unique identifier of the import host system.</value>

        [DataMember(Name="host_system_id")]
        public string HostSystemId { get; set; }

        /// <summary>
        /// Name of the import host volume.  This property supports case-insensitive filtering.
        /// </summary>
        /// <value>Name of the import host volume.  This property supports case-insensitive filtering.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Product type of the storage system.
        /// </summary>
        /// <value>Product type of the storage system.</value>

        [DataMember(Name="array_type")]
        public ArrayTypeEnum? ArrayType { get; set; }

        /// <summary>
        /// Unique identifier of the storage system.
        /// </summary>
        /// <value>Unique identifier of the storage system.</value>

        [DataMember(Name="array_identifier")]
        public string ArrayIdentifier { get; set; }

        /// <summary>
        /// Size of the import host volume, in bytes.
        /// </summary>
        /// <value>Size of the import host volume, in bytes.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="size")]
        public long? Size { get; set; }

        /// <summary>
        /// Status of the import host volume.
        /// </summary>
        /// <value>Status of the import host volume.</value>

        [DataMember(Name="status")]
        public VolumeStatusEnum? Status { get; set; }

        /// <summary>
        /// Indicates whether the import host volume is migrating.
        /// </summary>
        /// <value>Indicates whether the import host volume is migrating.</value>

        [DataMember(Name="is_migrating")]
        public bool? IsMigrating { get; set; }

        /// <summary>
        /// Active path of the host volume.
        /// </summary>
        /// <value>Active path of the host volume.</value>

        [DataMember(Name="active_path")]
        public ActivePathEnum? ActivePath { get; set; }

        /// <summary>
        /// Supported protocols for the import host volume.
        /// </summary>
        /// <value>Supported protocols for the import host volume.</value>

        [DataMember(Name="protocols")]
        public List<HostInitiatorProtocolTypeEnum> Protocols { get; set; }

        /// <summary>
        /// Mount paths on the import host system.
        /// </summary>
        /// <value>Mount paths on the import host system.</value>

        [DataMember(Name="mount_paths")]
        public List<string> MountPaths { get; set; }

        /// <summary>
        /// Gets or Sets ImportState
        /// </summary>

        [DataMember(Name="import_state")]
        public ImportOperationStatusEnum? ImportState { get; set; }

        /// <summary>
        /// Unique identifier of a volume that is presented to the import host.
        /// </summary>
        /// <value>Unique identifier of a volume that is presented to the import host.</value>

        [DataMember(Name="naa_id")]
        public string NaaId { get; set; }

        /// <summary>
        /// Time when the import host volume was last updated.
        /// </summary>
        /// <value>Time when the import host volume was last updated.</value>

        [DataMember(Name="last_update_time")]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Localized message string corresponding to array_type
        /// </summary>
        /// <value>Localized message string corresponding to array_type</value>

        [DataMember(Name="array_type_l10n")]
        public string ArrayTypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to status
        /// </summary>
        /// <value>Localized message string corresponding to status</value>

        [DataMember(Name="status_l10n")]
        public string StatusL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to active_path
        /// </summary>
        /// <value>Localized message string corresponding to active_path</value>

        [DataMember(Name="active_path_l10n")]
        public string ActivePathL10n { get; set; }

        /// <summary>
        /// Localized message array corresponding to protocols
        /// </summary>
        /// <value>Localized message array corresponding to protocols</value>

        [DataMember(Name="protocols_l10n")]
        public List<string> ProtocolsL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to import_state
        /// </summary>
        /// <value>Localized message string corresponding to import_state</value>

        [DataMember(Name="import_state_l10n")]
        public string ImportStateL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportHostVolumeInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HostSystemId: ").Append(HostSystemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ArrayType: ").Append(ArrayType).Append("\n");
            sb.Append("  ArrayIdentifier: ").Append(ArrayIdentifier).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsMigrating: ").Append(IsMigrating).Append("\n");
            sb.Append("  ActivePath: ").Append(ActivePath).Append("\n");
            sb.Append("  Protocols: ").Append(Protocols).Append("\n");
            sb.Append("  MountPaths: ").Append(MountPaths).Append("\n");
            sb.Append("  ImportState: ").Append(ImportState).Append("\n");
            sb.Append("  NaaId: ").Append(NaaId).Append("\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  ArrayTypeL10n: ").Append(ArrayTypeL10n).Append("\n");
            sb.Append("  StatusL10n: ").Append(StatusL10n).Append("\n");
            sb.Append("  ActivePathL10n: ").Append(ActivePathL10n).Append("\n");
            sb.Append("  ProtocolsL10n: ").Append(ProtocolsL10n).Append("\n");
            sb.Append("  ImportStateL10n: ").Append(ImportStateL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportHostVolumeInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportHostVolumeInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportHostVolumeInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportHostVolumeInstance other)
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
                    HostSystemId == other.HostSystemId ||
                    HostSystemId != null &&
                    HostSystemId.Equals(other.HostSystemId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ArrayType == other.ArrayType ||
                    ArrayType != null &&
                    ArrayType.Equals(other.ArrayType)
                ) && 
                (
                    ArrayIdentifier == other.ArrayIdentifier ||
                    ArrayIdentifier != null &&
                    ArrayIdentifier.Equals(other.ArrayIdentifier)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    IsMigrating == other.IsMigrating ||
                    IsMigrating != null &&
                    IsMigrating.Equals(other.IsMigrating)
                ) && 
                (
                    ActivePath == other.ActivePath ||
                    ActivePath != null &&
                    ActivePath.Equals(other.ActivePath)
                ) && 
                (
                    Protocols == other.Protocols ||
                    Protocols != null &&
                    Protocols.SequenceEqual(other.Protocols)
                ) && 
                (
                    MountPaths == other.MountPaths ||
                    MountPaths != null &&
                    MountPaths.SequenceEqual(other.MountPaths)
                ) && 
                (
                    ImportState == other.ImportState ||
                    ImportState != null &&
                    ImportState.Equals(other.ImportState)
                ) && 
                (
                    NaaId == other.NaaId ||
                    NaaId != null &&
                    NaaId.Equals(other.NaaId)
                ) && 
                (
                    LastUpdateTime == other.LastUpdateTime ||
                    LastUpdateTime != null &&
                    LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    ArrayTypeL10n == other.ArrayTypeL10n ||
                    ArrayTypeL10n != null &&
                    ArrayTypeL10n.Equals(other.ArrayTypeL10n)
                ) && 
                (
                    StatusL10n == other.StatusL10n ||
                    StatusL10n != null &&
                    StatusL10n.Equals(other.StatusL10n)
                ) && 
                (
                    ActivePathL10n == other.ActivePathL10n ||
                    ActivePathL10n != null &&
                    ActivePathL10n.Equals(other.ActivePathL10n)
                ) && 
                (
                    ProtocolsL10n == other.ProtocolsL10n ||
                    ProtocolsL10n != null &&
                    ProtocolsL10n.SequenceEqual(other.ProtocolsL10n)
                ) && 
                (
                    ImportStateL10n == other.ImportStateL10n ||
                    ImportStateL10n != null &&
                    ImportStateL10n.Equals(other.ImportStateL10n)
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
                    if (HostSystemId != null)
                    hashCode = hashCode * 59 + HostSystemId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ArrayType != null)
                    hashCode = hashCode * 59 + ArrayType.GetHashCode();
                    if (ArrayIdentifier != null)
                    hashCode = hashCode * 59 + ArrayIdentifier.GetHashCode();
                    if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (IsMigrating != null)
                    hashCode = hashCode * 59 + IsMigrating.GetHashCode();
                    if (ActivePath != null)
                    hashCode = hashCode * 59 + ActivePath.GetHashCode();
                    if (Protocols != null)
                    hashCode = hashCode * 59 + Protocols.GetHashCode();
                    if (MountPaths != null)
                    hashCode = hashCode * 59 + MountPaths.GetHashCode();
                    if (ImportState != null)
                    hashCode = hashCode * 59 + ImportState.GetHashCode();
                    if (NaaId != null)
                    hashCode = hashCode * 59 + NaaId.GetHashCode();
                    if (LastUpdateTime != null)
                    hashCode = hashCode * 59 + LastUpdateTime.GetHashCode();
                    if (ArrayTypeL10n != null)
                    hashCode = hashCode * 59 + ArrayTypeL10n.GetHashCode();
                    if (StatusL10n != null)
                    hashCode = hashCode * 59 + StatusL10n.GetHashCode();
                    if (ActivePathL10n != null)
                    hashCode = hashCode * 59 + ActivePathL10n.GetHashCode();
                    if (ProtocolsL10n != null)
                    hashCode = hashCode * 59 + ProtocolsL10n.GetHashCode();
                    if (ImportStateL10n != null)
                    hashCode = hashCode * 59 + ImportStateL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportHostVolumeInstance left, ImportHostVolumeInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportHostVolumeInstance left, ImportHostVolumeInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
