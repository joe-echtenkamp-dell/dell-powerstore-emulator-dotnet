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
    /// An instance of a NetApp volume. Was added in version 3.0.0.0. This resource type has queriable association from import_netapp
    /// </summary>
    [DataContract]
    public partial class ImportNetappVolumeInstance : IEquatable<ImportNetappVolumeInstance>
    { 
        /// <summary>
        /// Unique identifier of the NetApp volume.
        /// </summary>
        /// <value>Unique identifier of the NetApp volume.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// World Wide Name (WWN) of the NetApp volume.
        /// </summary>
        /// <value>World Wide Name (WWN) of the NetApp volume.</value>

        [DataMember(Name="wwn")]
        public string Wwn { get; set; }

        /// <summary>
        /// Name of the NetApp volume.  This property supports case-insensitive filtering.
        /// </summary>
        /// <value>Name of the NetApp volume.  This property supports case-insensitive filtering.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Size of the NetApp volume, in bytes.
        /// </summary>
        /// <value>Size of the NetApp volume, in bytes.</value>

        [Range(0, -9223372036854775616)]
        [DataMember(Name="size")]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>

        [DataMember(Name="state")]
        public NetAppVolumeStateEnum? State { get; set; }

        /// <summary>
        /// Gets or Sets ContainerState
        /// </summary>

        [DataMember(Name="container_state")]
        public NetAppContainerStateEnum? ContainerState { get; set; }

        /// <summary>
        /// Indicates whether the NetApp volume is a read only volume.
        /// </summary>
        /// <value>Indicates whether the NetApp volume is a read only volume.</value>

        [DataMember(Name="is_read_only")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Indicates whether the NetApp volume is a replication destination.
        /// </summary>
        /// <value>Indicates whether the NetApp volume is a replication destination.</value>

        [DataMember(Name="is_replication_destination")]
        public bool? IsReplicationDestination { get; set; }

        /// <summary>
        /// Indicates the reason when the volume is not importable. If the value is not Ready_For_Agentless_Import, the volume is not importable. 
        /// </summary>
        /// <value>Indicates the reason when the volume is not importable. If the value is not Ready_For_Agentless_Import, the volume is not importable. </value>

        [DataMember(Name="importable_criteria")]
        public VolumeImportableCriteriaEnum? ImportableCriteria { get; set; }

        /// <summary>
        /// Unique identifier of the NetApp storage system to which the NetApp volume belongs. 
        /// </summary>
        /// <value>Unique identifier of the NetApp storage system to which the NetApp volume belongs. </value>

        [DataMember(Name="import_netapp_id")]
        public string ImportNetappId { get; set; }

        /// <summary>
        /// Localized message string corresponding to state Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to state Was added in version 3.0.0.0.</value>

        [DataMember(Name="state_l10n")]
        public string StateL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to container_state Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to container_state Was added in version 3.0.0.0.</value>

        [DataMember(Name="container_state_l10n")]
        public string ContainerStateL10n { get; set; }

        /// <summary>
        /// Localized message string corresponding to importable_criteria Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to importable_criteria Was added in version 3.0.0.0.</value>

        [DataMember(Name="importable_criteria_l10n")]
        public string ImportableCriteriaL10n { get; set; }

        /// <summary>
        /// This is the embeddable reference form of import_netapp_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of import_netapp_id attribute.</value>

        [DataMember(Name="import_netapp")]
        public ImportNetappInstance ImportNetapp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportNetappVolumeInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Wwn: ").Append(Wwn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ContainerState: ").Append(ContainerState).Append("\n");
            sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
            sb.Append("  IsReplicationDestination: ").Append(IsReplicationDestination).Append("\n");
            sb.Append("  ImportableCriteria: ").Append(ImportableCriteria).Append("\n");
            sb.Append("  ImportNetappId: ").Append(ImportNetappId).Append("\n");
            sb.Append("  StateL10n: ").Append(StateL10n).Append("\n");
            sb.Append("  ContainerStateL10n: ").Append(ContainerStateL10n).Append("\n");
            sb.Append("  ImportableCriteriaL10n: ").Append(ImportableCriteriaL10n).Append("\n");
            sb.Append("  ImportNetapp: ").Append(ImportNetapp).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportNetappVolumeInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportNetappVolumeInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportNetappVolumeInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportNetappVolumeInstance other)
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
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    ContainerState == other.ContainerState ||
                    ContainerState != null &&
                    ContainerState.Equals(other.ContainerState)
                ) && 
                (
                    IsReadOnly == other.IsReadOnly ||
                    IsReadOnly != null &&
                    IsReadOnly.Equals(other.IsReadOnly)
                ) && 
                (
                    IsReplicationDestination == other.IsReplicationDestination ||
                    IsReplicationDestination != null &&
                    IsReplicationDestination.Equals(other.IsReplicationDestination)
                ) && 
                (
                    ImportableCriteria == other.ImportableCriteria ||
                    ImportableCriteria != null &&
                    ImportableCriteria.Equals(other.ImportableCriteria)
                ) && 
                (
                    ImportNetappId == other.ImportNetappId ||
                    ImportNetappId != null &&
                    ImportNetappId.Equals(other.ImportNetappId)
                ) && 
                (
                    StateL10n == other.StateL10n ||
                    StateL10n != null &&
                    StateL10n.Equals(other.StateL10n)
                ) && 
                (
                    ContainerStateL10n == other.ContainerStateL10n ||
                    ContainerStateL10n != null &&
                    ContainerStateL10n.Equals(other.ContainerStateL10n)
                ) && 
                (
                    ImportableCriteriaL10n == other.ImportableCriteriaL10n ||
                    ImportableCriteriaL10n != null &&
                    ImportableCriteriaL10n.Equals(other.ImportableCriteriaL10n)
                ) && 
                (
                    ImportNetapp == other.ImportNetapp ||
                    ImportNetapp != null &&
                    ImportNetapp.Equals(other.ImportNetapp)
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
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (ContainerState != null)
                    hashCode = hashCode * 59 + ContainerState.GetHashCode();
                    if (IsReadOnly != null)
                    hashCode = hashCode * 59 + IsReadOnly.GetHashCode();
                    if (IsReplicationDestination != null)
                    hashCode = hashCode * 59 + IsReplicationDestination.GetHashCode();
                    if (ImportableCriteria != null)
                    hashCode = hashCode * 59 + ImportableCriteria.GetHashCode();
                    if (ImportNetappId != null)
                    hashCode = hashCode * 59 + ImportNetappId.GetHashCode();
                    if (StateL10n != null)
                    hashCode = hashCode * 59 + StateL10n.GetHashCode();
                    if (ContainerStateL10n != null)
                    hashCode = hashCode * 59 + ContainerStateL10n.GetHashCode();
                    if (ImportableCriteriaL10n != null)
                    hashCode = hashCode * 59 + ImportableCriteriaL10n.GetHashCode();
                    if (ImportNetapp != null)
                    hashCode = hashCode * 59 + ImportNetapp.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportNetappVolumeInstance left, ImportNetappVolumeInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportNetappVolumeInstance left, ImportNetappVolumeInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
