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
    /// Snapshot profile.
    /// </summary>
    [DataContract]
    public partial class ImportStorageCenterSnapshotProfileInstance : IEquatable<ImportStorageCenterSnapshotProfileInstance>
    { 
        /// <summary>
        /// Unique identifier of the snapshot profile.
        /// </summary>
        /// <value>Unique identifier of the snapshot profile.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the snapshot profile.
        /// </summary>
        /// <value>Name of the snapshot profile.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Type of the snapshot profile.
        /// </summary>
        /// <value>Type of the snapshot profile.</value>

        [DataMember(Name="type")]
        public ScSnapshotProfileTypeEnum? Type { get; set; }

        /// <summary>
        /// Description of the snapshot profile.
        /// </summary>
        /// <value>Description of the snapshot profile.</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>

        [DataMember(Name="rules")]
        public List<ScProfileRuleInstance> Rules { get; set; }

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
            sb.Append("class ImportStorageCenterSnapshotProfileInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportStorageCenterSnapshotProfileInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportStorageCenterSnapshotProfileInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportStorageCenterSnapshotProfileInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportStorageCenterSnapshotProfileInstance other)
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
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Rules == other.Rules ||
                    Rules != null &&
                    Rules.SequenceEqual(other.Rules)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Rules != null)
                    hashCode = hashCode * 59 + Rules.GetHashCode();
                    if (TypeL10n != null)
                    hashCode = hashCode * 59 + TypeL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportStorageCenterSnapshotProfileInstance left, ImportStorageCenterSnapshotProfileInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportStorageCenterSnapshotProfileInstance left, ImportStorageCenterSnapshotProfileInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
