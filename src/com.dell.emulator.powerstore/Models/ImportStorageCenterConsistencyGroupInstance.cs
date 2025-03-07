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
    /// This resource type has queriable associations from import_storage_center, import_storage_center_volume
    /// </summary>
    [DataContract]
    public partial class ImportStorageCenterConsistencyGroupInstance : IEquatable<ImportStorageCenterConsistencyGroupInstance>
    { 
        /// <summary>
        /// Unique identifier of the SC consistency group.
        /// </summary>
        /// <value>Unique identifier of the SC consistency group.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the SC consistency group.  This property supports case-insensitive filtering.
        /// </summary>
        /// <value>Name of the SC consistency group.  This property supports case-insensitive filtering.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier of the SC array.
        /// </summary>
        /// <value>Unique identifier of the SC array.</value>

        [DataMember(Name="import_storage_center_id")]
        public string ImportStorageCenterId { get; set; }

        /// <summary>
        /// Volume import criteria. If the value is not Ready, the volume is not importable. 
        /// </summary>
        /// <value>Volume import criteria. If the value is not Ready, the volume is not importable. </value>

        [DataMember(Name="importable_criteria")]
        public CGImportableCriteriaEnum? ImportableCriteria { get; set; }

        /// <summary>
        /// Localized message string corresponding to importable_criteria
        /// </summary>
        /// <value>Localized message string corresponding to importable_criteria</value>

        [DataMember(Name="importable_criteria_l10n")]
        public string ImportableCriteriaL10n { get; set; }

        /// <summary>
        /// This is the inverse of the resource type import_storage_center_volume association.
        /// </summary>
        /// <value>This is the inverse of the resource type import_storage_center_volume association.</value>

        [DataMember(Name="import_storage_center_volumes")]
        public List<ImportStorageCenterVolumeInstance> ImportStorageCenterVolumes { get; set; }

        /// <summary>
        /// This is the embeddable reference form of import_storage_center_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of import_storage_center_id attribute.</value>

        [DataMember(Name="import_storage_center")]
        public ImportStorageCenterInstance ImportStorageCenter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportStorageCenterConsistencyGroupInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImportStorageCenterId: ").Append(ImportStorageCenterId).Append("\n");
            sb.Append("  ImportableCriteria: ").Append(ImportableCriteria).Append("\n");
            sb.Append("  ImportableCriteriaL10n: ").Append(ImportableCriteriaL10n).Append("\n");
            sb.Append("  ImportStorageCenterVolumes: ").Append(ImportStorageCenterVolumes).Append("\n");
            sb.Append("  ImportStorageCenter: ").Append(ImportStorageCenter).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportStorageCenterConsistencyGroupInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportStorageCenterConsistencyGroupInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportStorageCenterConsistencyGroupInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportStorageCenterConsistencyGroupInstance other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ImportStorageCenterId == other.ImportStorageCenterId ||
                    ImportStorageCenterId != null &&
                    ImportStorageCenterId.Equals(other.ImportStorageCenterId)
                ) && 
                (
                    ImportableCriteria == other.ImportableCriteria ||
                    ImportableCriteria != null &&
                    ImportableCriteria.Equals(other.ImportableCriteria)
                ) && 
                (
                    ImportableCriteriaL10n == other.ImportableCriteriaL10n ||
                    ImportableCriteriaL10n != null &&
                    ImportableCriteriaL10n.Equals(other.ImportableCriteriaL10n)
                ) && 
                (
                    ImportStorageCenterVolumes == other.ImportStorageCenterVolumes ||
                    ImportStorageCenterVolumes != null &&
                    ImportStorageCenterVolumes.SequenceEqual(other.ImportStorageCenterVolumes)
                ) && 
                (
                    ImportStorageCenter == other.ImportStorageCenter ||
                    ImportStorageCenter != null &&
                    ImportStorageCenter.Equals(other.ImportStorageCenter)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ImportStorageCenterId != null)
                    hashCode = hashCode * 59 + ImportStorageCenterId.GetHashCode();
                    if (ImportableCriteria != null)
                    hashCode = hashCode * 59 + ImportableCriteria.GetHashCode();
                    if (ImportableCriteriaL10n != null)
                    hashCode = hashCode * 59 + ImportableCriteriaL10n.GetHashCode();
                    if (ImportStorageCenterVolumes != null)
                    hashCode = hashCode * 59 + ImportStorageCenterVolumes.GetHashCode();
                    if (ImportStorageCenter != null)
                    hashCode = hashCode * 59 + ImportStorageCenter.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportStorageCenterConsistencyGroupInstance left, ImportStorageCenterConsistencyGroupInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportStorageCenterConsistencyGroupInstance left, ImportStorageCenterConsistencyGroupInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
