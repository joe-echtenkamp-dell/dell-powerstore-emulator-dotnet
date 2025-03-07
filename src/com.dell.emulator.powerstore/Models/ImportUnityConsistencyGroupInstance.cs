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
    /// This resource type has queriable associations from import_unity, import_unity_volume
    /// </summary>
    [DataContract]
    public partial class ImportUnityConsistencyGroupInstance : IEquatable<ImportUnityConsistencyGroupInstance>
    { 
        /// <summary>
        /// Unique identifier of the Unity consistency group.
        /// </summary>
        /// <value>Unique identifier of the Unity consistency group.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the consistency group.  This property supports case-insensitive filtering.
        /// </summary>
        /// <value>Name of the consistency group.  This property supports case-insensitive filtering.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier of the Unity storage system where the consistency group resides. 
        /// </summary>
        /// <value>Unique identifier of the Unity storage system where the consistency group resides. </value>

        [DataMember(Name="import_unity_id")]
        public string ImportUnityId { get; set; }

        /// <summary>
        /// Consistency group import criteria. 
        /// </summary>
        /// <value>Consistency group import criteria. </value>

        [DataMember(Name="importable_criteria")]
        public CGImportableCriteriaEnum? ImportableCriteria { get; set; }

        /// <summary>
        /// Localized message string corresponding to importable_criteria
        /// </summary>
        /// <value>Localized message string corresponding to importable_criteria</value>

        [DataMember(Name="importable_criteria_l10n")]
        public string ImportableCriteriaL10n { get; set; }

        /// <summary>
        /// This is the inverse of the resource type import_unity_volume association.
        /// </summary>
        /// <value>This is the inverse of the resource type import_unity_volume association.</value>

        [DataMember(Name="import_unity_volumes")]
        public List<ImportUnityVolumeInstance> ImportUnityVolumes { get; set; }

        /// <summary>
        /// This is the embeddable reference form of import_unity_id attribute.
        /// </summary>
        /// <value>This is the embeddable reference form of import_unity_id attribute.</value>

        [DataMember(Name="import_unity")]
        public ImportUnityInstance ImportUnity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportUnityConsistencyGroupInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImportUnityId: ").Append(ImportUnityId).Append("\n");
            sb.Append("  ImportableCriteria: ").Append(ImportableCriteria).Append("\n");
            sb.Append("  ImportableCriteriaL10n: ").Append(ImportableCriteriaL10n).Append("\n");
            sb.Append("  ImportUnityVolumes: ").Append(ImportUnityVolumes).Append("\n");
            sb.Append("  ImportUnity: ").Append(ImportUnity).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportUnityConsistencyGroupInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportUnityConsistencyGroupInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportUnityConsistencyGroupInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportUnityConsistencyGroupInstance other)
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
                    ImportUnityId == other.ImportUnityId ||
                    ImportUnityId != null &&
                    ImportUnityId.Equals(other.ImportUnityId)
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
                    ImportUnityVolumes == other.ImportUnityVolumes ||
                    ImportUnityVolumes != null &&
                    ImportUnityVolumes.SequenceEqual(other.ImportUnityVolumes)
                ) && 
                (
                    ImportUnity == other.ImportUnity ||
                    ImportUnity != null &&
                    ImportUnity.Equals(other.ImportUnity)
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
                    if (ImportUnityId != null)
                    hashCode = hashCode * 59 + ImportUnityId.GetHashCode();
                    if (ImportableCriteria != null)
                    hashCode = hashCode * 59 + ImportableCriteria.GetHashCode();
                    if (ImportableCriteriaL10n != null)
                    hashCode = hashCode * 59 + ImportableCriteriaL10n.GetHashCode();
                    if (ImportUnityVolumes != null)
                    hashCode = hashCode * 59 + ImportUnityVolumes.GetHashCode();
                    if (ImportUnity != null)
                    hashCode = hashCode * 59 + ImportUnity.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportUnityConsistencyGroupInstance left, ImportUnityConsistencyGroupInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportUnityConsistencyGroupInstance left, ImportUnityConsistencyGroupInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
