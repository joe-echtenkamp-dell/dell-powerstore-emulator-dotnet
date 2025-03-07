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
    /// PS Group details. This resource type has queriable association from import_psgroup_volume
    /// </summary>
    [DataContract]
    public partial class ImportPsgroupInstance : IEquatable<ImportPsgroupInstance>
    { 
        /// <summary>
        /// Unique identifier of the PS Group.
        /// </summary>
        /// <value>Unique identifier of the PS Group.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the PS Group.  This property supports case-insensitive filtering.
        /// </summary>
        /// <value>Name of the PS Group.  This property supports case-insensitive filtering.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Serial number of the PS Group.
        /// </summary>
        /// <value>Serial number of the PS Group.</value>

        [DataMember(Name="serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Management address of the PS Group. This can be an IPv4 address or FQDN (Fully Qualified Domain Name). 
        /// </summary>
        /// <value>Management address of the PS Group. This can be an IPv4 address or FQDN (Fully Qualified Domain Name). </value>

        [DataMember(Name="management_address")]
        public string ManagementAddress { get; set; }

        /// <summary>
        /// Description of the PS Group.
        /// </summary>
        /// <value>Description of the PS Group.</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Name used to log in to the PS Group.
        /// </summary>
        /// <value>Name used to log in to the PS Group.</value>

        [DataMember(Name="user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// IP address of the PS Group, which is used for data path communication. If a management address is not configured, this address is also used for management operations. 
        /// </summary>
        /// <value>IP address of the PS Group, which is used for data path communication. If a management address is not configured, this address is also used for management operations. </value>

        [DataMember(Name="group_address")]
        public string GroupAddress { get; set; }

        /// <summary>
        /// Time when the PS Group was last updated.
        /// </summary>
        /// <value>Time when the PS Group was last updated.</value>

        [DataMember(Name="last_update_time")]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        ///  Was added in version 1.0.2.
        /// </summary>
        /// <value> Was added in version 1.0.2.</value>

        [DataMember(Name="supported_import_type")]
        public SupportedImportTypeEnum? SupportedImportType { get; set; }

        /// <summary>
        /// Localized message string corresponding to supported_import_type Was added in version 1.0.2.
        /// </summary>
        /// <value>Localized message string corresponding to supported_import_type Was added in version 1.0.2.</value>

        [DataMember(Name="supported_import_type_l10n")]
        public string SupportedImportTypeL10n { get; set; }

        /// <summary>
        /// This is the inverse of the resource type import_psgroup_volume association.
        /// </summary>
        /// <value>This is the inverse of the resource type import_psgroup_volume association.</value>

        [DataMember(Name="import_psgroup_volumes")]
        public List<ImportPsgroupVolumeInstance> ImportPsgroupVolumes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportPsgroupInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  ManagementAddress: ").Append(ManagementAddress).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  GroupAddress: ").Append(GroupAddress).Append("\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  SupportedImportType: ").Append(SupportedImportType).Append("\n");
            sb.Append("  SupportedImportTypeL10n: ").Append(SupportedImportTypeL10n).Append("\n");
            sb.Append("  ImportPsgroupVolumes: ").Append(ImportPsgroupVolumes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImportPsgroupInstance)obj);
        }

        /// <summary>
        /// Returns true if ImportPsgroupInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportPsgroupInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportPsgroupInstance other)
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
                    SerialNumber == other.SerialNumber ||
                    SerialNumber != null &&
                    SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    ManagementAddress == other.ManagementAddress ||
                    ManagementAddress != null &&
                    ManagementAddress.Equals(other.ManagementAddress)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    GroupAddress == other.GroupAddress ||
                    GroupAddress != null &&
                    GroupAddress.Equals(other.GroupAddress)
                ) && 
                (
                    LastUpdateTime == other.LastUpdateTime ||
                    LastUpdateTime != null &&
                    LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    SupportedImportType == other.SupportedImportType ||
                    SupportedImportType != null &&
                    SupportedImportType.Equals(other.SupportedImportType)
                ) && 
                (
                    SupportedImportTypeL10n == other.SupportedImportTypeL10n ||
                    SupportedImportTypeL10n != null &&
                    SupportedImportTypeL10n.Equals(other.SupportedImportTypeL10n)
                ) && 
                (
                    ImportPsgroupVolumes == other.ImportPsgroupVolumes ||
                    ImportPsgroupVolumes != null &&
                    ImportPsgroupVolumes.SequenceEqual(other.ImportPsgroupVolumes)
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
                    if (SerialNumber != null)
                    hashCode = hashCode * 59 + SerialNumber.GetHashCode();
                    if (ManagementAddress != null)
                    hashCode = hashCode * 59 + ManagementAddress.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (GroupAddress != null)
                    hashCode = hashCode * 59 + GroupAddress.GetHashCode();
                    if (LastUpdateTime != null)
                    hashCode = hashCode * 59 + LastUpdateTime.GetHashCode();
                    if (SupportedImportType != null)
                    hashCode = hashCode * 59 + SupportedImportType.GetHashCode();
                    if (SupportedImportTypeL10n != null)
                    hashCode = hashCode * 59 + SupportedImportTypeL10n.GetHashCode();
                    if (ImportPsgroupVolumes != null)
                    hashCode = hashCode * 59 + ImportPsgroupVolumes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImportPsgroupInstance left, ImportPsgroupInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImportPsgroupInstance left, ImportPsgroupInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
