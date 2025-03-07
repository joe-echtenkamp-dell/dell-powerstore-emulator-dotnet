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
    /// This resource type has queriable associations from import_unity, import_unity_consistency_group
    /// </summary>
    [DataContract]
    public partial class ImportUnityVolumeInstance : IEquatable<ImportUnityVolumeInstance>
    { 
        /// <summary>
        /// Unique identifier of the Unity volume.
        /// </summary>
        /// <value>Unique identifier of the Unity volume.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// World Wide Name (WWN) of the Unity volume.
        /// </summary>
        /// <value>World Wide Name (WWN) of the Unity volume.</value>

        [DataMember(Name="wwn")]
        public string Wwn { get; set; }

        /// <summary>
        /// Name of the Unity volume.  This property supports case-insensitive filtering.
        /// </summary>
        /// <value>Name of the Unity volume.  This property supports case-insensitive filtering.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Size of the Unity volume, in bytes.
        /// </summary>
        /// <value>Size of the Unity volume, in bytes.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="size")]
        public long? Size { get; set; }

        /// <summary>
        /// Unique identifier of the Unity storage system to which the Unity volume belongs. 
        /// </summary>
        /// <value>Unique identifier of the Unity storage system to which the Unity volume belongs. </value>

        [DataMember(Name="import_unity_id")]
        public string ImportUnityId { get; set; }

        /// <summary>
        /// Unique identifier of the consistency group to which the Unity volume belongs. This value is null if the volume does not belong to a consistency group. 
        /// </summary>
        /// <value>Unique identifier of the consistency group to which the Unity volume belongs. This value is null if the volume does not belong to a consistency group. </value>

        [DataMember(Name="import_unity_consistency_group_id")]
        public string ImportUnityConsistencyGroupId { get; set; }

        /// <summary>
        /// Gets or Sets Health
        /// </summary>

        [DataMember(Name="health")]
        public UnityHealthEnum? Health { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public UnityVolumeTypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets MigrationState
        /// </summary>

        [DataMember(Name="migration_state")]
        public UnityVolumeMigrationStateEnum? MigrationState { get; set; }

        /// <summary>
        /// Indicates whether the Unity volume is a replication destination.
        /// </summary>
        /// <value>Indicates whether the Unity volume is a replication destination.</value>

        [DataMember(Name="is_replication_destination")]
        public bool? IsReplicationDestination { get; set; }

        /// <summary>
        /// Indicates whether the Unity volume is a thin clone. 
        /// </summary>
        /// <value>Indicates whether the Unity volume is a thin clone. </value>

        [DataMember(Name="is_thin_clone")]
        public bool? IsThinClone { get; set; }

        /// <summary>
        /// Gets or Sets ImportableCriteria
        /// </summary>

        [DataMember(Name="importable_criteria")]
        public VolumeImportableCriteriaEnum? ImportableCriteria { get; set; }

        /// <summary>
        /// List of host volume identifiers that correspond to Unity volumes.
        /// </summary>
        /// <value>List of host volume identifiers that correspond to Unity volumes.</value>

        [DataMember(Name="host_volume_ids")]
        public List<string> HostVolumeIds { get; set; }

        /// <summary>
        /// Localized message string corresponding to health
        /// </summary>
        /// <value>Localized message string corresponding to health</value>

        [DataMember(Name="health_l10n")]
        public string HealthL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to type
        /// </summary>
        /// <value>Localized message string corresponding to type</value>

        [DataMember(Name="type_l10n")]
        public string TypeL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to migration_state
        /// </summary>
        /// <value>Localized message string corresponding to migration_state</value>

        [DataMember(Name="migration_state_l10n")]
        public string MigrationStateL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to importable_criteria
        /// </summary>
        /// <value>Localized message string corresponding to importable_criteria</value>

        [DataMember(Name="importable_criteria_l10n")]
        public string ImportableCriteriaL10n { get; set; }

        /// <summary>
        /// This is the embeddable reference form of import_unity_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of import_unity_id attribute.</value>

        [DataMember(Name="import_unity")]
        public ImportUnityInstance ImportUnity { get; set; }

        /// <summary>
        /// This is the embeddable reference form of import_unity_consistency_group_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of import_unity_consistency_group_id attribute.</value>

        [DataMember(Name="import_unity_consistency_group")]
        public ImportUnityConsistencyGroupInstance ImportUnityConsistencyGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportUnityVolumeInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Wwn: ").Append(Wwn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ImportUnityId: ").Append(ImportUnityId).Append("\n");
            sb.Append("  ImportUnityConsistencyGroupId: ").Append(ImportUnityConsistencyGroupId).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MigrationState: ").Append(MigrationState).Append("\n");
            sb.Append("  IsReplicationDestination: ").Append(IsReplicationDestination).Append("\n");
            sb.Append("  IsThinClone: ").Append(IsThinClone).Append("\n");
            sb.Append("  ImportableCriteria: ").Append(ImportableCriteria).Append("\n");
            sb.Append("  HostVolumeIds: ").Append(HostVolumeIds).Append("\n");
            sb.Append("  HealthL10n: ").Append(HealthL10n).Append("\n");
            sb.Append("  TypeL10n: ").Append(TypeL10n).Append("\n");
            sb.Append("  MigrationStateL10n: ").Append(MigrationStateL10n).Append("\n");
            sb.Append("  ImportableCriteriaL10n: ").Append(ImportableCriteriaL10n).Append("\n");
            sb.Append("  ImportUnity: ").Append(ImportUnity).Append("\n");
            sb.Append("  ImportUnityConsistencyGroup: ").Append(ImportUnityConsistencyGroup).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportUnityVolumeInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportUnityVolumeInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportUnityVolumeInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportUnityVolumeInstance other)
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
                    Wwn == other.Wwn ||
                    Wwn != null &&
                    Wwn.Equals(other.Wwn)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    ImportUnityId == other.ImportUnityId ||
                    ImportUnityId != null &&
                    ImportUnityId.Equals(other.ImportUnityId)
                ) && 
                (
                    ImportUnityConsistencyGroupId == other.ImportUnityConsistencyGroupId ||
                    ImportUnityConsistencyGroupId != null &&
                    ImportUnityConsistencyGroupId.Equals(other.ImportUnityConsistencyGroupId)
                ) && 
                (
                    Health == other.Health ||
                    Health != null &&
                    Health.Equals(other.Health)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    MigrationState == other.MigrationState ||
                    MigrationState != null &&
                    MigrationState.Equals(other.MigrationState)
                ) && 
                (
                    IsReplicationDestination == other.IsReplicationDestination ||
                    IsReplicationDestination != null &&
                    IsReplicationDestination.Equals(other.IsReplicationDestination)
                ) && 
                (
                    IsThinClone == other.IsThinClone ||
                    IsThinClone != null &&
                    IsThinClone.Equals(other.IsThinClone)
                ) && 
                (
                    ImportableCriteria == other.ImportableCriteria ||
                    ImportableCriteria != null &&
                    ImportableCriteria.Equals(other.ImportableCriteria)
                ) && 
                (
                    HostVolumeIds == other.HostVolumeIds ||
                    HostVolumeIds != null &&
                    HostVolumeIds.SequenceEqual(other.HostVolumeIds)
                ) && 
                (
                    HealthL10n == other.HealthL10n ||
                    HealthL10n != null &&
                    HealthL10n.Equals(other.HealthL10n)
                ) && 
                (
                    TypeL10n == other.TypeL10n ||
                    TypeL10n != null &&
                    TypeL10n.Equals(other.TypeL10n)
                ) && 
                (
                    MigrationStateL10n == other.MigrationStateL10n ||
                    MigrationStateL10n != null &&
                    MigrationStateL10n.Equals(other.MigrationStateL10n)
                ) && 
                (
                    ImportableCriteriaL10n == other.ImportableCriteriaL10n ||
                    ImportableCriteriaL10n != null &&
                    ImportableCriteriaL10n.Equals(other.ImportableCriteriaL10n)
                ) && 
                (
                    ImportUnity == other.ImportUnity ||
                    ImportUnity != null &&
                    ImportUnity.Equals(other.ImportUnity)
                ) && 
                (
                    ImportUnityConsistencyGroup == other.ImportUnityConsistencyGroup ||
                    ImportUnityConsistencyGroup != null &&
                    ImportUnityConsistencyGroup.Equals(other.ImportUnityConsistencyGroup)
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
                    if (Wwn != null)
                    hashCode = hashCode * 59 + Wwn.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                    if (ImportUnityId != null)
                    hashCode = hashCode * 59 + ImportUnityId.GetHashCode();
                    if (ImportUnityConsistencyGroupId != null)
                    hashCode = hashCode * 59 + ImportUnityConsistencyGroupId.GetHashCode();
                    if (Health != null)
                    hashCode = hashCode * 59 + Health.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (MigrationState != null)
                    hashCode = hashCode * 59 + MigrationState.GetHashCode();
                    if (IsReplicationDestination != null)
                    hashCode = hashCode * 59 + IsReplicationDestination.GetHashCode();
                    if (IsThinClone != null)
                    hashCode = hashCode * 59 + IsThinClone.GetHashCode();
                    if (ImportableCriteria != null)
                    hashCode = hashCode * 59 + ImportableCriteria.GetHashCode();
                    if (HostVolumeIds != null)
                    hashCode = hashCode * 59 + HostVolumeIds.GetHashCode();
                    if (HealthL10n != null)
                    hashCode = hashCode * 59 + HealthL10n.GetHashCode();
                    if (TypeL10n != null)
                    hashCode = hashCode * 59 + TypeL10n.GetHashCode();
                    if (MigrationStateL10n != null)
                    hashCode = hashCode * 59 + MigrationStateL10n.GetHashCode();
                    if (ImportableCriteriaL10n != null)
                    hashCode = hashCode * 59 + ImportableCriteriaL10n.GetHashCode();
                    if (ImportUnity != null)
                    hashCode = hashCode * 59 + ImportUnity.GetHashCode();
                    if (ImportUnityConsistencyGroup != null)
                    hashCode = hashCode * 59 + ImportUnityConsistencyGroup.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportUnityVolumeInstance left, ImportUnityVolumeInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportUnityVolumeInstance left, ImportUnityVolumeInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
