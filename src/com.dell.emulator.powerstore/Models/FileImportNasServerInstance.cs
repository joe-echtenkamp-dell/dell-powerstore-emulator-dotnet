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
    ///  Was added in version 3.0.0.0. Values was added in 3.2.0.0: is_importable, non_importable_criteria, non_importable_messages.
    /// </summary>
    [DataContract]
    public partial class FileImportNasServerInstance : IEquatable<FileImportNasServerInstance>
    { 
        /// <summary>
        /// Unique identifier of the NAS Server for the file import connection.
        /// </summary>
        /// <value>Unique identifier of the NAS Server for the file import connection.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the NAS Server for the file import connection.
        /// </summary>
        /// <value>Name of the NAS Server for the file import connection.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolType
        /// </summary>

        [DataMember(Name="protocol_type")]
        public FileImportNasServerProtocolTypeEnum? ProtocolType { get; set; }

        /// <summary>
        /// Unique identifier of the remote system where the NAS Server exists.
        /// </summary>
        /// <value>Unique identifier of the remote system where the NAS Server exists.</value>

        [DataMember(Name="remote_system_id")]
        public string RemoteSystemId { get; set; }

        /// <summary>
        /// Gets or Sets SmbServer
        /// </summary>

        [DataMember(Name="smb_server")]
        public FileImportSmbConfiguration SmbServer { get; set; }

        /// <summary>
        /// Filtering on the fields of this embedded resource is not supported.
        /// </summary>
        /// <value>Filtering on the fields of this embedded resource is not supported.</value>

        [DataMember(Name="file_systems")]
        public List<FileImportSourceFilesystem> FileSystems { get; set; }

        /// <summary>
        /// Filtering on the fields of this embedded resource is not supported.
        /// </summary>
        /// <value>Filtering on the fields of this embedded resource is not supported.</value>

        [DataMember(Name="file_interfaces")]
        public List<FileImportSourceNetworkInterface> FileInterfaces { get; set; }

        /// <summary>
        /// Indicates whether the NAS Server is ready to import. Was added in version 3.2.0.0.
        /// </summary>
        /// <value>Indicates whether the NAS Server is ready to import. Was added in version 3.2.0.0.</value>

        [DataMember(Name="is_importable")]
        public bool? IsImportable { get; set; }

        /// <summary>
        /// When is_importable is false, this lists the reasons the import cannot be performed. Was added in version 3.2.0.0.
        /// </summary>
        /// <value>When is_importable is false, this lists the reasons the import cannot be performed. Was added in version 3.2.0.0.</value>

        [DataMember(Name="non_importable_criteria")]
        public List<FileImportNasServerImportableCriteriaEnum> NonImportableCriteria { get; set; }

        /// <summary>
        /// When is_importable is false, these messages describe the reasons and recommended remedies. Was added in version 3.2.0.0.  Filtering on the fields of this embedded resource is not supported.
        /// </summary>
        /// <value>When is_importable is false, these messages describe the reasons and recommended remedies. Was added in version 3.2.0.0.  Filtering on the fields of this embedded resource is not supported.</value>

        [DataMember(Name="non_importable_messages")]
        public List<FileExtendedLocalizedMessage> NonImportableMessages { get; set; }

        /// <summary>
        /// Indicates NAS Server importable criteria. The expected values are NOT_READY_FOR_IMPORT, READY. For nasservers that are already been imported the value is NOT_READY_FOR_IMPORT. As the nasservers are already imported they are not available for import hence the enum NOT_READY_FOR_IMPORT. Was added in version 3.0.0.0. Was deprecated in version 3.0.0.0.
        /// </summary>
        /// <value>Indicates NAS Server importable criteria. The expected values are NOT_READY_FOR_IMPORT, READY. For nasservers that are already been imported the value is NOT_READY_FOR_IMPORT. As the nasservers are already imported they are not available for import hence the enum NOT_READY_FOR_IMPORT. Was added in version 3.0.0.0. Was deprecated in version 3.0.0.0.</value>

        [DataMember(Name="importable_criteria")]
        public string ImportableCriteria { get; set; }

        /// <summary>
        /// If the NAS server is not importable, this is a &#39;#&#39;-separated list of one or more reason codes that report why it is not importable. Was added in version 3.0.0.0. Was deprecated in version 3.0.0.0.
        /// </summary>
        /// <value>If the NAS server is not importable, this is a &#39;#&#39;-separated list of one or more reason codes that report why it is not importable. Was added in version 3.0.0.0. Was deprecated in version 3.0.0.0.</value>

        [DataMember(Name="non_importable_reasons")]
        public string NonImportableReasons { get; set; }

        /// <summary>
        /// Localized message string corresponding to protocol_type Was added in version 3.0.0.0.
        /// </summary>
        /// <value>Localized message string corresponding to protocol_type Was added in version 3.0.0.0.</value>

        [DataMember(Name="protocol_type_l10n")]
        public string ProtocolTypeL10n { get; set; }

        /// <summary>
        /// Localized message array corresponding to non_importable_criteria Was added in version 3.2.0.0.
        /// </summary>
        /// <value>Localized message array corresponding to non_importable_criteria Was added in version 3.2.0.0.</value>

        [DataMember(Name="non_importable_criteria_l10n")]
        public List<string> NonImportableCriteriaL10n { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileImportNasServerInstance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProtocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  RemoteSystemId: ").Append(RemoteSystemId).Append("\n");
            sb.Append("  SmbServer: ").Append(SmbServer).Append("\n");
            sb.Append("  FileSystems: ").Append(FileSystems).Append("\n");
            sb.Append("  FileInterfaces: ").Append(FileInterfaces).Append("\n");
            sb.Append("  IsImportable: ").Append(IsImportable).Append("\n");
            sb.Append("  NonImportableCriteria: ").Append(NonImportableCriteria).Append("\n");
            sb.Append("  NonImportableMessages: ").Append(NonImportableMessages).Append("\n");
            sb.Append("  ImportableCriteria: ").Append(ImportableCriteria).Append("\n");
            sb.Append("  NonImportableReasons: ").Append(NonImportableReasons).Append("\n");
            sb.Append("  ProtocolTypeL10n: ").Append(ProtocolTypeL10n).Append("\n");
            sb.Append("  NonImportableCriteriaL10n: ").Append(NonImportableCriteriaL10n).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FileImportNasServerInstance)obj);
        }

        /// <summary>
        /// Returns true if FileImportNasServerInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of FileImportNasServerInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileImportNasServerInstance other)
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
                    ProtocolType == other.ProtocolType ||
                    ProtocolType != null &&
                    ProtocolType.Equals(other.ProtocolType)
                ) && 
                (
                    RemoteSystemId == other.RemoteSystemId ||
                    RemoteSystemId != null &&
                    RemoteSystemId.Equals(other.RemoteSystemId)
                ) && 
                (
                    SmbServer == other.SmbServer ||
                    SmbServer != null &&
                    SmbServer.Equals(other.SmbServer)
                ) && 
                (
                    FileSystems == other.FileSystems ||
                    FileSystems != null &&
                    FileSystems.SequenceEqual(other.FileSystems)
                ) && 
                (
                    FileInterfaces == other.FileInterfaces ||
                    FileInterfaces != null &&
                    FileInterfaces.SequenceEqual(other.FileInterfaces)
                ) && 
                (
                    IsImportable == other.IsImportable ||
                    IsImportable != null &&
                    IsImportable.Equals(other.IsImportable)
                ) && 
                (
                    NonImportableCriteria == other.NonImportableCriteria ||
                    NonImportableCriteria != null &&
                    NonImportableCriteria.SequenceEqual(other.NonImportableCriteria)
                ) && 
                (
                    NonImportableMessages == other.NonImportableMessages ||
                    NonImportableMessages != null &&
                    NonImportableMessages.SequenceEqual(other.NonImportableMessages)
                ) && 
                (
                    ImportableCriteria == other.ImportableCriteria ||
                    ImportableCriteria != null &&
                    ImportableCriteria.Equals(other.ImportableCriteria)
                ) && 
                (
                    NonImportableReasons == other.NonImportableReasons ||
                    NonImportableReasons != null &&
                    NonImportableReasons.Equals(other.NonImportableReasons)
                ) && 
                (
                    ProtocolTypeL10n == other.ProtocolTypeL10n ||
                    ProtocolTypeL10n != null &&
                    ProtocolTypeL10n.Equals(other.ProtocolTypeL10n)
                ) && 
                (
                    NonImportableCriteriaL10n == other.NonImportableCriteriaL10n ||
                    NonImportableCriteriaL10n != null &&
                    NonImportableCriteriaL10n.SequenceEqual(other.NonImportableCriteriaL10n)
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
                    if (ProtocolType != null)
                    hashCode = hashCode * 59 + ProtocolType.GetHashCode();
                    if (RemoteSystemId != null)
                    hashCode = hashCode * 59 + RemoteSystemId.GetHashCode();
                    if (SmbServer != null)
                    hashCode = hashCode * 59 + SmbServer.GetHashCode();
                    if (FileSystems != null)
                    hashCode = hashCode * 59 + FileSystems.GetHashCode();
                    if (FileInterfaces != null)
                    hashCode = hashCode * 59 + FileInterfaces.GetHashCode();
                    if (IsImportable != null)
                    hashCode = hashCode * 59 + IsImportable.GetHashCode();
                    if (NonImportableCriteria != null)
                    hashCode = hashCode * 59 + NonImportableCriteria.GetHashCode();
                    if (NonImportableMessages != null)
                    hashCode = hashCode * 59 + NonImportableMessages.GetHashCode();
                    if (ImportableCriteria != null)
                    hashCode = hashCode * 59 + ImportableCriteria.GetHashCode();
                    if (NonImportableReasons != null)
                    hashCode = hashCode * 59 + NonImportableReasons.GetHashCode();
                    if (ProtocolTypeL10n != null)
                    hashCode = hashCode * 59 + ProtocolTypeL10n.GetHashCode();
                    if (NonImportableCriteriaL10n != null)
                    hashCode = hashCode * 59 + NonImportableCriteriaL10n.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FileImportNasServerInstance left, FileImportNasServerInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FileImportNasServerInstance left, FileImportNasServerInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
