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
    /// An instance of an VMAX storage system. Was added in version 3.0.0.0. This resource type has queriable associations from import_vmax_volume, import_vmax_storage_group
    /// </summary>
    [DataContract]
    public partial class ImportVmaxInstance : IEquatable<ImportVmaxInstance>
    { 
        /// <summary>
        /// Unique identifier of the import_vmax resource instance, and of the corresponding remote_system instance. 
        /// </summary>
        /// <value>Unique identifier of the import_vmax resource instance, and of the corresponding remote_system instance. </value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier of the VMAX storage system that is a storage system for import. 
        /// </summary>
        /// <value>Unique identifier of the VMAX storage system that is a storage system for import. </value>

        [DataMember(Name="symmetrix_id")]
        public string SymmetrixId { get; set; }

        /// <summary>
        /// Management address to use for communicating with the VMAX storage system. The address can be an IPv4 address, IPv6 address, or FQDN (Fully Qualified Domain Name). 
        /// </summary>
        /// <value>Management address to use for communicating with the VMAX storage system. The address can be an IPv4 address, IPv6 address, or FQDN (Fully Qualified Domain Name). </value>

        [DataMember(Name="management_address")]
        public string ManagementAddress { get; set; }

        /// <summary>
        /// Model represent the model of VMAX storage system.
        /// </summary>
        /// <value>Model represent the model of VMAX storage system.</value>

        [DataMember(Name="model")]
        public string Model { get; set; }

        /// <summary>
        /// Version of the Unisphere that manages the VMAX storage system.
        /// </summary>
        /// <value>Version of the Unisphere that manages the VMAX storage system.</value>

        [DataMember(Name="unisphere_api_version")]
        public string UnisphereApiVersion { get; set; }

        /// <summary>
        /// The Unisphere is running as embedded or standalone.
        /// </summary>
        /// <value>The Unisphere is running as embedded or standalone.</value>

        [DataMember(Name="is_embedded")]
        public bool? IsEmbedded { get; set; }

        /// <summary>
        /// Ucode version will be present in this format 5977.1131.1131 for the VMAX storage system. 
        /// </summary>
        /// <value>Ucode version will be present in this format 5977.1131.1131 for the VMAX storage system. </value>

        [DataMember(Name="ucode_version")]
        public string UcodeVersion { get; set; }

        /// <summary>
        /// Gets or Sets SupportedImportType
        /// </summary>

        [DataMember(Name="supported_import_type")]
        public SupportedImportTypeEnum? SupportedImportType { get; set; }

        /// <summary>
        /// User account name used to communicate with the VMAX storage system.
        /// </summary>
        /// <value>User account name used to communicate with the VMAX storage system.</value>

        [DataMember(Name="user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Date and time when the VMAX storage system details were last updated. These details include the VMAX storage system and information about its importable storage groups. The timestamp is updated when the VMAX storage system is created and whenever the importable storage groups is discovered. 
        /// </summary>
        /// <value>Date and time when the VMAX storage system details were last updated. These details include the VMAX storage system and information about its importable storage groups. The timestamp is updated when the VMAX storage system is created and whenever the importable storage groups is discovered. </value>

        [DataMember(Name="last_updated_timestamp")]
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Management port of PowerMax/VMAX remote system. 
        /// </summary>
        /// <value>Management port of PowerMax/VMAX remote system. </value>

        [Range(0, 2147483647)]
        [DataMember(Name="port")]
        public int? Port { get; set; }

        /// <summary>
        /// Localized message string corresponding to supported_import_type Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to supported_import_type Was added in version 3.0.0.0.</value>

        [DataMember(Name="supported_import_type_l10n")]
        public string SupportedImportTypeL10n { get; set; }

        /// <summary>
        /// This is the inverse of the resource type import_vmax_volume association.
        /// </summary>
        /// <value>This is the inverse of the resource type import_vmax_volume association.</value>

        [DataMember(Name="import_vmax_volumes")]
        public List<ImportVmaxVolumeInstance> ImportVmaxVolumes { get; set; }

        /// <summary>
        /// This is the inverse of the resource type import_vmax_storage_group association.
        /// </summary>
        /// <value>This is the inverse of the resource type import_vmax_storage_group association.</value>

        [DataMember(Name="import_vmax_storage_group")]
        public List<ImportVmaxStorageGroupInstance> ImportVmaxStorageGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportVmaxInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SymmetrixId: ").Append(SymmetrixId).Append("\n");
            sb.Append("  ManagementAddress: ").Append(ManagementAddress).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  UnisphereApiVersion: ").Append(UnisphereApiVersion).Append("\n");
            sb.Append("  IsEmbedded: ").Append(IsEmbedded).Append("\n");
            sb.Append("  UcodeVersion: ").Append(UcodeVersion).Append("\n");
            sb.Append("  SupportedImportType: ").Append(SupportedImportType).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  LastUpdatedTimestamp: ").Append(LastUpdatedTimestamp).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SupportedImportTypeL10n: ").Append(SupportedImportTypeL10n).Append("\n");
            sb.Append("  ImportVmaxVolumes: ").Append(ImportVmaxVolumes).Append("\n");
            sb.Append("  ImportVmaxStorageGroup: ").Append(ImportVmaxStorageGroup).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportVmaxInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportVmaxInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportVmaxInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportVmaxInstance other)
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
                    SymmetrixId == other.SymmetrixId ||
                    SymmetrixId != null &&
                    SymmetrixId.Equals(other.SymmetrixId)
                ) && 
                (
                    ManagementAddress == other.ManagementAddress ||
                    ManagementAddress != null &&
                    ManagementAddress.Equals(other.ManagementAddress)
                ) && 
                (
                    Model == other.Model ||
                    Model != null &&
                    Model.Equals(other.Model)
                ) && 
                (
                    UnisphereApiVersion == other.UnisphereApiVersion ||
                    UnisphereApiVersion != null &&
                    UnisphereApiVersion.Equals(other.UnisphereApiVersion)
                ) && 
                (
                    IsEmbedded == other.IsEmbedded ||
                    IsEmbedded != null &&
                    IsEmbedded.Equals(other.IsEmbedded)
                ) && 
                (
                    UcodeVersion == other.UcodeVersion ||
                    UcodeVersion != null &&
                    UcodeVersion.Equals(other.UcodeVersion)
                ) && 
                (
                    SupportedImportType == other.SupportedImportType ||
                    SupportedImportType != null &&
                    SupportedImportType.Equals(other.SupportedImportType)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    LastUpdatedTimestamp == other.LastUpdatedTimestamp ||
                    LastUpdatedTimestamp != null &&
                    LastUpdatedTimestamp.Equals(other.LastUpdatedTimestamp)
                ) && 
                (
                    Port == other.Port ||
                    Port != null &&
                    Port.Equals(other.Port)
                ) && 
                (
                    SupportedImportTypeL10n == other.SupportedImportTypeL10n ||
                    SupportedImportTypeL10n != null &&
                    SupportedImportTypeL10n.Equals(other.SupportedImportTypeL10n)
                ) && 
                (
                    ImportVmaxVolumes == other.ImportVmaxVolumes ||
                    ImportVmaxVolumes != null &&
                    ImportVmaxVolumes.SequenceEqual(other.ImportVmaxVolumes)
                ) && 
                (
                    ImportVmaxStorageGroup == other.ImportVmaxStorageGroup ||
                    ImportVmaxStorageGroup != null &&
                    ImportVmaxStorageGroup.SequenceEqual(other.ImportVmaxStorageGroup)
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
                    if (SymmetrixId != null)
                    hashCode = hashCode * 59 + SymmetrixId.GetHashCode();
                    if (ManagementAddress != null)
                    hashCode = hashCode * 59 + ManagementAddress.GetHashCode();
                    if (Model != null)
                    hashCode = hashCode * 59 + Model.GetHashCode();
                    if (UnisphereApiVersion != null)
                    hashCode = hashCode * 59 + UnisphereApiVersion.GetHashCode();
                    if (IsEmbedded != null)
                    hashCode = hashCode * 59 + IsEmbedded.GetHashCode();
                    if (UcodeVersion != null)
                    hashCode = hashCode * 59 + UcodeVersion.GetHashCode();
                    if (SupportedImportType != null)
                    hashCode = hashCode * 59 + SupportedImportType.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (LastUpdatedTimestamp != null)
                    hashCode = hashCode * 59 + LastUpdatedTimestamp.GetHashCode();
                    if (Port != null)
                    hashCode = hashCode * 59 + Port.GetHashCode();
                    if (SupportedImportTypeL10n != null)
                    hashCode = hashCode * 59 + SupportedImportTypeL10n.GetHashCode();
                    if (ImportVmaxVolumes != null)
                    hashCode = hashCode * 59 + ImportVmaxVolumes.GetHashCode();
                    if (ImportVmaxStorageGroup != null)
                    hashCode = hashCode * 59 + ImportVmaxStorageGroup.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportVmaxInstance left, ImportVmaxInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportVmaxInstance left, ImportVmaxInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
